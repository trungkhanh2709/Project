using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Đồ_Án_Cuối_Kỳ___Lập_Trình_Hướng_Đối_Tượng.Control
{
    internal class CDanhMucMonAn
    {
        QuanLyNhaHangEntities6 db = CutilDB.qlnh;
        public List<DanhSachMonAn> findAll()
        {
            var rst = from s in db.DanhSachMonAn select s;
            return rst.ToList();
        }
        public DanhSachMonAn find(string mamonan)
        {
            return db.DanhSachMonAn.Find(long.Parse(mamonan));
        }
        public void add(DanhSachMonAn s)
        {
            db.DanhSachMonAn.Add(s);
            /*db.SINHVIENs.Remove(s);*/
            db.SaveChanges(); //luu thay doi
        }
        public void delete(DanhSachMonAn s)
        {

            try
            {
                db.DanhSachMonAn .Remove(s);
                db.SaveChanges();
            }
            catch
            {

            }

        }
        ////db.SINHVIENs.AddOrUpdate(s); //cap nhat
        public void update(DanhSachMonAn s)
        {
            db.DanhSachMonAn.AddOrUpdate(s);
            db.SaveChanges();
        }
        public List<DanhSachMonAn> findDMMA(string dieukien)
        {
            return db.DanhSachMonAn.Where(t => (t.ten) == dieukien).ToList();
        }


    }
}
