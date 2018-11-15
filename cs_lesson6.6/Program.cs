using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cs_lesson6._6
{
    class Program
    {
        struct CustomerName
        {
            public string firstName, lastName;
            public string Name()
            {
                return firstName + " " + lastName;
            }

        }

        static void Main(string[] args)
        {
            CustomerName myCustomer;
            myCustomer.firstName = "John";
            myCustomer.lastName = "Franklin";
            Console.WriteLine(myCustomer.Name());
            Console.ReadKey();
        }
    }
}
