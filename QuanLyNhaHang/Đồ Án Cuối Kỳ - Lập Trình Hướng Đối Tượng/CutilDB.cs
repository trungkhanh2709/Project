using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Đồ_Án_Cuối_Kỳ___Lập_Trình_Hướng_Đối_Tượng
{
    internal class CutilDB
    { 

         public static QuanLyNhaHangEntities6 qlnh = new QuanLyNhaHangEntities6();

    static CutilDB()
    {
        if (qlnh == null)
                qlnh = new QuanLyNhaHangEntities6();
    }
}
}
