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
    public partial class FQLBanAn : Form
    {
        CBanAn ctrBA = new CBanAn();
        List<BanAn> dsBA = new List<BanAn>();
        public FQLBanAn()
        {
            InitializeComponent();
            loadDSBanAn();
        }
        void loadDSBanAn()
        {
            dsBA = ctrBA.findAll();
            // chọn lại các thuộc tính cần hiển thị lên datagridview
            var rs = from t in dsBA
                     select new
                     {
                         t.id,
                         t.Ten,
                         t.TinhTrang,
                         /*  t.idnhanvien,*/

                     };
            dtgvBanAn.DataSource = rs.ToList();
        }
        void timKiemBA()
        {
            var lst = ctrBA.findBA(txtbTimBanAn.Text);
            var rst = from s in lst
                      select new { s.id, s.Ten, s.TinhTrang };
            dtgvBanAn.DataSource = rst.ToList();
            dtgvBanAn.Refresh();

        }

        private void btnTimBanAn_Click(object sender, EventArgs e)
        {
            timKiemBA();
        }

        private void btnThemBanAn_Click(object sender, EventArgs e)
        {
            BanAn ba = new BanAn
            {

                Ten = txtbTenBanAn.Text,

                TinhTrang = (radioCoNguoi.Checked == true ? "Có người" : "Trống"),
            };
            //Them gioi tuong vao CSDL (do vao SQL)
            ctrBA.add(ba);
            //Load lai vao trong datagridview
            loadDSBanAn();
        }

        private void btnSuaBanAn_Click(object sender, EventArgs e)
        {
            int id = dtgvBanAn.CurrentCell.RowIndex;
            string maba = dtgvBanAn.Rows[id].Cells[0].Value + "";
            BanAn s = ctrBA.find(maba);
            //thay doi thong tin nhung khong thay doi ID
            s.Ten = txtbTenBanAn.Text;

            s.TinhTrang = (radioCoNguoi.Checked == true ? "Có người" : "Trống");
            ctrBA.update(s);
            loadDSBanAn();
        }

        private void btnLamMoiBanAn_Click(object sender, EventArgs e)
        {
            int index = dtgvBanAn.CurrentCell.RowIndex;
            string tim = txtbTimBanAn.Text;
            /* string matk = dtgvBanAn.Rows[index].Cells[1].Value + "";*/
            txtbTimBanAn.Clear();
            txtbIDBanAn.Clear();
            txtbTenBanAn.Clear();
            txtbTenBanAn.Focus();
            radioTrong.Checked = true;
            radioCoNguoi.Checked = false;
            loadDSBanAn();
        }

        private void dtgvBanAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dtgvBanAn.CurrentCell.RowIndex;
            //lay tu cac o o dtgv roi show len

            //
            string maba = dtgvBanAn.Rows[index].Cells[0].Value + "";
            BanAn s = ctrBA.find(maba);
            if (s != null)
            {
                txtbIDBanAn.Text = (s.id).ToString();
                txtbTenBanAn.Text = s.Ten;

                radioCoNguoi.Checked = (s.TinhTrang == "Có người" ? true : false);
                radioTrong.Checked = (s.TinhTrang == "Trống" ? true : false);
            }
        }

        
        

        private void btnXoaBanAn_Click(object sender, EventArgs e)
        {
            //xac dinh nguoi can xoa
            int index = dtgvBanAn.CurrentCell.RowIndex;
            string matk = dtgvBanAn.Rows[index].Cells[0].Value + "";
            BanAn s = ctrBA.find(matk);
            //xoa trong cac textbox
            

            if (s.TinhTrang == "Trống")
            {
                ctrBA.delete(s);
                loadDSBanAn();
                txtbIDBanAn.Clear();
            txtbTenBanAn.Clear();
            txtbTimBanAn.Clear();
            }
            else
            {
                MessageBox.Show("Bàn đã đặt hoặc có khách, không thể xóa!!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //loadDSBanAn();
        }

        private void FQLBanAn_Load(object sender, EventArgs e)
        {

        }
    }
}
