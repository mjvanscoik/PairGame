using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _101_PairGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            var gameconsole = new Game();

           
            gameconsole.Seed(); //Just seed and then menu. Have menu call upon prompt method from within the menu method. 
           
            Console.ReadLine();
            
        }
    }
}
