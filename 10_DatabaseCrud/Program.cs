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
            #region Kategori Ekleme İşlemi
            //Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            //Console.WriteLine();
            //Console.WriteLine("------------------");
            //Console.Write("Eklemek istediğiniz kategori adı: ");
            //string categoryName = Console.ReadLine();
            //SqlConnection connection = new SqlConnection("Data Source=EMIRHAN\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.Write("Kategori başarıyla eklendi");
            #endregion

            #region Kategori Listeleme (SELECT - SqlDataReader)
            //SqlConnection connection = new SqlConnection("Data Source=EMIRHAN\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand listCmd = new SqlCommand("SELECT CategoryID, CategoryName FROM TblCategory", connection);
            //SqlDataReader reader = listCmd.ExecuteReader();
            //while (reader.Read())
            //{
            //    int id = Convert.ToInt32(reader["CategoryID"]);
            //    string name = reader["CategoryName"].ToString();
            //    Console.WriteLine($"ID: {id} - Name: {name}");
            //}
            //reader.Close();
            //connection.Close();
            #endregion

            #region Kategori Güncelleme (UPDATE)
            //Console.Write("Güncellenecek kategori ID'si: ");
            //int updateId = int.Parse(Console.ReadLine());
            //Console.Write("Yeni kategori adı: ");
            //string newName = Console.ReadLine();
            //using (SqlConnection connection = new SqlConnection("Data Source=EMIRHAN\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true"))
            //{
            //    connection.Open();
            //    using (SqlCommand updateCmd = new SqlCommand("UPDATE TblCategory SET CategoryName = @p1 WHERE CategoryID = @p2", connection))
            //    {
            //        updateCmd.Parameters.AddWithValue("@p1", newName);
            //        updateCmd.Parameters.AddWithValue("@p2", updateId);
            //        int rows = updateCmd.ExecuteNonQuery();
            //        Console.WriteLine(rows > 0 ? "Güncelleme başarılı." : "Güncellenecek kayıt bulunamadı.");
            //    }
            //}
            #endregion

            #region Kategori Silme (DELETE)
            //Console.Write("Silinecek kategori ID'si: ");
            //int deleteId = int.Parse(Console.ReadLine());
            //using (SqlConnection connection = new SqlConnection("Data Source=EMIRHAN\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true"))
            //{
            //    connection.Open();
            //    using (SqlCommand deleteCmd = new SqlCommand("DELETE FROM TblCategory WHERE CategoryID = @p1", connection))
            //    {
            //        deleteCmd.Parameters.AddWithValue("@p1", deleteId);
            //        int rows = deleteCmd.ExecuteNonQuery();
            //        Console.WriteLine(rows > 0 ? "Silme başarılı." : "Silinecek kayıt bulunamadı.");
            //    }
            //}
            #endregion

            #region Tek Kategori Getirme (SELECT - ExecuteScalar veya Reader)
            //Console.Write("Detayını görmek istediğiniz kategori ID'si: ");
            //int detailId = int.Parse(Console.ReadLine());
            //using (SqlConnection connection = new SqlConnection("Data Source=EMIRHAN\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true"))
            //{
            //    connection.Open();
            //    using (SqlCommand detailCmd = new SqlCommand("SELECT CategoryName FROM TblCategory WHERE CategoryID = @p1", connection))
            //    {
            //        detailCmd.Parameters.AddWithValue("@p1", detailId);
            //        object result = detailCmd.ExecuteScalar();
            //        if (result != null && result != DBNull.Value)
            //        {
            //            Console.WriteLine($"Kategori Adı: {result.ToString()}");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Kategori bulunamadı.");
            //        }
            //    }
            //}
            #endregion

            #region DataTable ile Veri Alma (SqlDataAdapter)
            //using (SqlConnection connection = new SqlConnection("Data Source=EMIRHAN\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true"))
            //{
            //    using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT CategoryID, CategoryName FROM TblCategory", connection))
            //    {
            //        DataTable dt = new DataTable();
            //        adapter.Fill(dt);
            //        foreach (DataRow row in dt.Rows)
            //        {
            //            Console.WriteLine($"ID: {row["CategoryID"]} - Name: {row["CategoryName"]}");
            //        }
            //    }
            //}
            #endregion

            #region Transaction Örneği (Toplu işlem - rollback/commit)
            //using (SqlConnection connection = new SqlConnection("Data Source=EMIRHAN\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true"))
            //{
            //    connection.Open();
            //    SqlTransaction transaction = connection.BeginTransaction();
            //    try
            //    {
            //        using (SqlCommand cmd1 = new SqlCommand("INSERT INTO TblCategory (CategoryName) VALUES (@p1)", connection, transaction))
            //        {
            //            cmd1.Parameters.AddWithValue("@p1", "TransactionCategory1");
            //            cmd1.ExecuteNonQuery();
            //        }
            //        using (SqlCommand cmd2 = new SqlCommand("INSERT INTO TblCategory (CategoryName) VALUES (@p1)", connection, transaction))
            //        {
            //            cmd2.Parameters.AddWithValue("@p1", "TransactionCategory2");
            //            cmd2.ExecuteNonQuery();
            //        }
            //        transaction.Commit();
            //        Console.WriteLine("Transaction commit edildi.");
            //    }
            //    catch (Exception ex)
            //    {
            //        transaction.Rollback();
            //        Console.WriteLine("Hata oluştu, rollback yapıldı. Hata: " + ex.Message);
            //    }
            //}
            #endregion

            #region Stored Procedure ile Ekleme Örneği (varsa)
            // NOT: Aşağıdaki örnek bir stored procedure olduğunu varsayar:
            // CREATE PROCEDURE sp_AddCategory @Name NVARCHAR(100) AS BEGIN INSERT INTO TblCategory (CategoryName) VALUES (@Name) END
            //
            //using (SqlConnection connection = new SqlConnection("Data Source=EMIRHAN\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true"))
            //{
            //    connection.Open();
            //    using (SqlCommand spCmd = new SqlCommand("sp_AddCategory", connection))
            //    {
            //        spCmd.CommandType = CommandType.StoredProcedure;
            //        spCmd.Parameters.AddWithValue("@Name", "StoredProcCategory");
            //        spCmd.ExecuteNonQuery();
            //        Console.WriteLine("Stored procedure ile ekleme yapıldı.");
            //    }
            //}
            #endregion

            Console.Read();
        }
    }
}
