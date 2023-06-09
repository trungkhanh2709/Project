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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnDanngNhap_Click(object sender, EventArgs e)
        {
            Form f = nextForm(txtUserID.Text, txtPass.Text);

            if (f == null)
                return;

            f.FormClosed += f_FormClosed;// xu ly dong form
            f.StartPosition = FormStartPosition.CenterScreen;// xu ly form mo ra o center
            f.Show();
            this.Hide();
            ClearTextBox();
        }
        void f_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        void ClearTextBox()
        {
            txtUserID.Clear();
            txtPass.Clear();
        }

         Form nextForm(string id, string pass)
        {
            Form f = new Form();

            int roll = 0;

            using(QuanLyNhaHangEntities6 db = new QuanLyNhaHangEntities6())
            {

                var t = db.TaiKhoan.Where(p => p.UserName.Equals(id) && p.PassWord.Equals(pass));             
                TaiKhoan tk = t.Count() == 1? t.Single() : null;              
                if (tk != null)
                {
                    Control.Cons.LoginTaiKhoan = tk;
                    if (tk.LoaiTaiKhoan == "Quản lí")
                    {
                        roll = 1;  
                    }
                    else roll = 0;
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
                    
                    return null;
                }
            }

            switch (roll)
            {
                case 0:
                    f = new FBan();// form của nhân viên              
                    break;
                case 1:
                    f = new FBan();// form của quản lý                 
                    break;
            }
            return f;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkbPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbPass.Checked == true)
            {
                txtPass.PasswordChar = (char)0;
            }
            else
            {
                txtPass.PasswordChar = '*';
            }
        }

        private void txtUserID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
        }
    }
}
