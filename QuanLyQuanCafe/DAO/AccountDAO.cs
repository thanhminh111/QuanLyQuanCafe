using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set => instance = value;
        }

        private AccountDAO() { }

        public bool Login(string TenDangNhap, string MatKhau)
        {
            //nếu dùng bằng cách nối chuỗi, thì nó k phân biệt viết hoa và viết thường, nhưng trong user name và password thì người ta rất quan tâm đến vấn đề này.
            /*string query = "select * from TaiKhoan where TenDangNhap = N'" + TenDangNhap + "' and MatKhau = '" + MatKhau + "'";
            DataTable result = DataProvider.Instance.ExcuteQuery(query);*/

            // sử dụng proc để tránh được lỗi injection. lưu ý giữa 2 biến ở trong proc cần phải cách đều nhau và k dính với dấu , nào 
            //Nhưng theo cách này cũng chưa phân biệt đâu là chữ hoa và đâu là chữ thường????

            string query = "exec pGetAccount @TenDangNhap , @MatKhau";

            DataTable result = DataProvider.Instance.ExcuteQuery(query, new object[] {TenDangNhap, MatKhau});

            return result.Rows.Count > 0;
        }

        public Account GetAccountByTDN (string TenDangNhap)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("select * from TaiKhoan where TenDangNhap = "+ TenDangNhap  + "'");
            
            foreach(DataRow item in data.Rows)
            {
                return new Account(item);
            }
            return null;
        
        }

        
    }
}
