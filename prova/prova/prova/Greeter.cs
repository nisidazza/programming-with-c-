using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prova
{
    class Greeter
    {
        private readonly Greet _typeOfGreet;

        public Greeter(Greet typeOfGreets)
        {
            _typeOfGreet = typeOfGreets;
        }

        public string GetGreet()
        {
            switch (_typeOfGreet)
            {
                case Greet.Formal:
                    return "It is an honor to meet you.";
                    break;
                case Greet.Informal:
                    return "Yo man!";
                    break;
                default:
                    return string.Empty;
            }
        }
    }
}
