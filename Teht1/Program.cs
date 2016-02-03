using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht1
{
    class Program
    {
        static void Main(string[] args)
        {

            Lift lift = new Lift();
            lift.floor = 6;
            Console.WriteLine("Lift is at floor {0}", lift.floor);
        }
    }
}
