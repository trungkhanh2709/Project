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
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;

namespace Đồ_Án_Cuối_Kỳ___Lập_Trình_Hướng_Đối_Tượng.PVIEW
{
    public partial class FQLNhanVien : Form
    {
        CNhanVien ctrNV = new CNhanVien();
        List<NhanVien> dsNV = new List<NhanVien>();
        public FQLNhanVien()
        {
            InitializeComponent();
            loadDSNhanVien();
        }
        void loadDSNhanVien()
        {
            dsNV = ctrNV.findALL();
            // chọn lại các thuộc tính cần hiển thị lên datagridview
            var rs = from t in dsNV
                     select new
                     {
                         t.id,
                         t.tennhanvien,
                         t.sodienthoai,
                         t.ngaysinh,
                         t.diachi,
                         t.CMND,
                         t.ngaybatdaulam,
                         t.gioitinh,
                     };
            dtgvQuanLiNhanVien.DataSource = rs.ToList();
        }
        void timKiemNV()
        {
            var lst = ctrNV.findNV(txtbTimNhanVien.Text);
            var rst = from s in lst
                      select new { s.id, s.tennhanvien, s.sodienthoai, s.ngaysinh, s.diachi, s.CMND, s.ngaybatdaulam, s.gioitinh };
            dtgvQuanLiNhanVien.DataSource = rst.ToList();
            dtgvQuanLiNhanVien.Refresh();

        }

        private void btnTimKiemNV_Click(object sender, EventArgs e)
        {
            timKiemNV();
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien
            {
                /* id = Int32.Parse(txtbIDNhanVien.Text),*/
                tennhanvien = txtbTenNhanVien.Text,
                sodienthoai = txtbSodienthoai.Text,
                ngaysinh = dateTimeNgaySinh.Value,
                diachi = txtbDiaChi.Text,
                CMND = txtbCMND.Text,
                ngaybatdaulam = dateTimeNgayNhanVienLam.Value,
                gioitinh = (radioNam.Checked == true ? "Nam" : "Nữ"),
            };
            //Them gioi tuong vao CSDL (do vao SQL)
            ctrNV.add(nv);
            //Load lai vao trong datagridview
            loadDSNhanVien();
        }

        private void btnSuaNhanVien_Click(object sender, EventArgs e)
        {
            int id = dtgvQuanLiNhanVien.CurrentCell.RowIndex;
            string manv = dtgvQuanLiNhanVien.Rows[id].Cells[0].Value + "";
            NhanVien s = ctrNV.find(manv);
            //thay doi thong tin nhung khong thay doi ID
            s.tennhanvien = txtbTenNhanVien.Text;
            s.sodienthoai = txtbSodienthoai.Text;
            s.ngaysinh = dateTimeNgaySinh.Value;
            s.diachi = txtbDiaChi.Text;
            s.CMND = txtbCMND.Text;
            s.ngaybatdaulam = dateTimeNgayNhanVienLam.Value.Date;
            s.gioitinh = radioNam.Checked == true ? "Nam" : "Nữ";
            ctrNV.update(s);
            loadDSNhanVien();
        }

        private void btnXoaNhanVien_Click(object sender, EventArgs e)
        {
            //xac dinh nguoi can xoa
            int index = dtgvQuanLiNhanVien.CurrentCell.RowIndex;
            string manv = dtgvQuanLiNhanVien.Rows[index].Cells[0].Value + "";
            NhanVien s = ctrNV.find(manv);
            //xoa trong cac textbox
            txtbIDNhanVien.Clear();
            txtbTenNhanVien.Clear();
            txtbSodienthoai.Clear();
            txtbDiaChi.Clear();
            txtbCMND.Clear();
            /*radioNam.Checked = true;*/
            //xoa trong datagridview
            if (s.TaiKhoan.Count == 0)
            {
                ctrNV.delete(s);
                loadDSNhanVien();
            }
            else
            {
                MessageBox.Show("Nhân viên đã được cấp tài khoản không thể xóa!!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            loadDSNhanVien();
        }

        private void btnLamMoiNV_Click(object sender, EventArgs e)
        {
            int index = dtgvQuanLiNhanVien.CurrentCell.RowIndex;
            /*string timnv = txtbTimNhanVien.Text;
            string manv = dtgvQuanLiNhanVien.Rows[index].Cells[1].Value + "";*/
            /*NhanVien s = ctrNV.find(manv);
            NhanVien t = ctrNV.find(timnv);*/
            txtbIDNhanVien.Clear();
            txtbSodienthoai.Clear();
            txtbTenNhanVien.Clear();
            txtbDiaChi.Clear();
            txtbCMND.Clear();
            txtbTimNhanVien.Clear();
            txtbTenNhanVien.Focus();
            radioNam.Checked = true;
            radioNữ.Checked = false;
            loadDSNhanVien();
        }

        private void dtgvQuanLiNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dtgvQuanLiNhanVien.CurrentCell.RowIndex;
            //lay tu cac o o dtgv roi show len

            //
            string strmaNV = dtgvQuanLiNhanVien.Rows[index].Cells[0].Value + "";
            NhanVien s = ctrNV.find(strmaNV);
            if (s != null)
            {
                txtbIDNhanVien.Text = (s.id).ToString();
                txtbTenNhanVien.Text = s.tennhanvien;
                txtbSodienthoai.Text = s.sodienthoai;
                s.ngaysinh = dateTimeNgaySinh.Value.Date;
                txtbDiaChi.Text = s.diachi;
                txtbCMND.Text = s.CMND;
                s.ngaybatdaulam = dateTimeNgayNhanVienLam.Value.Date;
                radioNam.Checked = (s.gioitinh == "Nam" ? true : false);
                radioNữ.Checked = (s.gioitinh == "Nữ" ? true : false);
            }
        }

        private void txtbTenNhanVien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtbSodienthoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtbCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //Excel
        private void ExportExcel(string path)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < dtgvQuanLiNhanVien.Columns.Count; i++)
            {
                application.Cells[1, i + 1] = dtgvQuanLiNhanVien.Columns[i].HeaderText;
            }
            for (int i = 0; i < dtgvQuanLiNhanVien.Rows.Count; i++)
            {
                for (int j = 0; j < dtgvQuanLiNhanVien.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1] = dtgvQuanLiNhanVien.Rows[i].Cells[j].Value;
                }
            }
            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveCopyAs(path);
            application.ActiveWorkbook.Saved = true;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Export Excel";
            saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportExcel(saveFileDialog.FileName);
                    MessageBox.Show("Xuất file thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xuất file không thành công!\n" + ex.Message);
                }
            }
        }
    }
}
