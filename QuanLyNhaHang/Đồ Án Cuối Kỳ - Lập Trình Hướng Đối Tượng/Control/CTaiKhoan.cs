using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Đồ_Án_Cuối_Kỳ___Lập_Trình_Hướng_Đối_Tượng.Control
{
    internal class CTaiKhoan
    {
        QuanLyNhaHangEntities6 db = CutilDB.qlnh;

        public List<TaiKhoan> findAll()
        {
            var tk = from s in db.TaiKhoan select s;
            return tk.ToList();
        }
        public TaiKhoan find(string matk)
        {
            return (db.TaiKhoan.Find(long.Parse(matk)));
        }

        public void add(TaiKhoan s)
        {
            db.TaiKhoan.Add(s);
            /*db.NhanVien.Remove(s);*/ //xoa
            db.SaveChanges(); //luu thay doi 
        }
        public void delete(TaiKhoan s)
        {
            try
            {
                db.TaiKhoan.Remove(s);

                db.SaveChanges();
            }
            catch
            {
                /* MessageBox.Show("Khong the xoa duoc nhan vien nay :( !", "VUI LONG THU LAI", MessageBoxButtons.OK, MessageBoxIcon.Error);*/
            }
        }
        public void update(TaiKhoan s)
        {
            db.TaiKhoan.AddOrUpdate(s);
            db.SaveChanges();
        }

        public List<TaiKhoan> findTK(string dieukien)
        {
            return db.TaiKhoan.Where(t => t.UserName == dieukien).ToList();
        }

    }
}
