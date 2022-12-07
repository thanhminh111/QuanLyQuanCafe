using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class ThanhToanDAO
    {
        private static ThanhToanDAO instance;

        public static ThanhToanDAO Instance 
        {
            get { if(instance == null) instance = new ThanhToanDAO(); return instance; }
            private set => instance = value; 
        }

        public void DeleteTTbyTable(string MaHD)
        {
            DataProvider.Instance.ExcuteQuery("Delete THANHTOAN where MaHD = " + MaHD);
        }
       
    }
}
