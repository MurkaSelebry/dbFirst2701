using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace dbFirst2701
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var db = new Company_DB_PV_113Entities();
            var customer_result = db.stp_CustomerByID(2).First();
            WriteLine($"{customer_result.id} {customer_result.FirstName} {customer_result.LastName}");

            IEnumerable<CustomerModel> customers;

            ReadLine();
        }
    }
}
