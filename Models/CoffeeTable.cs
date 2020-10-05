using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using System.Data.SqlClient;
using System.Data;


namespace Lab_11._2.Models
{

    [Table("CoffeeTable")]
    public class CoffeeTable
    {      
        [Key]
        public long ProductID { get; set; }

        public string ProductName { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public string Category { get; set; }


        //public static List<CoffeeTable> Read(long _id)
        //{
        //    IDbConnection db = new SqlConnection("Server=GWJSN13\\SQLEXPRESS; Database=Coffee2;  user id=admin; password=pass1;");
        //    List <CoffeeTable> prod = db.Get<CoffeeTable>(_id);
        //    return prod;
        //}

        public static List<CoffeeTable> Read()
        {
            IDbConnection db = new SqlConnection("Server=GWJSN13\\SQLEXPRESS; Database=Coffee2; user id=admin; password=pass1;");
            List<CoffeeTable> prods = db.GetAll<CoffeeTable>().ToList();
            return prods;
        }

        public void Save()
        {
            IDbConnection db = new SqlConnection("Server=GWJSN13\\SQLEXPRESS; Database=Coffee2;  user id=admin; password=pass1;");
            db.Update(this);
        }

        public static void Delete(long _id)
        {
            IDbConnection db = new SqlConnection("Server=GWJSN13\\SQLEXPRESS; Database=Coffee2;  user id=admin; password=pass1;");
            db.Delete(new CoffeeTable() { ProductID = _id });
        }
    }
}