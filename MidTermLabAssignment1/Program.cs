using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermLabAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {

            Address address1 = new Address(45,10,"Dhaka","Bangladesh");
            address1.PrintAddress();

            Console.ReadKey();
            

        }
    }
}
