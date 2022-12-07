using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;
        private TableDAO() { }

        public static TableDAO Instance 
        {
            get { if(instance == null) instance= new TableDAO(); return instance; }
            private set => instance = value;
        }

        public bool InsertTable(string TinhTrang)
        {
            string query = string.Format("insert into BAN values(dbo.fMaBanNew(), N'{0}', 0)", TinhTrang);
            
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateTable(string TinhTrang, string MaBan)
        {
            string query = string.Format("update BAN set TinhTrang = N'{0}' where MaBan = '{1}'", TinhTrang, MaBan);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }


        public bool DeleteTable(string MaBan)
        {
            //ThanhToanChiTietDAO.Instance.DeleteTTCTByHoaDon(MaHD);
            //ThanhToanDAO.Instance.DeleteTTbyTable(MaHD);
            string query = string.Format("delete BAN where MaBan = '{0}')", MaBan);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
       
    }
}
