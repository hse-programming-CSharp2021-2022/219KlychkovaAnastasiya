using System;
using System.Data;
using Microsoft.Data.Sqlite;

namespace Task2
{
    class Program
    {
        private static DataTable ExecuteSQL_DataTable(string connectionString, string SQL, params Tuple<string, string>[] parameters)
        {
            DataTable dt = new DataTable();
            using (SqliteConnection con = new SqliteConnection(connectionString))
            {
                using (SqliteCommand cmd = new SqliteCommand(SQL, con))
                {
                    cmd.CommandType = CommandType.Text;
                    foreach (var tuple in parameters)
                        cmd.Parameters.Add(new SqliteParameter(tuple.Item1, tuple.Item2));
                    con.Open();
                    SqliteDataReader reader = cmd.ExecuteReader();
                    for (int i = 0; i < reader.FieldCount; i++)
                        dt.Columns.Add(new DataColumn(reader.GetName(i)));

                    int rowIndex = 0;
                    while (reader.Read())
                    {
                        DataRow row = dt.NewRow();
                        dt.Rows.Add(row);
                        for (int i = 0; i < reader.FieldCount; i++)
                            dt.Rows[rowIndex][i] = (reader.GetValue(i));
                        rowIndex++;
                    }
                }
            }
            return dt;
        }

        static void Main(string[] args)
        {
            string connectionString = "Data Source = AdventureWorksLT.db";
            string SQL = "SELECT * FROM Product";
            string SQL2 = "SELECT * FROM Product WHERE ProductID = 680";
            string SQL3 = "SELECT * FROM Product WHERE ListPrice > 680 and ListPrice < 1000";
            string SQL4 = "UPDATE Product SET StandardCost = 345 WHERE ProductID = 680";
            string SQL5 = "UPDATE Product SET ListPrice = 400 WHERE ProductID = 680";
            string SQL6 = $"INSERT INTO Product (Name) VALUES {Console.ReadLine()} (ProductNumber) VALUES {Console.ReadLine()} " +
                $"(Color) VALUES {Console.ReadLine()} (StandartCost)  VALUES {double.Parse(Console.ReadLine())} " +
                $"(ListPrice) VALUES {double.Parse(Console.ReadLine())} (Size) VALUES {Console.ReadLine()} " +
                $"(Weight) VALUES {double.Parse(Console.ReadLine())} (ProductCaregoryId) VALUES {int.Parse(Console.ReadLine())} " +
                $"(ProductModelID) VALUES {int.Parse(Console.ReadLine())} (SellStartDate) VALUES {Console.ReadLine()} " +
                $"(SellEndDate) VALUES {Console.ReadLine()} (DiscontinuedDate) VALUES {Console.ReadLine()} " +
                $"(ThumbNailPhoto) VALUES {Console.ReadLine()} (ThumbnailPhotoFileName) VALUES {Console.ReadLine()} " +
                $"(rowguid) VALUES {Console.ReadLine()} (ModifiedDate) VALUES {Console.ReadLine()} ";
            string SQL7 = "DELETE FROM Product WHERE ProductID = 680";
            DataTable dt = ExecuteSQL_DataTable(connectionString, SQL7);


            foreach (DataRow row in dt.Rows)
            {
                foreach (var t in row.ItemArray)
                    Console.Write(t + " ");
                Console.WriteLine();
            }
        }
    }
}
