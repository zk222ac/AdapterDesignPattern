using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    // Adapter Class .......................
    class EmployeeAdapter : ThirdPartyEmployee , ITarget
    {
        public List<string> GetEmployees()
        {
            // call the method GetEmployeeList()
            // which is define in the base class ( ThirdPartyEmployee)
            return GetEmployeeList();
        }
    }
}
