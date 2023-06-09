using Đồ_Án_Cuối_Kỳ___Lập_Trình_Hướng_Đối_Tượng.Control;
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

namespace Đồ_Án_Cuối_Kỳ___Lập_Trình_Hướng_Đối_Tượng.PVIEW
{
    public partial class FThongKe : Form
    {
        CPhieuTamTinhHoaDon crtBill = new CPhieuTamTinhHoaDon();
        QuanLyNhaHangEntities6 db = new QuanLyNhaHangEntities6();
        public int pageNumb = 0;
        public FThongKe()
        {
            InitializeComponent();
            loadBillngay();
           /* totalPrice();*/
        }
        void loadBill()
        {

            var rs = from tm in db.PhieuTamTinhHoaDon
                     from ma in db.MonAn
                     from ct in db.ChiTietHoaDon
                     from ba in db.BanAn
                     where ct.idMonAn.Equals(ma.id) && ct.idBill == tm.id && tm.idBanAn == ba.id 
                     select new
                     {
                         TenBan = ba.Ten,
                         ThanhTien = (float)ct.soluong * (float)ma.gia,
                         NgayVao = tm.giovao,
                         NgayRa = tm.giora,
                     };
            dtgvBill.DataSource = rs.ToList();

            /*string[] arrListStr;
            int bID = 0;
            string saveba = "";
            foreach (var item in rs)
            {
                arrListStr = item.ToString().Replace("{", "").Replace("}", "").Split(',');
                if ((arrListStr[0].Remove(0, 8)) != saveba)
                {
                    bID = totalBill(arrListStr[0].Remove(0, 8));
                    decimal newprice = Convert.ToDecimal(bID);
                    dtgvBill.Rows.Add(arrListStr[0].Remove(0, 8), newprice, arrListStr[2].Remove(0, 11), arrListStr[3].Remove(0, 12));
                }
                saveba = arrListStr[0].Remove(0, 8);
            }*/
        }
        void loadBillngay()
        {

            var rs = from tm in db.PhieuTamTinhHoaDon
                     from ma in db.MonAn
                     from ct in db.ChiTietHoaDon
                     from ba in db.BanAn
                     where ct.idMonAn.Equals(ma.id) && ct.idBill == tm.id && tm.idBanAn == ba.id && tm.giovao == DateTime.Today
                     select new
                     {
                         TenBan = ba.Ten,
                         ThanhTien = (float)ct.soluong * (float)ma.gia,
                         NgayVao = tm.giovao,
                         NgayRa = tm.giora,
                     };
            dtgvBill.DataSource = rs.ToList();

            /*string[] arrListStr;
            int bID = 0;
            string saveba = "";
            foreach (var item in rs)
            {
                arrListStr = item.ToString().Replace("{", "").Replace("}", "").Split(',');
                if ((arrListStr[0].Remove(0, 8)) != saveba)
                {
                    bID = totalBill(arrListStr[0].Remove(0, 8));
                    decimal newprice = Convert.ToDecimal(bID);
                    dtgvBill.Rows.Add(arrListStr[0].Remove(0, 8), newprice, arrListStr[2].Remove(0, 11), arrListStr[3].Remove(0, 12));
                }
                saveba = arrListStr[0].Remove(0, 8);
            }*/
        }
        static int totalBill(string ten)
        {
            QuanLyNhaHangEntities6 db = new QuanLyNhaHangEntities6();
            var rs = from tm in db.PhieuTamTinhHoaDon
                     from ma in db.MonAn
                     from ct in db.ChiTietHoaDon
                     from ba in db.BanAn
                     where ct.idMonAn.Equals(ma.id) && ct.idBill == tm.id && tm.idBanAn == ba.id
                     select new
                     {
                         Name = ba.Ten,
                         Total = (float)ct.soluong * (float)ma.gia,
                     };
            string[] arrListStr;
            string a1 = "";
            int a2 = 0;
            int count = 0;
            foreach (var item in rs)
            {
                arrListStr = item.ToString().Replace("{", "").Replace("}", "").Split(',');
                a1 = arrListStr[0].Remove(0, 8);
                a2 = Int32.Parse(arrListStr[1].Remove(0, 8));
                if (a1 == ten)
                {
                    count += a2;
                    
                }
            }
            return count;
        }
        void getBillWithFrToDate(DateTime dtFrom, DateTime dtTo)
        {
            var rs = from tm in db.PhieuTamTinhHoaDon
                     from ma in db.MonAn
                     from ct in db.ChiTietHoaDon
                     from ba in db.BanAn
                     where ct.idMonAn.Equals(ma.id) && ct.idBill == tm.id
                           && ba.id == tm.idBanAn && tm.giora >= dtFrom && tm.giora <= dtTo
                     select new
                     {
                         Name = ba.Ten,
                         Total = (float)ct.soluong * (float)ma.gia,
                         Checkin = tm.giovao,
                         Checkout = tm.giora,

                     };
            if (rs.Count() == 0)
            {
                MessageBox.Show("Ngày này không có bill. Vui lòng nhập lại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loadBill();
                return;
            }
            dtgvBill.DataSource = rs.ToList();
            /*string[] arrListStr;
            int bID = 0;
            string saveId = "";
            if (rs.Count() == 0)
            {
                MessageBox.Show("Ngày này không có bill. Vui lòng nhập lại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loadBill();
                return;
            }
            foreach (var item in rs)
            {
                arrListStr = item.ToString().Replace("{", "").Replace("}", "").Split(',');
                if (arrListStr[0].Remove(0, 8) != saveId)
                {
                    bID = totalBill(arrListStr[0].Remove(0, 8));
                    dtgvBill.Rows.Add(arrListStr[0].Remove(0, 8),
                                      bID, arrListStr[2].Remove(0, 11), arrListStr[3].Remove(0, 12));
                }
                saveId = arrListStr[0].Remove(0, 8);
            }*/
        }
        void totalPrice()
        {
            double tong = 0;
            for (int i = 0; i < dtgvBill.Rows.Count - 1; i++)
            {
                tong += double.Parse(dtgvBill.Rows[i].Cells[1].Value.ToString());
            }
            string formatted = string.Format(CultureInfo.InvariantCulture, "{0:N0}", tong);
            txtbThanhTien.Text = formatted.ToString();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            string dtFromDate = dtTuNgay.Text;
            DateTime dtFrom = DateTime.Parse(dtFromDate);
            string dtToDate = dtDenNgay.Text;
            DateTime dtTo = DateTime.Parse(dtToDate);
            getBillWithFrToDate(dtFrom, dtTo);
            totalPrice();
        }

        //Excel
        private void ExportExcel(string path)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < dtgvBill.Columns.Count; i++)
            {
                application.Cells[1, i + 1] = dtgvBill.Columns[i].HeaderText;
            }
            for (int i = 0; i < dtgvBill.Rows.Count; i++)
            {
                for (int j = 0; j < dtgvBill.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1] = dtgvBill.Rows[i].Cells[j].Value;
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

        private void btnExit_Click(object sender, EventArgs e)
        {

            FBan b = new FBan();
            this.Hide();                     
            b.ShowDialog();
            this.Close(); 
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadBill();
        }
    }
}
