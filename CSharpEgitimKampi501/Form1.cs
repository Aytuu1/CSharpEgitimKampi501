using CSharpEgitimKampi501.Dtos;
using Dapper;
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

namespace CSharpEgitimKampi501
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }
    SqlConnection conn = new SqlConnection("Server=DESKTOP-EGM53VS\\SQLAYTU;initial Catalog=EgitimKampi501DB;integrated security=true;");
    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private async void btnList_Click(object sender, EventArgs e)
    {
      string query = "Select * from TblProduct";
      var values = await conn.QueryAsync<ResultProductDto>(query);
      dataGridView1.DataSource = values;
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
      string query = "insert into TblProduct (ProductName,ProductStock,ProductPrice,ProductCategory) values (@productName,@productStock,@productPrice,@productCategory)";

      var parameters = new DynamicParameters();
      parameters.Add("@productName", txtProductName.Text);
      parameters.Add("@productStock", txtProductStock.Text);
      parameters.Add("@productPrice", txtProductPrice.Text);
      parameters.Add("@productCategory", txtProductCategory.Text);

      conn.ExecuteAsync(query, parameters);
      MessageBox.Show("Ürün Başarıyla Eklendi");

    }

    private async void btnDelete_Click(object sender, EventArgs e)
    {
      string query = "Delete From TblProduct where ProductID=@productId";
      var parameters = new DynamicParameters();
      parameters.Add("@productId", txtProductID.Text);
      await conn.ExecuteAsync(query, parameters);
      MessageBox.Show("Kitap silme işlemi başarılı");
    }

    private async void btnUpdate_Click(object sender, EventArgs e)
    {
      string query = "Update TblProduct Set ProductName=@productName,ProductPrice=@productPrice,ProductCategory=@productCategory,ProductStock=@productStock where ProductID=@productId";
      var parameters = new DynamicParameters();
      parameters.Add("@productName", txtProductName.Text);
      parameters.Add("@productPrice", txtProductPrice.Text);
      parameters.Add("@productStock", txtProductStock.Text);
      parameters.Add("@productCategory", txtProductCategory.Text);
      parameters.Add("@productId", txtProductID.Text);
      await conn.ExecuteAsync(query, parameters);
      MessageBox.Show("Ürün başarıyla güncellendi", "Güncelleme", MessageBoxButtons.OK
        , MessageBoxIcon.Information);
    }

    private async void Form1_Load(object sender, EventArgs e)
    {
      #region Kitap Sayısı
      string query1 = "Select Count(*) from TblProduct";
      var productCount = await conn.QueryFirstOrDefaultAsync<int>(query1);
      lblTotalProductCount.Text = productCount.ToString();
      #endregion

      #region En Pahalı Kitap

      string query2 = "Select ProductName From TblProduct where ProductPrice=(Select Max(ProductPrice) From TblProduct)";
      var maxPriceProductName = await conn.QueryFirstOrDefaultAsync<string>(query2);
      lblMaxPriceProductName.Text = maxPriceProductName.ToString();

      #endregion

      #region Kategori Sayısı
      string query3 = "Select Count(Distinct(ProductCategory)) From TblProduct ";
      var distinctProductCount= await conn.QueryFirstOrDefaultAsync<int>(query3);
      lblDistinctCategoryCount.Text = distinctProductCount.ToString();
      #endregion



    }

    private void label8_Click(object sender, EventArgs e)
    {

    }

    private void label7_Click(object sender, EventArgs e)
    {

    }
  }
}
