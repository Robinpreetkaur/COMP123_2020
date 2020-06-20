
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate object of type Person
            Person robin = new Person("Robin", 20);

            // use saysHello method with . accessor
            robin.SaysHello();

            Console.ReadLine();

        }
    }
}