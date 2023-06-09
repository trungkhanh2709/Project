using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Đồ_Án_Cuối_Kỳ___Lập_Trình_Hướng_Đối_Tượng.Control
{
    internal class CNhanVien
    {
        QuanLyNhaHangEntities6 db = CutilDB.qlnh;

        public List<NhanVien> findALL()
        {
            var rst = from s in db.NhanVien select s;
            return rst.ToList();
        }
        public NhanVien find(string manv)
        {
            return db.NhanVien.Find(long.Parse(manv));
        }

        public void add(NhanVien s)
        {
            db.NhanVien.Add(s);
            /*db.NhanVien.Remove(s);*/ //xoa
            db.SaveChanges(); //luu thay doi 
        }

        public void delete(NhanVien s)
        {
            try
            {
                db.NhanVien.Remove(s);

                db.SaveChanges();
            }
            catch
            {
                /* MessageBox.Show("Khong the xoa duoc nhan vien nay :( !", "VUI LONG THU LAI", MessageBoxButtons.OK, MessageBoxIcon.Error);*/
            }
        }

        public void update(NhanVien s)
        {
            db.NhanVien.AddOrUpdate(s);
            db.SaveChanges();
        }

        public List<NhanVien> findNV(string dieukien)
        {
            /*return db.NhanVien.Where(t => t.id == dieukien
                                         || t.tennhanvien.Contains(dieukien)).ToList();*/
            return db.NhanVien.Where(t => t.tennhanvien == dieukien).ToList();


        }

    }
}
