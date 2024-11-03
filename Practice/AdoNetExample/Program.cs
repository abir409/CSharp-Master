using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=192.168.11.100;Database=CSharpnew;User Id=sa;Password=fintech@123;";

            //string deleteCommand = "delete from courses where id = 3";
            //string query = "select * from courses";
            string title = Console.ReadLine();
            double fees = double.Parse(Console.ReadLine());
            DateTime classstart = DateTime.Parse(Console.ReadLine());
            bool isOpen = bool.Parse(Console.ReadLine());
            string commandText = $"insert into courses (title, fees, classstartdate, isopen, coursecode) values (@title, @fees, @classStartDate, @isOpen, '{Guid.NewGuid()}')";

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("title", title));
            parameters.Add(new SqlParameter("fees", fees));
            parameters.Add(new SqlParameter("classStartDate", classstart));
            parameters.Add(new SqlParameter("isOpen", isOpen));
            DataUtility dataUtility = new DataUtility(connectionString);
            //dataUtility.ExecuteQuery(query);
            dataUtility.ExecuteCommand(commandText,parameters);
            //List<Dictionary<string, object>> result = dataUtility.ExecuteQuery(query); ;

            //foreach (var row in result)
            //{
            //    foreach (var col in row)
            //    {
            //        Console.WriteLine($"{col.Key}:{col.Value}");
            //        Console.Write(" ");
            //    }
            //    Console.WriteLine();    
            //}
        }
    }
}
