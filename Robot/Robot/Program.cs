using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Robot Fight");
            Arena Fight = new Arena();
            Fight.StartRound();
        
            Console.ReadKey();
            
            
        }  
    }
}
