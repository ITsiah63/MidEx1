using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm_wk8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declarations
            double user = 0-100;          
 
            Console.WriteLine("Input most recent grade"); //asks for user input
            user =  Convert.ToDouble(Console.ReadLine());


            if (user < 100) {
                switch (user)
                {
                    case 1:
                        Console.WriteLine("Your grade is an A");
                        break;
                    case 2:
                        Console.WriteLine("Your grade is a B");
                        break;
                    case 3 :
                        Console.WriteLine("Your grade is a C");
                        break;
                    case 4:
                        Console.WriteLine("Your grade is a D");
                        break;
                    case 5:
                        Console.WriteLine("Your grade is a F");
                        break;
                }
                Console.Read();
            }
        }
    }
}
