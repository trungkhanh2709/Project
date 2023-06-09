using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Đồ_Án_Cuối_Kỳ___Lập_Trình_Hướng_Đối_Tượng.PVIEW;
using Đồ_Án_Cuối_Kỳ___Lập_Trình_Hướng_Đối_Tượng.Control;

namespace Đồ_Án_Cuối_Kỳ___Lập_Trình_Hướng_Đối_Tượng
{
    public partial class FQLTaiKhoan : Form
    {
        CTaiKhoan ctrTK = new CTaiKhoan();
        List<TaiKhoan> dsTK = new List<TaiKhoan>();
        CNhanVien ctrnv = new CNhanVien();
        List<NhanVien> dsnv = new List<NhanVien>();
        public FQLTaiKhoan()
        {
            InitializeComponent();
            loadDSTaiKhoan();
            LoadCMBTenNV();
        }
        void loadDSTaiKhoan()
        {
            dsTK = ctrTK.findAll();
            dsnv = ctrnv.findALL();
            // chọn lại các thuộc tính cần hiển thị lên datagridview
            var rs = from t in dsTK
                     from n in dsnv
                     where t.idnhanvien == n.id
                     select new
                     {
                         t.id,
                         t.UserName,
                         t.PassWord,
                         TenNhanVien = n.tennhanvien,
                         t.LoaiTaiKhoan,
                     };
            dtgvTaiKhoan.DataSource = rs.ToList();
        }
        void LoadCMBTenNV()
        {
            List<NhanVien> dsKhoa = ctrnv.findALL();
            cmbTenNV.DataSource = dsKhoa;
            cmbTenNV.DisplayMember = "tennhanvien";
        }
        private void btnThemTaiKhoan_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = new TaiKhoan
            {
                /* id = Int32.Parse(txtbIDTaiKhoan.Text),*/
                UserName = txtbTenTaiKhoan.Text,
                PassWord = txtbMatKhauTK.Text,
                idnhanvien = cmbTenNV.SelectedIndex,
                LoaiTaiKhoan = (radioQuanli.Checked == true ? "Quản lí" : "Nhân viên"),
            };
            //Them gioi tuong vao CSDL (do vao SQL)
            ctrTK.add(tk);
            //Load lai vao trong datagridview
            loadDSTaiKhoan();
        }

        private void btnSuaTaiKhoan_Click(object sender, EventArgs e)
        {
            int id = dtgvTaiKhoan.CurrentCell.RowIndex;
            string matk = dtgvTaiKhoan.Rows[id].Cells[0].Value + "";
            TaiKhoan s = ctrTK.find(matk);
            //thay doi thong tin nhung khong thay doi ID
            s.UserName = txtbTenTaiKhoan.Text;
            s.PassWord = txtbMatKhauTK.Text;
            /*         s.idnhanvien = Int32.Parse(txtbIDNhanVienTK.Text);*/
            s.LoaiTaiKhoan = (radioQuanli.Checked == true ? "Quản lí" : "Nhân viên");
            ctrTK.update(s);
            loadDSTaiKhoan();
        }

        private void btnXoaTaiKhoan_Click(object sender, EventArgs e)
        {

            int index = dtgvTaiKhoan.CurrentCell.RowIndex;
            string matk = dtgvTaiKhoan.Rows[index].Cells[0].Value + "";
            TaiKhoan s = ctrTK.find(matk);
            //xoa trong cac textbox
            txtbIDTaiKhoan.Clear();
            txtbTenTaiKhoan.Clear();
            txtbMatKhauTK.Clear();
            /*   txtbIDNhanVienTK.Clear();*/
            /*radioNam.Checked = true;*/
            //xoa trong datagridview
            ctrTK.delete(s);
            loadDSTaiKhoan();
        }

        private void btnLamMoiTaiKhoan_Click(object sender, EventArgs e)
        {
            int index = dtgvTaiKhoan.CurrentCell.RowIndex;
            string timtk = txtbTimTaiKhoan.Text;
            string matk = dtgvTaiKhoan.Rows[index].Cells[1].Value + "";
            /*TaiKhoan s = ctrTK.find(matk);
            TaiKhoan t = ctrTK.find(timtk);*/
            txtbIDTaiKhoan.Clear();
            txtbTenTaiKhoan.Clear();
            txtbMatKhauTK.Clear();
            txtbTimTaiKhoan.Clear();
            txtbTenTaiKhoan.Focus();
            /*    txtbIDNhanVienTK.Clear();*/
            radioPhucVu.Checked = true;
            radioQuanli.Checked = false;
            loadDSTaiKhoan();
        }
        void timKiemTK()
        {
            var lst = ctrTK.findTK(txtbTimTaiKhoan.Text);
            var rst = from s in lst
                      select new { s.id, s.UserName, s.PassWord, s.idnhanvien, s.LoaiTaiKhoan };
            dtgvTaiKhoan.DataSource = rst.ToList();
            dtgvTaiKhoan.Refresh();
        }

        private void btnTimTaiKhoan_Click(object sender, EventArgs e)
        {
            timKiemTK();
        }

        private void dtgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dtgvTaiKhoan.CurrentCell.RowIndex;
            //lay tu cac o o dtgv roi show len

            //
            string strmaTK = dtgvTaiKhoan.Rows[index].Cells[0].Value + "";
            TaiKhoan s = ctrTK.find(strmaTK);
            if (s != null)
            {
                txtbIDTaiKhoan.Text = strmaTK;
                txtbTenTaiKhoan.Text = s.UserName;
                txtbMatKhauTK.Text = s.PassWord;
                cmbTenNV.Text = (s.NhanVien.tennhanvien);
                radioQuanli.Checked = (s.LoaiTaiKhoan == "Quản lí" ? true : false);
                radioPhucVu.Checked = (s.LoaiTaiKhoan == "Nhân viên" ? true : false);


            }
        }
    }
}
