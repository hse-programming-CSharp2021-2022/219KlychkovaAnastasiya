using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using System.Data;
namespace Task1.Controllers
{
    [Route("/db/[controller]")]
    public class DataBaseController : Controller
    {
        static readonly string connectionString = "Data Source=AdventureWorksLT.db";

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
        [HttpGet]
        public IActionResult GetAll()
        {
            string SQL = "SELECT * FROM Product";
            DataTable dt = ExecuteSQL_DataTable(connectionString, SQL);
            return Ok(dt.AsEnumerable().Select(x => x.ItemArray));
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            string SQL = $"SELECT * FROM Product WHERE ProductID = {id}";
            DataTable dt = ExecuteSQL_DataTable(connectionString, SQL);
            return Ok(dt.AsEnumerable().Select(x => x.ItemArray));
        }

        [HttpPost("{Name},{ProductNumber},{Color},{StandartCost},{ListPrice},{Size}")]
        public IActionResult Post( string Name, string ProductNumber, string Color, double StandartCost, double ListPrice, string Size)
        {
            string SQL = $"INSERT INTO Product (Name) VALUES {Name} (ProductNumber) VALUES {ProductNumber} " +
                $"(Color) VALUES {Color} (StandartCost)  VALUES {StandartCost} " +
                $"(ListPrice) VALUES {ListPrice} (Size) VALUES {Size}";
            DataTable dt = ExecuteSQL_DataTable(connectionString, SQL);
            return Ok(dt.AsEnumerable().Select(x => x.ItemArray));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            string SQL = $"DELETE FROM Product WHERE ProductID = {id}";
            DataTable dt = ExecuteSQL_DataTable(connectionString, SQL);
            return Ok(dt.AsEnumerable().Select(x => x.ItemArray));
        }
    }
}
