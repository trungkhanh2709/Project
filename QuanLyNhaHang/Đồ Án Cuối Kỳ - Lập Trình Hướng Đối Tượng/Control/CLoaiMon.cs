using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Đồ_Án_Cuối_Kỳ___Lập_Trình_Hướng_Đối_Tượng.Control
{
    internal class CLoaiMon
    {
        QuanLyNhaHangEntities6 db = CutilDB.qlnh;

        public List<DanhSachMonAn> GetLoaiMon()
        {
            var dsloaimon = from t in db.DanhSachMonAn select t;
            return dsloaimon.ToList();
        }
    }
}
