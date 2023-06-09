using Đồ_Án_Cuối_Kỳ___Lập_Trình_Hướng_Đối_Tượng.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Đồ_Án_Cuối_Kỳ___Lập_Trình_Hướng_Đối_Tượng.PVIEW
{
    public partial class FQLDanhMucMA : Form
    {
        CMonAn ctrmonan = new CMonAn();
        List<MonAn> dsma = new List<MonAn>();
        CLoaiMon dslm = new CLoaiMon();
        CChiTietHoaDon ctrct = new CChiTietHoaDon();

        CDanhMucMonAn ctrdmma = new CDanhMucMonAn();
        List<DanhSachMonAn> dsdmma = new List<DanhSachMonAn>();
        public FQLDanhMucMA()
        {
            InitializeComponent();
            loadCMBDanhSachMonAn();
            loadLoaiMonAn();
        }
        void loadCMBDanhSachMonAn()
        {
            List<DanhSachMonAn> dskhoa = ctrdmma.findAll();
            dtgvDMMon.DataSource = dskhoa;
        }
        void loadLoaiMonAn()
        {
            dsdmma = ctrdmma.findAll();
            //chon lai cac thuôc tinh can hien thi tren datagridview
            var rs = from t in dsdmma select new { t.id, t.ten };
            dtgvDMMon.DataSource = rs.ToList();
        }

        private void btnThemDMMon_Click(object sender, EventArgs e)
        {
            DanhSachMonAn sv = new DanhSachMonAn
            {
                ten = txtTenDanhMuc.Text,
            };
            //thêm đối tượng vào csdl
            ctrdmma.add(sv);
            //load lại lưới
            loadLoaiMonAn();
        }

        private void btnSuaDMMon_Click(object sender, EventArgs e)
        {
            int id = dtgvDMMon.CurrentCell.RowIndex;
            string mamon = dtgvDMMon.Rows[id].Cells[0].Value + "";
            DanhSachMonAn s = ctrdmma.find(mamon);
            //thay đổi cac thông tin nhưng ko thay doi masinhvien
            s.ten = txtTenDanhMuc.Text;

            ctrdmma.update(s);
            loadLoaiMonAn();
        }

        private void btnXoaDMMon_Click(object sender, EventArgs e)
        {
            //xac dinh nguoi can xoa
            int index = dtgvDMMon.CurrentCell.RowIndex;
            string matk = dtgvDMMon.Rows[index].Cells[0].Value + "";
            DanhSachMonAn s = ctrdmma.find(matk);
            //xoa trong cac textbox
            txtIDDanhMuc.Clear();
            txtTenDanhMuc.Clear();

            
            if (s.MonAn.Count == 0)
            {
                ctrdmma.delete(s);
                loadLoaiMonAn();
            }
            else
            {
                MessageBox.Show("Danh mục món ăn đang chứa món ăn không thể xóa!!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            loadLoaiMonAn();
        }

        private void btnClearDMMon_Click(object sender, EventArgs e)
        {
            txtIDDanhMuc.Clear();
            txtTenDanhMuc.Clear();
            txtTenDanhMuc.Focus();
            loadLoaiMonAn();
        }
        void timDanhMucMon()
        {
            var lst = ctrdmma.findDMMA(txtTimDMMon.Text);
            var rst = from s in lst
                      select new { s.id, s.ten };
            dtgvDMMon.DataSource = rst.ToList();
            dtgvDMMon.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timDanhMucMon();
        }

        private void dtgvDMMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dtgvDMMon.CurrentCell.RowIndex;
            //c1.lay tư cac o ơ dtgv roi show len

            //c2.lay sinh vien dang chon roi show len
            string strma = dtgvDMMon.Rows[index].Cells[0].Value + "";
            DanhSachMonAn s = ctrdmma.find(strma);
            if (s != null)
            {
                txtIDDanhMuc.Text = (s.id).ToString();
                txtTenDanhMuc.Text = s.ten;

            }
        }

        private void txtTimDMMon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTenDanhMuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
