using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class StaffDAO
    {
        private static StaffDAO instance;
        private StaffDAO() { }

        public static StaffDAO Instance
        {
            get { if(instance == null) instance= new StaffDAO(); return instance; }
            private set => instance = value; 
        }

        public bool InsertStaff(string TenNV, string SDT, string LoaiTK)
        {
            string query = string.Format("insert into NHANVIEN values(dbo.fMaNVNew(), N'{0}', null, '{1}', '{2}', 0)", TenNV, SDT, LoaiTK);

            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public bool EditStaff(string TenNV, string SDT, string LoaiNV, string MaNV)
        {
            string query = string.Format("update NHANVIEN set TENNV = N'{0}', SDT='{1}', LoaiNV ='{2}' where MaNV = '{3}'", TenNV, SDT, LoaiNV, MaNV);

            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        //delete NHANVIEN where MaNV = '0000000013'
        public bool DeleteStaff(string MaNV)
        {
            string query = string.Format("delete NHANVIEN where MaNV = {0}", MaNV);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

    }
}
