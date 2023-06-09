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

namespace Đồ_Án_Cuối_Kỳ___Lập_Trình_Hướng_Đối_Tượng.PVIEW
{
    public partial class QuanLy : Form
    {
        public QuanLy()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panel1.Controls.Add(leftBorderBtn);
            //form
            /*this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;*/
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private Button currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //button
                /*currentBtn = (IconButton)senderBtn;*/
               /* currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;*/
                //currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                /*currentBtn.IconColor = color;*/
                //currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                //currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                // left border button
                /*leftBorderBtn.BackColor = color;*/
                //leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                //leftBorderBtn.Visible = true;
                //leftBorderBtn.BringToFront();
                // icon chill home
                /*IconChillHome.IconChar = currentBtn.IconChar;
                IconChillHome.IconColor = color;*/

            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
            /*    currentBtn.IconColor = Color.Gainsboro;*/
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                //open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDeskTop.Controls.Add(childForm);
            panelDeskTop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblChillHome.Text = childForm.Text;
        }
        //methods


        private void btnQLNhanVien_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FQLNhanVien());
        }

        private void btnQLBanAn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FQLBanAn());
        }

        private void btnQLMonAn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FQLMonAn());
        }

        private void btnQLDanhMucMA_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FQLDanhMucMA());
        }

        private void btnQLTaiKhoan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FQLTaiKhoan());
        }

       /* private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);*/
       /* private extern static void ReleaseCapture();*/
        private void panelTitelBar_MouseDown(object sender, MouseEventArgs e)
        {
           /* ReleaseCapture();*/
            /*SendMessage(this.Handle, 0x112, 0xf012, 0);*/
        }

        
    }
}
