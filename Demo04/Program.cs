using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a one car obejct
            Car car = new Car();
            car.Speed = 300;
            car.Height = 5.0;
            Console.WriteLine("Speed is {0}", car.Speed);
            Console.WriteLine("Heigt is {0}", car.Height);
            Console.ReadLine();
        }
    }
}
