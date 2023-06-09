using Đồ_Án_Cuối_Kỳ___Lập_Trình_Hướng_Đối_Tượng.Control;
using Đồ_Án_Cuối_Kỳ___Lập_Trình_Hướng_Đối_Tượng.PVIEW;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;

namespace Đồ_Án_Cuối_Kỳ___Lập_Trình_Hướng_Đối_Tượng
{
    public partial class FDatMon : Form
    {
        CLoaiMon dslm = new CLoaiMon();
        CMonAn dsma = new CMonAn();
        List<ChiTietHoaDon> listchitiethoadon = new List<ChiTietHoaDon>();
        CBanAn ba = new CBanAn();
        CChiTietHoaDon cthd = new CChiTietHoaDon();
        CKhachHang kh = new CKhachHang();
        CPhieuTamTinhHoaDon ptthd = new CPhieuTamTinhHoaDon();
        public FDatMon()
        {
            InitializeComponent();
            LoadCMBLoaiMon();
            LoadGiaMon();
            LoadSwithTable();
            loadDSMonAn();
            loadtinhtrangban();
            LoadTenBan();
            GetTenKhachHang();
        }

        void LoadCMBLoaiMon()
        {
            List<DanhSachMonAn> dsKhoa = dslm.GetLoaiMon();
            cbloaimon.DataSource = dsKhoa;
            cbloaimon.DisplayMember = "Ten";
        }

        
        void LoadFoodbyCategoryID(int id)
        {
            doanhsachmonan.Controls.Clear();
            List<MonAn> ListMonAn = dsma.GetMonAn(id);
            foreach (MonAn item in ListMonAn)
            {
                Button btn = new Button() { Width = 100, Height = 100 };
                btn.Text = item.ten + Environment.NewLine;
                btn.Click += Btn_Click;
                btn.Tag = item;
                btn.BackColor = Color.LightPink;
                doanhsachmonan.Controls.Add(btn);
            }
        }

        public void loadDSMonAn()
        {
            using (QuanLyNhaHangEntities6 dbmon = new QuanLyNhaHangEntities6())
            {
                int idt = FBan.LuuIDTable.IDtablebam;
                var rs = from tm in dbmon.PhieuTamTinhHoaDon
                         from ma in dbmon.MonAn
                         from ct in dbmon.ChiTietHoaDon
                         where ct.idMonAn.Equals(ma.id) && ct.idBill == tm.id && tm.idBanAn == +idt && ct.idMonAn == ma.id && tm.status == 0
                         select new
                         {

                             Ten = ma.ten,
                             SoLuong = ct.soluong,
                             Total = ma.gia * ct.soluong
                         };
                dtgvMon.DataSource = rs.ToList();
            }

        }
        private void Btn_Click(object sender, EventArgs e)
        {
            int foodid = ((sender as Button).Tag as MonAn).id;
            luuidfood.layidfood = foodid;
        }
        public void GetTenKhachHang()
        {
            using (QuanLyNhaHangEntities6 dbmon = new QuanLyNhaHangEntities6())
            {
                int idt = FBan.LuuIDTable.IDtablebam;

                var ri = from tm in dbmon.PhieuTamTinhHoaDon
                         from ct in dbmon.KhachHang
                         where tm.idBanAn == +idt && ct.id == tm.idKhach && tm.status == 0
                         select ct.tenkhachhang;
                if (ri.Count() > 0)
                {
                    tenkhach.Text = (from tm in dbmon.PhieuTamTinhHoaDon
                                     from ct in dbmon.KhachHang
                                     where tm.idBanAn == +idt && ct.id == tm.idKhach && tm.status == 0
                                     select ct.tenkhachhang).First();

                }
                else { }


            }
        }
        public class luuidfood
        {
            static public int layidfood;
        }
        public void LoadGiaMon()
        {
            QuanLyNhaHangEntities6 dbmon = new QuanLyNhaHangEntities6();
            var rs = from tm in dbmon.PhieuTamTinhHoaDon
                     from ma in dbmon.MonAn
                     from ct in dbmon.ChiTietHoaDon
                     where ct.idMonAn.Equals(ma.id) && ct.idBill == tm.id
                     select new
                     {
                         Price = ma.gia,
                         Count = ct.soluong,
                         Total = (float)ct.soluong * (float)ma.gia,
                     };
            double tong = 0;
            for (int i = 0; i < dtgvMon.Rows.Count; i++)
            {
                tong += double.Parse(dtgvMon.Rows[i].Cells[2].Value.ToString());
            }
            string formatted = string.Format(CultureInfo.InvariantCulture, "{0:N0}", tong);
            txtThanhTien.Text = formatted.ToString();
        }

        void LoadSwithTable()
        {
            List<BanAn> listTf = ba.GetTableTrong();
            cbSwithTable.DataSource = listTf;
            cbSwithTable.DisplayMember = "Ten";
        }
        



        public void UpdateCount(int idB, int idFood, int Count)
        {


            using (QuanLyNhaHangEntities6 m = new QuanLyNhaHangEntities6())
            {
                ChiTietHoaDon chitiet = m.ChiTietHoaDon.Where(x => (x.idBill == idB && x.idMonAn == idFood)).ToList()[0];
                chitiet.soluong += +Count;
                cthd.update(chitiet);

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void an_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void CheckOut(int id)
        {
            int idtable = FBan.LuuIDTable.IDtablebam;

            int idbill = ptthd.GetUncheckBill(idtable);

            PhieuTamTinhHoaDon s = ptthd.find(idbill);
            //thay doi thong tin nhung ko thay doi maSV
            s.status = 1;
            s.giora = DateTime.Now;

            ptthd.update(s);


        }
     
        

        

        
        void LoadTenBan()
        {
            using (QuanLyNhaHangEntities6 dbmon = new QuanLyNhaHangEntities6())
            {
                int idt = FBan.LuuIDTable.IDtablebam;
                var m = from i in dbmon.BanAn where i.id == idt select i.id;


                if (m.Count() > 0)
                {
                    ltenban.Text = (from ba in dbmon.BanAn where ba.id == idt select ba.Ten).First();

                }
                else { }

            }
        }
        private void thanhtoan_Click_1(object sender, EventArgs e)
        {

        }

        public void loadtinhtrangban()
        {


            using (QuanLyNhaHangEntities6 db = new QuanLyNhaHangEntities6())
            {
                /*int idta = FBan.LuuIDTable.IDtablebam;
                BanAn s = ba.find(idta);
                if (s != null)
                {
                    dat.Checked = (s.TinhTrang == "Đã Đặt" ? true : false);
                    dang.Checked = (s.TinhTrang == "Có Người" ? true : false);
                    trong.Checked = (s.TinhTrang == "Trống" ? true : false);


                };*/

            }
        }

        private void themmon_Click_1(object sender, EventArgs e)
        {
            int idtable = FBan.LuuIDTable.IDtablebam;
            int idbill = ptthd.GetUncheckBill(idtable);
            int idk = kh.GetMaxIDKhachHang();
            ChiTietHoaDon ct = new ChiTietHoaDon
            {
                idMonAn = FDatMon.luuidfood.layidfood,
                soluong = (int)numericUpDown1.Value,
                idBill = idbill
            };

            int idm = ct.idMonAn;
            int so = ct.soluong;
            if (idbill == -1)
            {
                ptthd.InsertPhieuTamTinhHoaDon(idtable, idk);
                cthd.InsertChiTietHoaDon(cthd.GetMaxID(), idm, so);
                ba.CheckInStatus(idtable);
                loadtinhtrangban();
            }
            else
            {
                if (cthd.CheckidFoodCount(idbill, idm) > 0)
                {
                    UpdateCount(idbill, idm, so);
                }
                else
                {
                    cthd.InsertChiTietHoaDon(idbill, idm, so);

                }
            }
            loadDSMonAn();
            LoadGiaMon();
            GetTenKhachHang();
/*
            dat.Enabled = false;
            trong.Enabled = true;
            dang.Enabled = true;*/



        }

        private void cbloaimon_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            DanhSachMonAn slect = cb.SelectedItem as DanhSachMonAn;
            id = slect.id;
            LoadFoodbyCategoryID(id);
        }

        private void FDatMon_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            FBan j = new FBan();
            j.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int OdlId = FBan.LuuIDTable.IDtablebam;
            int NewId = (cbSwithTable.SelectedItem as BanAn).id;

            ba.UpdateCheckOut(OdlId);
            ptthd.chuyen(NewId, OdlId);
            ba.CheckInStatus(NewId);
            FBan f = new FBan();
            txtThanhTien.Text = 0.ToString();
            loadDSMonAn();
            LoadSwithTable();
        }

        //Excel
        private void ExportExcel(string path)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < dtgvMon.Columns.Count; i++)
            {
                application.Cells[1, i + 1] = dtgvMon.Columns[i].HeaderText;
            }
            for (int i = 0; i < dtgvMon.Rows.Count; i++)
            {
                for (int j = 0; j < dtgvMon.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1] = dtgvMon.Rows[i].Cells[j].Value;
                }
            }
            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveCopyAs(path);
            application.ActiveWorkbook.Saved = true;
        }
        private void thanhtoan_Click(object sender, EventArgs e)
        {
            int idt = FBan.LuuIDTable.IDtablebam;
            int idbi = ptthd.GetUncheckBill(idt);
            //int idTable = BillDAO.Instance.GetUncheckBill(table.);
            
            if (idbi != -1)
            {
                if (MessageBox.Show("Bạn muốn thanh toán ? ", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    ba.UpdateCheckOut(idt);
                  
                        try
                        {
                          
                            MessageBox.Show("Thanh toán thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Không thành công!\n" + ex.Message);
                        }
                    
                    CheckOut(idbi);
                    LoadGiaMon();
                    loadDSMonAn();
                    txtThanhTien.Text = 0.ToString();
                    GetTenKhachHang();
                }
                
                FBan fb = new FBan();
                /*trong.Checked = true;
                dat.Enabled = false;
                dang.Enabled = false;*/
                GetTenKhachHang();
                this.Close();
                fb.Show();

                
            }
        }

        private void dat_CheckedChanged(object sender, EventArgs e)
        {
            /*if (dat.Checked == true)
            {
                BanAn k = ba.find(FBan.LuuIDTable.IDtablebam);
                k.TinhTrang = "Đã Đặt";
                ba.update(k);
                trong.Enabled = false;
                dang.Enabled = false;
                
                FBan g = new FBan();
                g.Show();
                this.Hide();
            }*/
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}


