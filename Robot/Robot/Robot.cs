using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    public class Robot
    //variables//
    {
        protected int powerLevel;
        protected bool on;
        protected string color;
        public int health;
       
        
        //constructors
        public Robot()
        {
            powerLevel = 100;
            on = true;
            color = "silver";
            health = 100;
        }
        //Meathods

        public void DeliverHit(Robot robot)
        {
            
            powerLevel -= 10;
            robot.health -= 10;

        }
        public int GetPowerLevel()
        {
            return powerLevel;
        }
        public void TakeDamage()
        {

        }





    }


}




       




