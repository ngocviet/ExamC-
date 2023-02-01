using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quesstion2
{
    internal class Student
    {
        private string studentNumber;
        private string studentName;
        private string studentAddress;
        private int studentAge;

        public string StudentNumber
        {
            get => studentNumber;
            set => studentNumber = value;
        }
        public string StudentName { get => studentName; set => studentName = value; }
        public string StudentAddress { get => studentAddress; set => studentAddress = value; }
        public int StudentAge { get => studentAge; set => studentAge = value; }

        internal void input()
        {
            Random r = new Random();
            StudentNumber = r.Next(0, 100).ToString();
            Console.Write("Enter Name: ");
            studentName = Console.ReadLine();
            Console.Write("Enter Address: ");
            studentAddress = Console.ReadLine();
            Console.Write("Enter Age: ");
            string ageString = Console.ReadLine();
            try
            {
                studentAge = Int32.Parse(ageString);
            }
            catch
            {
                Console.WriteLine("Age is fail! Please enter again!");
                input();
            }
        }
        public override string ToString()
        {
            return $"Student: id: {StudentNumber}, Name: {StudentName}, Address: {StudentAddress}, Age: {StudentAge}";
        }
    }
}
