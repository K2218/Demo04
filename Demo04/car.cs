using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04
{
    class Car
    {
        private readonly int MaxSpeed = 200;
        private readonly double MaxHeight = 4.5;

        private int speed;
        private double height;
        public int Speed {
            get
            {
                return speed;
            }
            set
            {
                if (value <= MaxSpeed) speed = value;
                else
                {
                    Console.WriteLine("Too much speed - set to max!");
                    speed = MaxSpeed;
                }
            }
        }

        public double Height{
        get
        {
          return height;  
        }

      set
      {
                if (value < 0) {
                    Console.WriteLine("Too small height - set to zero");
                    height = 0;
                }
                else if (value > MaxHeight) {
                    Console.WriteLine("Too high - Set to max");
                    height = MaxHeight;
                }

                else height = value;
     } }

    }
}
