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
    public partial class FQLMonAn : Form
    {
        CMonAn ctrmonan = new CMonAn();
        List<MonAn> dsma = new List<MonAn>();
        CLoaiMon dslm = new CLoaiMon();
        CChiTietHoaDon ctrct = new CChiTietHoaDon();

        CDanhMucMonAn ctrdmma = new CDanhMucMonAn();
        List<DanhSachMonAn> dsdmma = new List<DanhSachMonAn>();

        public FQLMonAn()
        {
            InitializeComponent();
            loadMonAn();
            LoadCMBLoaiMon();
        }
        void loadMonAn()
        {
            dsma = ctrmonan.findAll();
            dsdmma = ctrdmma.findAll();
            //chon lai cac thuôc tinh can hien thi tren datagridview
            var rs = from m in dsma
                     from d in dsdmma
                     where m.idDSMonAn == d.id
                     select new { m.id, m.ten, m.gia, TenDanhMuc = d.ten };
            dtgMonAn.DataSource = rs.ToList();
        }
        void LoadCMBLoaiMon()
        {
            List<DanhSachMonAn> dsKhoa = dslm.GetLoaiMon();
            cmbDMMon.DataSource = dsKhoa;
            cmbDMMon.DisplayMember = "Ten";
        }

        private void btnThemMA_Click(object sender, EventArgs e)
        {

            MonAn sv = new MonAn
            {
                ten = txtMonAn.Text,
                gia = double.Parse(txtGia.Text),
                idDSMonAn = cmbDMMon.SelectedIndex + 1
            };
            //thêm đối tượng vào csdl
            ctrmonan.add(sv);
            //load lại lưới
            loadMonAn();

        }

        private void btnSuaMA_Click(object sender, EventArgs e)
        {
            int id = dtgMonAn.CurrentCell.RowIndex;
            string mamon = dtgMonAn.Rows[id].Cells[0].Value + "";
            MonAn s = ctrmonan.find(mamon);
            //thay đổi cac thông tin nhưng ko thay doi masinhvien
            s.ten = txtMonAn.Text;
            s.gia = double.Parse(txtGia.Text);
            s.idDSMonAn = cmbDMMon.SelectedIndex + 1;
            ctrmonan.update(s);
            loadMonAn();
        }

        private void btnXoaMA_Click(object sender, EventArgs e)
        {
            int index = dtgMonAn.CurrentCell.RowIndex;
            string manv = dtgMonAn.Rows[index].Cells[0].Value + "";
            MonAn s = ctrmonan.find(manv);
            //xoa trong cac textbox
            txtID.Clear();
            txtMonAn.Clear();
            txtGia.Clear();
            cmbDMMon.SelectedIndex = 0;

            /*radioNam.Checked = true;*/
            //xoa trong datagridview
            if (s.ChiTietHoaDon.Count == 0)
            {
                ctrmonan.delete(s);
                loadMonAn();
            }
            else
            {
                MessageBox.Show("Món ăn đang được đặt, không thể xóa!!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            loadMonAn();
        }

        private void btnClearMA_Click(object sender, EventArgs e)
        {
            /*TaiKhoan s = ctrTK.find(matk);
            TaiKhoan t = ctrTK.find(timtk);*/
            txtID.Clear();
            txtMonAn.Clear();
            txtGia.Clear();
            txtbTimMA.Clear();
            txtbTimMA.Focus();
            cmbDMMon.SelectedIndex = 0;
            loadMonAn();
        }

        void timMonAn()
        {
            var lst = ctrmonan.findMA(txtbTimMA.Text);
            var rst = from s in lst
                      select new { s.id, s.ten, s.gia, TenDanhMuc = s.DanhSachMonAn.ten };
            dtgMonAn.DataSource = rst.ToList();
            dtgMonAn.Refresh();

        }
        private void btnTimMA_Click(object sender, EventArgs e)
        {
            timMonAn();
        }

        private void dtgMonAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dtgMonAn.CurrentCell.RowIndex;
            //c1.lay tư cac o ơ dtgv roi show len

            //c2.lay sinh vien dang chon roi show len
            string strma = dtgMonAn.Rows[index].Cells[0].Value + "";
            MonAn s = ctrmonan.find(strma);
            if (s != null)
            {
                txtID.Text = (s.id).ToString();
                txtMonAn.Text = s.ten;
                txtGia.Text = Convert.ToString(s.gia);
                cmbDMMon.Text = (s.DanhSachMonAn.ten);
            }
        }


        private void txtMonAn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cmbDMMon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtbTimMA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtbTimMA_TextChanged(object sender, EventArgs e)
        {

        }

        private void FQLMonAn_Load(object sender, EventArgs e)
        {

        }
    }
}
