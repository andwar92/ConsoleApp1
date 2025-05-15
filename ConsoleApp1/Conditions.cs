using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1;

public class Conditions
{
    bool isEqual = true;
    int a = 10;
    int b = 10;

    public void Run()
    {
        if (a == b)
        {
            isEqual = true;
            Console.WriteLine("A er lik B");
            if (a > b)
            {
                isEqual = true;
                Console.WriteLine("A er lik B");
            }
        }
        else
        {
            isEqual = false;
            a--;
            Console.WriteLine("A er større enn B");
        }
    }
}