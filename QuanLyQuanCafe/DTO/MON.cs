using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class MON
    {
        public MON (string MaMon, string TenMon, int DonGiaB, int Mon_Status)
        {
            this.MaMon = MaMon;
            this.TenMon = TenMon;
            this.DonGiaB= DonGiaB;
            this.Mon_Status = Mon_Status;
        }

        public MON(DataRow row)
        {
            this.MaMon = row["MaMon"].ToString();
            this.TenMon = row["TenMon"].ToString();
            this.DonGiaB = (int)row["DonGiaB"];
            this.Mon_Status = (int)row["Mon_Status"];
        }

        private string MaMon;

        private string TenMon;

        private int DonGiaB;

        private int Mon_Status;

        private MON() { }

        public string MaMon1 { get => MaMon;private set => MaMon = value; }
        public string TenMon1 { get => TenMon; private set => TenMon = value; }
        public int DonGiaB1 { get => DonGiaB; private set => DonGiaB = value; }
        public int Mon_Status1 { get => Mon_Status; private set => Mon_Status = value; }
    }
}
