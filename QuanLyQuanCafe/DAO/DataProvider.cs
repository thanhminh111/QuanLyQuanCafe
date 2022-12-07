using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class DataProvider
    {
        //Singleton để thể hiện 1 cái gì đó duy nhất dùng để quản lý quyền truy cập tốt hơn.

        private static DataProvider instance; //ctrl+R+E - nhấp vào chính biến cần đóng gói và đóng gói bằng phím tắt
        public static DataProvider Instance 
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; } // thêm private để chỉ cho những người đứng trong class mới có thể thay đổi, những người đứng phía ngoài chỉ được phép xem dữ liệu
        }

        private DataProvider() { }

        private string connectionSTR = "Data Source=DESKTOP-JJ53EQV;Initial Catalog=QuanLyQuanCF;Integrated Security=True";



        /*Hàm này để in ra list hoặc string*/
        
        public DataTable ExcuteQuery(string query, object[] parameter = null)
        {

            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            { 
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                    
                if (parameter != null)
                {
                    string[] listPata = query.Split(' ');
                    int i = 0;
                    foreach(string item in listPata)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }


                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }

        /*Hàm này để in ra số lượng dòng được update,insert hay delete thành công*/
        //output: số trường dữ liệu thỏa mãn
        public int ExcuteNonQuery(string query, object[] parameter = null)
        {

            int data = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPata = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPata)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();

                connection.Close();
            }

            return data;

        }


        /*Hàm này để in ra tổng số lượng count* */
        public object ExcuteScalar(string query, object[] parameter = null)
        {

            object data = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPata = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPata)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();

                connection.Close();
            }

            return data;

        }
    }
}
