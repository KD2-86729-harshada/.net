using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2_Q2
{
    public class Student
    {
        private int rollNo;
        private string name;
        private double marks;

        public double Marks
        {
            get { return marks; }
            set { marks = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int RollNo
        {
            get { return rollNo; }
            set { rollNo = value; }
        }

        public Student(int rollNo, string name, double marks)
        {
            this.rollNo = rollNo;
            this.name = name;
            this.marks = marks;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] stud = null;
            Console.WriteLine("Enter the no. of Students : ");
            int n = Convert.ToInt32(Console.ReadLine());
            CreateArray(n, ref stud);
            AcceptInfo(stud);
            DisplayDetails(stud);
        }

        public static void CreateArray(int n, ref Student[] stud)
        {
            //AcceptInfo();
            stud = new Student[n];
        }

        public static void AcceptInfo(Student[] stud)
        {
            for (int i = 0; i < stud.Length; i++)
            {
                Console.WriteLine("Enter the RollNo : ");
                int rollNo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the name : ");
                String name = Console.ReadLine();

                Console.WriteLine("Enter the marks : ");
                double marks = Convert.ToDouble(Console.ReadLine());

                stud[i] = new Student(rollNo, name, marks);
            }
        }

        public static void DisplayDetails(Student[] stud)
        {
            foreach (Student student in stud)
            {
                Console.WriteLine(student.RollNo +" "+student.Name+" "+student.Marks);
            }
        }
    }

}
