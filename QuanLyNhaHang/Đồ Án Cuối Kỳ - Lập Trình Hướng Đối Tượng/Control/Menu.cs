using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Đồ_Án_Cuối_Kỳ___Lập_Trình_Hướng_Đối_Tượng.Control
{
    internal class Menu
    {
        QuanLyNhaHangEntities6 db = CutilDB.qlnh;

       /* public List<Menu> GetListMenu(int id)
        {
          *//*  return db.MonAn.Where(t => t.idDSMonAn == id).ToList();*/
            /*string sql = "select f.name, bi.count, f.price, f.price*bi.count as totalprice From BillInfo bi, Bill b, Food f Where bi.idbill = b.id and bi.idFood = f.id and idTable = '" + id + "' and b.status = 0";
            List<Menu> listMenu = new List<Menu>();
            DataTable data = DataProvider.Instance.ExcuteQuery(sql);

            foreach (DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listMenu.Add(menu);
            }

            return listMenu;*//*
        }*/
    }
}
