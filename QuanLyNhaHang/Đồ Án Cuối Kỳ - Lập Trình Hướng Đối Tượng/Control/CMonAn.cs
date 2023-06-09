using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Đồ_Án_Cuối_Kỳ___Lập_Trình_Hướng_Đối_Tượng.Control
{
    internal class CMonAn
    {
        QuanLyNhaHangEntities6 db = CutilDB.qlnh;

        public List<MonAn> GetMonAn(int id)
        {
            
            return db.MonAn.Where(t => t.idDSMonAn == id).ToList();

          
        }
        public List<MonAn> findAll()
        {
            var rst = from s in db.MonAn select s;
            return rst.ToList();
        }
        public MonAn find(string mamonan)
        {
            return db.MonAn.Find(long.Parse(mamonan));
        }
        public void add(MonAn s)
        {

            db.MonAn.Add(s);
            /*db.SINHVIENs.Remove(s);*/
            db.SaveChanges(); //luu thay doi
        }
        public void delete(MonAn s)
        {

            try
            {
                db.MonAn.Remove(s);
                db.SaveChanges();
            }
            catch
            {

            }

        }
        ////db.SINHVIENs.AddOrUpdate(s); //cap nhat
        public void update(MonAn s)
        {
            db.MonAn.AddOrUpdate(s);
            db.SaveChanges();
        }
        public List<MonAn> findMA(string dieukien)
        {
            return db.MonAn.Where(t => (t.ten) == dieukien).ToList();
        }
        public List<MonAn> GetGia(double gia)
        {
            return db.MonAn.Where(t => t.gia == gia).ToList();
        }



    }
}
