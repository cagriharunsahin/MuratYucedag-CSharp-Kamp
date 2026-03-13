using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string tableSelect;

            //Console.WriteLine("***** Şahinler Restorantı *****");
            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("---------------------------------------");
            //Console.WriteLine("1-Kategoriler");
            //Console.WriteLine("2-Ürünler");
            //Console.WriteLine("3-Siparişler");
            //Console.WriteLine("4-Çıkış");
            //Console.WriteLine("---------------------------------------");

            //Console.Write("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
            //tableSelect = Console.ReadLine();


            //SqlConnection connection = new SqlConnection(@"Server=DESKTOP-9FJQG54\SQLEXPRESS;Initial Catalog=EğitimKampıDb;Integrated Security=True;TrustServerCertificate=True;");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Select * From dbo.TblCategory", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);
            //connection .Close();

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString());
            //    }
            //    Console.WriteLine();

            //}

            Console.Read();
        }
    }
}
