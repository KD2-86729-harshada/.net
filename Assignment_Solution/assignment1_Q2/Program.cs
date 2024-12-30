using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1_Q2
{
    public class Maths
    {
        #region 4functions of calculator 
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Subtract(int x, int y)
        {
            return x - y;
        }

        public double Multiplication(double x, double y)
        {
            return x * y;
        }

        public double Division(double x, double y)
        {
            return x / y;
        }
        #endregion

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            Maths obj = new Maths();
            while (true)
            {
                Console.WriteLine("Enter the choice : ");
                Console.WriteLine("1: Add, 2: Sub, 3:Mult, 4:Div, 0 : Exit");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the value of x: ");
                        String xValue = Console.ReadLine();
                        int x = Convert.ToInt32(xValue);

                        Console.WriteLine("Enter the value of y: ");
                        String yValue = Console.ReadLine();
                        int y = Convert.ToInt32(yValue);

                        int result = obj.Add(x, y);
                        Console.WriteLine(result);

                        break;

                    case 2:
                        Console.WriteLine("Enter the value of x: ");
                        String xValue1 = Console.ReadLine();
                        int x1 = Convert.ToInt32(xValue1);

                        Console.WriteLine("Enter the value of y: ");
                        String yValue1 = Console.ReadLine();
                        int y1 = Convert.ToInt32(yValue1);

                        int result1 = obj.Subtract(x1, y1);
                        Console.WriteLine(result1);

                        break;


                    case 3:
                        Console.WriteLine("Enter the value of x: ");
                        String xValue2 = Console.ReadLine();
                        int x2 = Convert.ToInt32(xValue2);

                        Console.WriteLine("Enter the value of y: ");
                        String yValue2 = Console.ReadLine();
                        int y2 = Convert.ToInt32(yValue2);

                        double result2 = obj.Multiplication(x2, y2);
                        Console.WriteLine(result2);

                        break;


                    case 4:
                        Console.WriteLine("Enter the value of x: ");
                        String xValue3 = Console.ReadLine();
                        double x3 = Convert.ToInt32(xValue3);

                        Console.WriteLine("Enter the value of y: ");
                        String yValue3 = Console.ReadLine();
                        double y3 = Convert.ToInt32(yValue3);

                        double result3 = obj.Division(x3, y3);
                        Console.WriteLine(result3);

                        break;

                    default:
                        break;
                }
            }
            #endregion

        }
    }
}
