using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(String[] args)
        {
            int choice ;
            
            
                var operation1 = new Myclass();
                Console.WriteLine("====SIMPLE CALCULATION==== ");
                Console.WriteLine("ENTER FIRST NUMBER");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("ENTER SECOND NUMBER");
                double num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("======USER GUIDE========");
                Console.WriteLine("\n\n");
                Console.WriteLine("ENTER 1 FOR ADDITION");
                Console.WriteLine("ENTER 2 FOR SUBSTRACTION");
                Console.WriteLine("ENTER 3 FOR MULTIPLICATION");
                Console.WriteLine("ENTER 4 FOR DIVISION");


                Console.WriteLine("enter your choise");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("THE ADDITION OF {0} AND SECOND NUMBER {1} is {2}", num1, num2, operation1.Add(num1, num2));
                        Console.ReadKey();
                        break;

                    case 2:


                        Console.WriteLine("THE SUBSTRACTION OF FIRST NUMBER {0} AND SECOND NUMBER {1} is {2}", num1, num2, operation1.substraction(num1, num2));
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("THE MULTIPLICATIO OF FIRST NUMBER {0} AND SECOND NUMBER {1} is {2}", num1, num2, operation1.multiplication(num1, num2));
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.WriteLine("THE DIVISION OF FIRST NUMBER {0} AND SECOND NUMBER {1} is {2}", num1, num2, operation1.division(num1, num2));
                        Console.ReadKey();
                        break;

                }
            
           

        }

        
    }
}
