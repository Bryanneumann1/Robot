using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    public class Tyson : Robot
    {
        //variables




         //constructors
    public Tyson()
        {
            
        }

        //meathods
        public void GenerateHit(Robot robot)
        {
            
        Random hit = new Random();
            int number = hit.Next(0, 100);
        
            {
                if (number < 50)
                {
                    Console.WriteLine("Iron Tyson didn't land his punch");
                }
                else if (number >= 50)
                { 
                Console.WriteLine("Iron Tyson Landed his punch!");
                    DeliverHit(robot);
                
    
                 
                }

                
            }


        }

        
    }

}
