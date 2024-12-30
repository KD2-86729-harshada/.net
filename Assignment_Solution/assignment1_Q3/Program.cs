using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1_Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the two numbers : ");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            do
            {
                    Console.WriteLine("1.add\n 2.sub\n 3.mul\n 4.div");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    int result;

                    switch (choice) 
                    { 
                        case 1:
                            result = x+y;
                            Console.WriteLine(result);
                            break;

                        case 2: 
                            result = x-y;
                            Console.WriteLine(result);  
                            break;
                        
                        case 3:  
                            result = x*y;
                            Console.WriteLine(result);
                            break;

                        case 4:
                            result = x / y;
                            Console.WriteLine(result);
                            break;
                }
            }
            while (true);
        }
    }
}
