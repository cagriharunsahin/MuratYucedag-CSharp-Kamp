using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("---------------------------------------");

            #region Kategori Ekleme İşlemi

            //Console.Write("Eklemek istediğiniz kategori adını giriniz: ");
            //string categoryName = Console.ReadLine();


            //SqlConnection connection = new SqlConnection(@"Server=DESKTOP-9FJQG54\SQLEXPRESS;Initial Catalog=EğitimKampıDb;Integrated Security=True;TrustServerCertificate=True;");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into dbo.TblCategory (categoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection .Close();

            //Console.Write("Kategori başarıyla eklendi. ");

            #endregion

            #region Ürün Ekleme İşlemi

            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.Write("Eklemek istediğiniz ürün adı: ");
            //productName=Console.ReadLine();
            //Console.WriteLine();
            //Console.Write("Eklediğiniz ürünün fiyatı: ");
            //productPrice=decimal.Parse(Console.ReadLine());
            //Console.WriteLine();
            //SqlConnection connection = new SqlConnection(@"Server=DESKTOP-9FJQG54\SQLEXPRESS;Initial Catalog=EğitimKampıDb;Integrated Security=True;TrustServerCertificate=True;");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into dbo.TblProduct (productName,productPrice,productStatus) values (@productName,@productPrice,@productStatus) ", connection);
            //command.Parameters.AddWithValue("@productName",productName);
            //command.Parameters.AddWithValue("@productPrice",productPrice);
            //command.Parameters.AddWithValue("@productStatus",true);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.Write("Ürün Başırıyla Eklendi");


            #endregion

            #region Ürün Listeleme İşlemi

            //SqlConnection connection = new SqlConnection(@"Server=DESKTOP-9FJQG54\SQLEXPRESS;Initial Catalog=EğitimKampıDb;Integrated Security=True;TrustServerCertificate=True;");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Select * From dbo.TblProduct",connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString()+" ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Ürün Kaldırma İşlemi

            //Console.Write("Silinecek ID: ");
            //int productİd=int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection(@"Server=DESKTOP-9FJQG54\SQLEXPRESS;Initial Catalog=EğitimKampıDb;Integrated Security=True;TrustServerCertificate=True;");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Delete From dbo.TblProduct Where ProductId=@productİd",connection);
            //command.Parameters.AddWithValue("@productİd",productİd);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Ürün başarıyla kaldırıldı. ");


            #endregion

            #region Ürün Güncelleme İşlemi

            //Console.Write("Güncellenecek Ürün İd: ");
            //int productId=int.Parse(Console.ReadLine());
            //Console.Write("Güncellenecek Ürün İsmi: ");
            //string productName=(Console.ReadLine());
            //Console.Write("Güncellenecek Ürün Fiyatı: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection(@"Server=DESKTOP-9FJQG54\SQLEXPRESS;Initial Catalog=EğitimKampıDb;Integrated Security=True;TrustServerCertificate=True;");
            //connection .Open();
            //SqlCommand command = new SqlCommand("Update dbo.TblProduct Set ProductName=@productName,ProductPrice=@productPrice Where ProductId=@productId",connection);
            //command.Parameters.AddWithValue("@productName",productName);
            //command.Parameters.AddWithValue("@productPrice",productPrice);
            //command.Parameters.AddWithValue("@productId",productId);

            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Ürünler başarıyla güncellendi. ");

            #endregion


            Console.Read();
        }
    }
}
