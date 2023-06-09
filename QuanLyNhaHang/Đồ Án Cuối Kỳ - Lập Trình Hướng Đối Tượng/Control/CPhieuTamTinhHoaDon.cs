using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Đồ_Án_Cuối_Kỳ___Lập_Trình_Hướng_Đối_Tượng.Control
{
    internal class CPhieuTamTinhHoaDon
    {
        QuanLyNhaHangEntities6 db = CutilDB.qlnh;
        public void InsertPhieuTamTinhHoaDon(int idb, int idk)
        {
            PhieuTamTinhHoaDon phieuTamTinh = new PhieuTamTinhHoaDon()
            {
                giovao = DateTime.Now,

                idBanAn = idb,
                idKhach = idk,
                status = 0
            };
            add(phieuTamTinh);
        }
        public int GetUncheckBill(int idtable)
        {

            var rs = from tm in db.PhieuTamTinhHoaDon
                     where tm.idBanAn == +idtable && tm.status == 0
                     select new
                     {
                         Id = tm.id,
                         Giovao = tm.giovao,
                         Giora = tm.giora,
                         iDban = tm.idBanAn,
                         idKhach = tm.idKhach,
                         status = tm.status
                     };
            var chuoiso = rs.ToList();
            string[] chuoi;
            string idb = "";
            for (int i = 0; i <= chuoiso.Count - 1; i++)
            {
                if (i == chuoiso.Count - 1)
                {
                    chuoi = chuoiso[i].ToString().Replace("{", "").Replace("}", "").Split(',');
                    idb = chuoi[0].Remove(0, 6);
                }
            }
            if (chuoiso.Count > 0)
            {
                return Int32.Parse(idb);
            }
            else
            {
                return -1;


            }
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




        public void chuyen(int idNew, int id)
        {
            using (QuanLyNhaHangEntities6 m = new QuanLyNhaHangEntities6())
            {
                PhieuTamTinhHoaDon chitiet = m.PhieuTamTinhHoaDon.Where(x => (x.idBanAn == id && x.status == 0)).ToList()[0];
                chitiet.idBanAn = idNew;
                update(chitiet);

            }
        }
        public void add(PhieuTamTinhHoaDon s)
        {
            db.PhieuTamTinhHoaDon.Add(s);
            db.SaveChanges(); //luu thay doi 
        }
        public PhieuTamTinhHoaDon find(int idbi)
        {
            return db.PhieuTamTinhHoaDon.Find(idbi);
        }
        public void update(PhieuTamTinhHoaDon s)
        {
            db.PhieuTamTinhHoaDon.AddOrUpdate(s);
            db.SaveChanges();
        }

    }
}
