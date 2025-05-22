using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Switch1
    {
        public void Run()
        {
            int Dag = 4;
            while (true)
            {
                var input = Console.ReadLine();

                switch (Convert.ToInt32(input))
                {
                    case 1:
                        Console.WriteLine("Mandag");
                        break;
                    case 2:
                        Console.WriteLine("Tirsdag");
                        break;
                    case 3:
                        Console.WriteLine("I dag er det Onsdag!");
                        break;
                    case 4:
                        Console.WriteLine("Torsdag");
                        break;
                    default:
                        Console.WriteLine("Ikke en gyldig dag");
                        break;
                    
                }
            }

        }
    }
}
