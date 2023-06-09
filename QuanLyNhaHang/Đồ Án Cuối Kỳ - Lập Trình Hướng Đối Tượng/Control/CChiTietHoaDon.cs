using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;

namespace Đồ_Án_Cuối_Kỳ___Lập_Trình_Hướng_Đối_Tượng.Control
{
    internal class CChiTietHoaDon
    {
        QuanLyNhaHangEntities6 db = CutilDB.qlnh;
        public List<ChiTietHoaDon> findALL()
        {
            var finda = from s in db.ChiTietHoaDon select s;
            return finda.ToList();
        }
        public List<ChiTietHoaDon> findCTHD(int idBill, int idFood)
        {
            return db.ChiTietHoaDon.Where(t => t.idBill == idBill
                                         && t.idMonAn==idFood).ToList();    

        }
        public int CheckidFoodCount(int idBill, int idFood)
        {
            var chiTietHoaDon= findCTHD(idBill, idFood);
            return chiTietHoaDon.Count();

           
        }
      
        public void InsertChiTietHoaDon(int idBill, int idfood, int count)
        {
            ChiTietHoaDon chitiethd = new ChiTietHoaDon
            {
                idBill = idBill,
                idMonAn = idfood,
                soluong = count
            };
             
            add(chitiethd);
        }
        public int GetMaxID()
        {
            var o = db.ChiTietHoaDon.OrderByDescending(u => u.idBill).FirstOrDefault();
            return o.idBill;
        }
        public void add(ChiTietHoaDon s)
        {
            db.ChiTietHoaDon.Add(s);
            /*db.SINHVIEN.Remove(s);*/ //xoa
            db.SaveChanges(); //luu thay doi 
        }
        public ChiTietHoaDon find(int idban)
        {
            return db.ChiTietHoaDon.Find(idban);
        }
        internal void update(ChiTietHoaDon s)
        {

            db.ChiTietHoaDon.AddOrUpdate(s);
            db.SaveChanges();
        }
        /*public List<BanAn> GetBanAn()
        {
            var dsBanan = from t in db.BanAn select t;
            return dsBanan.ToList();
        }*/

    }
}
