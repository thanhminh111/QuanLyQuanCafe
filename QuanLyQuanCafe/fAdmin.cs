using QuanLyQuanCafe.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using System.Diagnostics;
using QuanLyQuanCafe.DTO;
using System.Web;

namespace QuanLyQuanCafe
{
    public partial class fAdmin : Form
    {
        BindingSource DrinkList = new BindingSource();
        BindingSource TableList= new BindingSource();
        BindingSource StaffList = new BindingSource();

        
        public fAdmin()
        {

            InitializeComponent();
            Load();

        }

        //txb Tìm
        public List<MON> SearchMONByName(string TenMon)
        {
            List<MON> listMon = DrinkDAO.Instance.SearchMONByName(TenMon);
            return listMon;
        }

        
        void Load()
        {
            dtgvDrink.DataSource = DrinkList;
            dtgvTable.DataSource = TableList;
            dtgvStaff.DataSource = StaffList;

            LoadListStaff();
            LoadListDrink();
            LoadListTable();
            AddDrinkBinding();
            AddTableBinding();
            AddStaffBinding();
        }
        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            string MaMon = txbDrinkMaMon.Text;

            if (DrinkDAO.Instance.DeleteDrink(MaMon))
            {
                MessageBox.Show("Xóa món thành công!");
                LoadListDrink();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa!");
            }
        }
        #region
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tcBill_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tpFood_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbAccount_Click(object sender, EventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtgvAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        #endregion

        /*private void dtgvDrink_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int  i;
            i = dtgvDrink.CurrentRow.Index;
            txbDrinkMaMon.Text = dtgvDrink.Rows[i].Cells[0].Value.ToString();
            txbDrinkName.Text = dtgvDrink.Rows[i].Cells[1].Value.ToString();
            nmDrinkPrice.Text = dtgvDrink.Rows[i].Cells[2].Value.ToString();
        }*/
        void LoadListDrink()
        {
            //Gán dữ liệu vào binding source thay vì dtgv
            DrinkList.DataSource = DataProvider.Instance.ExcuteQuery("select MaMon, TenMon, DonGiaB from MON where Mon_Status = 0");
        }

        void AddDrinkBinding()                      //true ở đây là phải đồng nhất kiểu dữ liệu khi nhập vào, Data.....never là k thay đổi khi nhập, chỉ thay đổi khi hoàn thành
        {
            txbDrinkMaMon.DataBindings.Add(new Binding("Text", dtgvDrink.DataSource, "MaMon", true, DataSourceUpdateMode.Never));
            txbDrinkName.DataBindings.Add(new Binding("Text", dtgvDrink.DataSource, "TenMon", true, DataSourceUpdateMode.Never));
            nmDrinkPrice.DataBindings.Add(new Binding("Value", dtgvDrink.DataSource, "DonGiaB", true, DataSourceUpdateMode.Never));
        }
        

        private void btnShowDrink_Click(object sender, EventArgs e)
        {
            LoadListDrink();
        }

        void LoadListTable()
        {
            TableList.DataSource = DataProvider.Instance.ExcuteQuery("select * from BAN where Ban_Status = 0");
        }

        void AddTableBinding()
        {
            txbTrangThaiBan.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "TinhTrang", true, DataSourceUpdateMode.Never));
            txbMaBan.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "MaBan", true, DataSourceUpdateMode.Never));
            txbBan_Stastus.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "Ban_Status", true, DataSourceUpdateMode.Never));

        }

        private void btnShowTable_Click(object sender, EventArgs e)
        {
            LoadListTable();
        }

      

        void AddStaffBinding()
        {
            txbMaNV.DataBindings.Add(new Binding("Text", dtgvStaff.DataSource, "MaNV", true, DataSourceUpdateMode.Never));
            txbTenNV.DataBindings.Add(new Binding("Text", dtgvStaff.DataSource, "TenNV", true, DataSourceUpdateMode.Never));
            txbSDT.DataBindings.Add(new Binding("Text", dtgvStaff.DataSource, "SDT", true, DataSourceUpdateMode.Never));
            txbLoaiTK.DataBindings.Add(new Binding("Text", dtgvStaff.DataSource, "LoaiNV", true, DataSourceUpdateMode.Never));

        }

        void LoadListStaff()
        {
            StaffList.DataSource = DataProvider.Instance.ExcuteQuery("select MaNV, TenNV, SDT, LoaiNV from NHANVIEN where NV_Status = 0");
        }

        

        

        private void btnAddDrink_Click(object sender, EventArgs e)
        {
            string MaMon = txbDrinkMaMon.Text;
            string TenMon = txbDrinkName.Text;
            int DonGiaB = (int)nmDrinkPrice.Value;

            if (DrinkDAO.Instance.InsertDrink(TenMon, DonGiaB))
            {
                MessageBox.Show("Thêm món thành công!");
                LoadListDrink();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm đồ uống mới!");
            }    
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            string MaBan = txbMaBan.Text;
            string TinhTrang = txbTrangThaiBan.Text;

            if(TableDAO.Instance.InsertTable( TinhTrang))
            {
                MessageBox.Show("Thêm bàn thành công!");
                LoadListTable();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm bàn mới!");
            }
        }

        private void btnEditDrink_Click(object sender, EventArgs e)
        {
            string TenMon = txbDrinkName.Text;
            int DonGiaB = (int)nmDrinkPrice.Value;
            string MaMon = txbDrinkMaMon.Text;

            if (DrinkDAO.Instance.UpdateDrink(TenMon, DonGiaB, MaMon))
            {
                MessageBox.Show("Sửa thành công!");
                LoadListDrink();
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa");
            }
        }

        private void btnSearchDrink_Click(object sender, EventArgs e)
        {
           DrinkList.DataSource = SearchMONByName(txbSearchDrinkName.Text);
            // DrinkList.DataSource = DataProvider.Instance.ExcuteQuery("select * from MON where TenMon like N'%{0}%'");
        }

        private void txbSearchDrinkName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnEditTable_Click(object sender, EventArgs e)
        {
            string TinhTrang = txbTrangThaiBan.Text;
            string MaBan = txbMaBan.Text;

            if (TableDAO.Instance.UpdateTable(TinhTrang, MaBan))
            {
                MessageBox.Show("Sửa thành công!");
                LoadListTable();
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa");
            }
        }

        private void btnDeleteTable_Click(object sender, EventArgs e)
        {
            string MaBan = txbMaBan.Text;

            if (TableDAO.Instance.DeleteTable(MaBan))
            {
                MessageBox.Show("Xóa thành công!");
                LoadListTable();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa");
            }

        }

        private void btnEditPassword_Click(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile();
            f.ShowDialog();
        }

        private void btnShowStaff_Click(object sender, EventArgs e)
        {
            LoadListStaff();
        }

        private void btnAddStaff_Click_1(object sender, EventArgs e)
        {
            string TenNV = txbTenNV.Text;
            string SDT = txbSDT.Text;
            string LoaiNV = txbLoaiTK.Text;

            if (StaffDAO.Instance.InsertStaff(TenNV, SDT, LoaiNV))
            {
                MessageBox.Show("Thêm tài khoản thành công");
                LoadListStaff();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm mới!");
            }
        }

        private void btnEditStaff_Click(object sender, EventArgs e)
        {
            string MaNV = txbMaNV.Text;
            string TenNV = txbTenNV.Text;
            string SDT = txbSDT.Text;
            string LoaiNV = txbLoaiTK.Text;

            if (StaffDAO.Instance.EditStaff(TenNV,SDT, LoaiNV, MaNV))
            {
                MessageBox.Show("Sửa thành công");
                LoadListStaff();
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa!");
            }
        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            string MaNV = txbMaNV.Text;

            if (StaffDAO.Instance.DeleteStaff(MaNV))
            {
                MessageBox.Show("Xóa  thành công!");
                LoadListStaff();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa!");
            }
        }


        /*private void btnDeleteTable_Click(object sender, EventArgs e)
        {
            string MaBan = txbMaBan.Text;
            string MaHD = Convert.ToString(MaHD);//?

            if (TableDAO.Instance.DeleteTable(MaBan,MaHD))
            {
                MessageBox.Show("Xóa bàn thành công!");
                LoadListTable();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa!");
            }
        }*/
    }
}
