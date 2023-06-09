using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Đồ_Án_Cuối_Kỳ___Lập_Trình_Hướng_Đối_Tượng.Control
{
    class CKhachHang
    {
        QuanLyNhaHangEntities6 db = CutilDB.qlnh;
        public void add(KhachHang s)
        {
            db.KhachHang.Add(s);
            db.SaveChanges();
        }
        public int GetMaxIDKhachHang()
        {
            var o = db.KhachHang.OrderByDescending(u => u.id).FirstOrDefault();
            return o.id;
        }

        public int GetUncheckBillKhach(int idtable)
        {

            var rs = from tm in db.PhieuTamTinhHoaDon
                     where tm.idBanAn == +idtable && tm.status == 0
                     select new
                     {
                         Id = tm.id,
                         idkhach = tm.idKhach,
                         Giovao = tm.giovao,

                         Giora = tm.giora,
                         iDban = tm.idBanAn,
                         status = tm.status
                     };
            var chuoiso = rs.ToList();
            string[] chuoi;
            string idb = "";
            for (int i = 0; i <= chuoiso.Count; i++)
            {
                if (i == chuoiso.Count - 1)
                {
                    chuoi = chuoiso[i].ToString().Replace("{", "").Replace("}", "").Split(',');
                    idb = chuoi[1].Remove(0, 10);
                }
            }
            int o = 0;
            if (chuoiso.Count > 0)
            {
                o = Int32.Parse(idb);
            }
            else if (idb == "")
            {
                o = -1;

            }
            return o;
        }
        public List<KhachHang> findKH(string dieukien)
        {
            return db.KhachHang.Where(t => t.tenkhachhang == dieukien).ToList();
        }
    }
}
