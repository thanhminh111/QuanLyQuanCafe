using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class ThanhToanChiTietDAO
    {
        private static ThanhToanChiTietDAO instance;

        public static ThanhToanChiTietDAO Instance 
        {
            get { if(instance == null) instance = new ThanhToanChiTietDAO(); return instance; }
            private set => instance = value;
        }

        private ThanhToanChiTietDAO() { }

        public void DeleteTTCTByDrink( string MaMon)
        {
            DataProvider.Instance.ExcuteQuery("delete THANHTOANCHITIET where MaMon = " + MaMon);
        }

        public void DeleteTTCTByHoaDon(string MaHD)
        {
            DataProvider.Instance.ExcuteQuery("delete THANHTOANCHITIET where MaHD = " + MaHD);
        }
    }
}
