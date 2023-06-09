using Đồ_Án_Cuối_Kỳ___Lập_Trình_Hướng_Đối_Tượng.PVIEW;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Đồ_Án_Cuối_Kỳ___Lập_Trình_Hướng_Đối_Tượng.Control
{
    internal class CBanAn
    {
        QuanLyNhaHangEntities6 db = CutilDB.qlnh;
        BanAn banan = new BanAn();
        CPhieuTamTinhHoaDon ptthd = new CPhieuTamTinhHoaDon();
        public List<BanAn> GetBanAn()
        {
            var dsBanan = from t in db.BanAn select t;
            return dsBanan.ToList();
        }
        public List<BanAn> GetTableTrong()
        {
            var dsBanan = from t in db.BanAn
                          where (t.TinhTrang == "Trống")
                          select t;
            return dsBanan.ToList();
        }

        public BanAn find(int idban)
        {
            return db.BanAn.Find(idban);
        }


        public List<BanAn> findAll()
        {
            var tk = from s in db.BanAn select s;
            return tk.ToList();
        }
        public BanAn find(string maba)
        {
            return (db.BanAn.Find(long.Parse(maba)));
        }
        public int KiemTraCoKhach(int idtable)
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

        public void add(BanAn s)
        {
            db.BanAn.Add(s);
            /*db.NhanVien.Remove(s);*/ //xoa
            db.SaveChanges(); //luu thay doi 
        }
        public void CheckInStatus(int idb)
        {

            BanAn k = find(idb);
            k.TinhTrang = "Có Người";
            update(k);


        }
        public void delete(BanAn s)
        {
            try
            {
                db.BanAn.Remove(s);

                db.SaveChanges();
            }
            catch
            {
                /* MessageBox.Show("Khong the xoa duoc nhan vien nay :( !", "VUI LONG THU LAI", MessageBoxButtons.OK, MessageBoxIcon.Error);*/
            }
        }
        public void update(BanAn s)
        {
            db.BanAn.AddOrUpdate(s);
            db.SaveChanges();
        }

        public List<BanAn> findBA(string dieukien)
        {
            return db.BanAn.Where(t => t.Ten == dieukien).ToList();
        }
        public void UpdateCheckOut(int idb)
        {

            BanAn k = find(idb);
            k.TinhTrang = "Trống";
            update(k);


        }

    }
}
