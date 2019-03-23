using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    // Adoptee Class 
   public class ThirdPartyEmployee
    {
        public List<string> GetEmployeeList()
        {
            List<string> employeeList = new List<string> {"Peter", "Poul", "Puru", "pata"};
            return employeeList;
        }

    }
}
