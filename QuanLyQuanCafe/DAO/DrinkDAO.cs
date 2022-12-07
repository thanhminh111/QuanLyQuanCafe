using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace QuanLyQuanCafe.DAO
{
    public class DrinkDAO
    {
        private static DrinkDAO instance;

        public static DrinkDAO Instance 
        {
            get { if(instance == null) instance= new DrinkDAO(); return DrinkDAO.instance; } 
            private set => instance = value;
        }
        private DrinkDAO() { }

        public List<MON> SearchMONByName(string TenMon)
        {
            List<MON> listMon = new List<MON>();

            string query = string.Format("select * from MON where TenMon = N'{0}'", TenMon);

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach( DataRow item in data.Rows){
                MON mon = new MON(item);
                listMon.Add(mon);
            }
            return listMon;
        }
        

        public bool InsertDrink( string TenMon, int DonGiaB)
        {
            string query = string.Format("insert into MON values( dbo.fMaMonNew() ,N'{0}',{1}, 0)", TenMon, DonGiaB);

            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateDrink( string TenMon, int DonGiaB, string MaMon)
        {
            string query = string.Format("update MON set TenMon = N'{0}', DonGiaB = {1} where MaMon = '{2}'", TenMon, DonGiaB, MaMon);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteDrink(string MaMon)
        {
            //ThanhToanChiTietDAO.Instance.DeleteTTCTByDrink(MaMon);  // khi xóa trực tiếp, phải xóa từ bảng chi tiết trước
            string query = string.Format("delete Mon where MaMon = {0}", MaMon);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

    }
}
