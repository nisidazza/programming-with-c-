using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prova
{
    class Program
    {
        static void Main(string[] args)
        {
            var greeter = new Greeter(Greet.Formal);
            Console.WriteLine(greeter.GetGreet());
        }
    }
}
