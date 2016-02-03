using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht1
{
    
    class Lift 
    {
        private readonly int MaxFloor = 5;
        public int floor;
        
        public int Floor {
            get
            {
                return floor;
            }

            set
            {
                if (value < 0)
                {
                    Console.WriteLine("That floor doesn't exist. It's too low");
                    floor = 0;
                }

                else if (value > 5)
                {
                    Console.WriteLine("That floor doesn't exist. It's too high");
                    floor = 5;
                }
                else floor = value;

            }
        }

      /*  public void ChangeFloor()
        {
            while (floor < MaxFloor)
            {
                floor = nextfloor;

            }*/
        }

      
    
}
