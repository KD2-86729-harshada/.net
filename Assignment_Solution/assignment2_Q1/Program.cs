using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2_Q1
{
    public struct Student
    {
        
        private string name;
        private bool gender;
        private int age;
        private int std;
        private char div;
        private double marks;
        public Student(string name, bool gender, int age, int std, char div, double marks)
        {
            this.name = name;
            this.gender = gender;
            this.age = age;
            this.std = std;
            this.div = div;
            this.marks = marks;
        }

        public String Name 
        {
            get { return name; }
            set { name = value; }
        }
        public bool Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public int Std
        {
            get { return std; }
            set { std = value; }
        }
        public char Div
        {
            get { return div; }
            set { div = value; }
        }
        public double Marks
        {
            get { return marks; }
            set { marks = value; }
        }
  
        public void acceptDetails()
        {
            Console.WriteLine("Enter the name, gender, age, std, div, marks");
            
            name = Console.ReadLine();

            string genVal = Console.ReadLine();
            gender = Convert.ToBoolean(genVal);

            String ageVal = Console.ReadLine();
            age = Convert.ToInt32(ageVal);

            String stdVal = Console.ReadLine();
            std = Convert.ToInt32(stdVal);

            String divVal = Console.ReadLine();
            div =  Convert.ToChar(divVal);

            String marksVal = Console.ReadLine();
            marks = Convert.ToDouble(marksVal);
        }

        public void PrintDetails()
        {
            Console.WriteLine("Student details : ");
            Console.WriteLine(name+" "+gender+" "+age+" "+std+" "+div+" "+marks);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Student stud =  new Student();
            stud.acceptDetails();
            stud.PrintDetails();
        }
    }
}
