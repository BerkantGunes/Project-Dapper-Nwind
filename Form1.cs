using Dapper;
using Project5_DapperNorthwind.DTOs.CategoryDtos;
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

namespace Project5_DapperNorthwind
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // SQL connection olusturduk.
        SqlConnection conn = new SqlConnection("Server=GUNESBERKANT\\SQLEXPRESS;initial catalog=Db5Project20;integrated security=true");
        private async void btnCategoryList_Click(object sender, EventArgs e)
        {
            // sorgumuzu yazdık.
            string query = "Select * From Categories";
            var values = await conn.QueryAsync<ResultCategoryDto>(query); // Categories tbl kullandığımız için CategoryDto kullanırız.
            DGVCategory.DataSource = values;
        }

        private async void btnCatAdd_Click(object sender, EventArgs e)
        {
            string query = "insert into Categories (CategoryName,Description) Values (@addCategory,@addDescription)";
            var parametres = new DynamicParameters();
            parametres.Add("@addCategory", txtCatName.Text);
            parametres.Add("@addDescription", txtDescription.Text);
            await conn.ExecuteAsync(query,parametres);
            MessageBox.Show("Category Added Successfully!");
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            // Category Number 9
            string query = "Select Count(*) From Categories";
            var count = await conn.ExecuteScalarAsync<int>(query);
            lblCatCount.Text = "Total Categories Number: " + count;

            // Product Number 77
            string query2 = "Select Count(*) From Products";
            var productCount = await conn.ExecuteScalarAsync<int>(query2);
            lblProductCount.Text = "Total Product Number: " + productCount;

            // Average Product Stock Number (UnitsInStock Column)
            string query3 = "Select Avg(UnitsInStock) From Products";
            var avgProductStock = await conn.ExecuteScalarAsync<int>(query3);
            lblAvgProductStock.Text = "Average Product Stock: " + avgProductStock;

            // Seafood Total Price (UnitPrice Column CategoryId=8)
            string query4 = "Select Sum(UnitPrice) From Products Where CategoryId = (Select CategoryId From Categories Where CategoryName='Seafood')";
            var totalSeafoodPrice = await conn.ExecuteScalarAsync<decimal>(query4);
            lblSeafoodTotalPrice.Text = "Seafood Total Price: " + totalSeafoodPrice;
        }

        private async void btnCatUpdate_Click(object sender, EventArgs e)
        {
            string query = "Update Categories Set CategoryName=@categoryName, Description=@description Where CategoryId=@categoryId";
            var parametres = new DynamicParameters();
            parametres.Add("@categoryName", txtCatName.Text);
            parametres.Add("@description", txtDescription.Text);
            parametres.Add("@categoryId", txtCatId.Text);
            await conn.ExecuteAsync(query,parametres);
            MessageBox.Show("Category Updated Successfully!");
        }

        private async void btnCatDelete_Click(object sender, EventArgs e)
        {
            string query = "Delete From Categories Where CategoryId=@categoryId";
            var parametres = new DynamicParameters();
            parametres.Add("@categoryId", txtCatId.Text);
            await conn.ExecuteAsync(query,parametres);
            MessageBox.Show("Category Deleted Successfully!");
        }
    }
}
