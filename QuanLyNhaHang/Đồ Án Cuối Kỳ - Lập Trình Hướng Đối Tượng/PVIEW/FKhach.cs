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
    public partial class FKhach : Form
    {
        CKhachHang ctrkh = new CKhachHang();
        List<KhachHang> dskh = new List<KhachHang>();
        CBanAn ctrBA = new CBanAn();
        List<BanAn> dsBA = new List<BanAn>();
        public FKhach()
        {
            InitializeComponent();
            ShowKhach();
        }
        void ShowKhach()
        {
            using (QuanLyNhaHangEntities6 db = new QuanLyNhaHangEntities6())
            {

                var rs = from tm in db.PhieuTamTinhHoaDon
                         from b in db.BanAn
                         from k in db.KhachHang

                         where tm.idBanAn == b.id && tm.idKhach == k.id && (b.TinhTrang == "Có người" || b.TinhTrang == "Đã đặt ")
                         select new
                         {


                             
                             MaKhach = k.id,
                             TenKhach = k.tenkhachhang,
                             SoDienThoai = k.sdt,
                             GioiTinh = k.gioitinh,
                             TenBan = b.Ten,

                         };
                dtgvDSKhachHang.DataSource = rs.ToList();
            }
        }

        private void FKhach_Load(object sender, EventArgs e)
        {

        }

        void timKiemKH()
        {
            var lst = ctrkh.findKH(txtTimKH.Text);
            var rst = from s in lst
                      select new { s.id, s.tenkhachhang, s.sdt, s.gioitinh };
            
            dtgvDSKhachHang.DataSource = rst.ToList();
            dtgvDSKhachHang.Refresh();

        }

        
        private void btnTimKH_Click(object sender, EventArgs e)
        {
            timKiemKH();
        }
    }
}
