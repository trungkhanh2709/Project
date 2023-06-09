
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
    public partial class FBan : Form
    {
        CBanAn cban = new CBanAn();
        CPhieuTamTinhHoaDon ptt = new CPhieuTamTinhHoaDon();

        public FBan()
        {
            InitializeComponent();
            loadsodoban();
        }

        public void loadsodoban()
        {
            SoDoBan.Controls.Clear();
            List<BanAn> ListBan = cban.GetBanAn();
            FDatMon n = new FDatMon();

            foreach (BanAn item in ListBan)
            {


                Button btn = new Button() { Width = 100, Height = 100 };
                btn.Text = item.Ten + Environment.NewLine + item.TinhTrang;
                btn.Tag = item;
                btn.Click += Btn_Click;
                switch (item.TinhTrang)
                {
                    case "Trống":
                        btn.BackColor = Color.LightPink;
                        break;
                    case "Có Người":
                        btn.BackColor = Color.LightSkyBlue;

                        break;
                    default:
                        btn.BackColor = Color.LightYellow;
                        break;
                }
                SoDoBan.Controls.Add(btn);
            }



        }

        public class LuuIDTable
        {
            static public int IDtablebam;
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as BanAn).id;
            LuuIDTable.IDtablebam = tableID;
            FDatMon form = new FDatMon();
            int idkha = ptt.GetUncheckBillKhach(tableID);
            if (idkha == -1)
            {
                FNhapKhachHang fkh = new FNhapKhachHang();
                fkh.Show();
            }
            else
            {
                form.Show();
            }
            form.LoadGiaMon();
            form.GetTenKhachHang();
            this.Hide();

        }


        private void SoDoBan_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        

        

        private void FBan_Load(object sender, EventArgs e)
        {
            if (Cons.LoginTaiKhoan.LoaiTaiKhoan == "Quản lí")
            {
                thôngTinCáNhânToolStripMenuItem.Text = "Quản lí :" + Control.Cons.LoginTaiKhoan.UserName;
            }
            else
            {
                thôngTinCáNhânToolStripMenuItem.Text = "Nhân viên :" + Cons.LoginTaiKhoan.UserName;
                adminToolStripMenuItem.Enabled = false;
                thốngKêToolStripMenuItem.Enabled = false;
            }
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLy f = new QuanLy();
            f.ShowDialog();
            this.Show();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FThongKe f = new FThongKe();
            /*this.Hide();*/
            f.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangNhap f = new DangNhap();

            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void ttKhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FKhach f = new FKhach();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
    }

