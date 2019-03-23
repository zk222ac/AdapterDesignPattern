using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    class Client
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee List from 3rd Party organization system");

            // Client will use ITarget interface to call the functionality of adaptee
            // class such as in our case ThirdPartyEmployee

            ITarget adapter = new EmployeeAdapter();
            foreach (var emp in adapter.GetEmployees())
            {
                Console.WriteLine(emp);
            }

            Console.ReadKey();

        }
    }
}
