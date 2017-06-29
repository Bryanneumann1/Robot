using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    public class Mayweather : Robot
    {
        //variables





        //constructors

    public Mayweather()
        {

        }



        //meathods
        public void GenerateHit(Robot robot)
        {
            Random hit = new Random();
            int number = hit.Next(0, 100);
           
            {
                if (number > 35)
                {
                    Console.WriteLine("Money Mayweather landed his punch!");
                }
                else if (number <= 65)
                {
                    Console.WriteLine("Money Mayweather didn't land his punch!");
                    DeliverHit(robot);
                }

            
            }
        }

    }

}
