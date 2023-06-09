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
    public partial class FNhapKhachHang : Form
    {
        CKhachHang ka = new CKhachHang();
        CBanAn ba = new CBanAn();
        CPhieuTamTinhHoaDon ptthd = new CPhieuTamTinhHoaDon();
        public FNhapKhachHang()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            KhachHang khach = new KhachHang()
            {
                sdt = textsdt.Text,
                tenkhachhang = textTen.Text,
                gioitinh = (radam.Checked == true ? "Nam" : "Nữ"),

            };
            ka.add(khach);
            FDatMon fdm = new FDatMon();
            fdm.Show();
            fdm.GetTenKhachHang();

            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           FBan f = new FBan();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void FNhapKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
           /* FBan n= new FBan();
            n.Show();*/
        }

        private void textTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
