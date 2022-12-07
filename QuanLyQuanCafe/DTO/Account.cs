using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class Account
    {
        public Account(string MaTk, string MaNV, string TenDangNhap, string TK_Status, string MatKhau = null) //pass null vì nó lưu hảnh nội bộ
        {
            this.MaTk = MaTk;
            this.MaNV = MaNV;
            this.TenDangNhap = TenDangNhap;
            this.MatKhau = MatKhau;
            this.TK_Status = TK_Status;
        }  
        
        public Account (DataRow row)
        {
            this.MaTk = row["MaTk"].ToString();
            this.MaNV = row["MaNV"].ToString();
            this.TenDangNhap = row["TenDangNhap"].ToString();
            this.MatKhau = row["MatKhau"].ToString();
            this.TK_Status = row["TK_Status"].ToString();
        }



        private string MaTk;
        private string TenDangNhap;
        private string MatKhau;
        private string TK_Status;
        private string MaNV;

        public string MaTk1 { get => MaTk; set => MaTk = value; }
        public string MaNV1 { get => MaNV; set => MaNV = value; }
        public string TenDangNhap1 { get => TenDangNhap; set => TenDangNhap = value; }
        public string MatKhau1 { get => MatKhau; set => MatKhau = value; }
        public string TK_Status1 { get => TK_Status; set => TK_Status = value; }
    }
}
