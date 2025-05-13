using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ReturnSum
    {


        int a = 5; 
        int b = 10;

        public int Sum(int a, int b)
        {
            
                return a + b;
            }
        public void Run()
        {
            Console.WriteLine($"Dette er sum:{Sum(a,b)} ");
        }

    }

}
