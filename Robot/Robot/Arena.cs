using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    public class Arena
    //variables
    {
    public Arena()
    {

    }
 //constructors





 //meathods
    public void StartRound()
    {
        
        Tyson tysonBot = new Tyson();
        Mayweather mayweatherBot = new Mayweather();
        while(tysonBot.health > 0 && mayweatherBot.health > 0)
            {
                tysonBot.GenerateHit(mayweatherBot);
                Console.WriteLine(tysonBot.GetPowerLevel());
                Console.ReadKey();
                mayweatherBot.GenerateHit(tysonBot);
                Console.WriteLine(tysonBot.GetPowerLevel());
                Console.ReadKey();
            }
        

    
    }

 




       

    }
}
