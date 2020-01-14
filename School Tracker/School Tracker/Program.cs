using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Tracker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            bool adding = true;

            while (adding)
            {
                Student newStudent = new Student();
                Console.Write("Student Name: ");
                newStudent.Name = Console.ReadLine();

                Console.Write("Student Grade: ");
                newStudent.Grade = int.Parse(Console.ReadLine());

                Console.Write("Student Birthday: ");
                newStudent.Birthdday = Console.ReadLine();

                Console.Write("Student Address: ");
                newStudent.Address = Console.ReadLine();

                Console.Write("Student Phone Number: ");
                newStudent.Phone = int.Parse(Console.ReadLine());

                students.Add(newStudent);

                Console.WriteLine("Add another? y/n");

                if (Console.ReadLine() != "y")
                    adding = false;
            }

            foreach (Student student in students)
            {
                Console.WriteLine("Name: {0}, Grade: {1}", student.Name, student.Grade); 
            }
        }
    }

    class Student
    {
        public string Name;
        public int Grade;
        public string Birthdday;
        public string Address;
        private int phone;

        public int Phone
        {
            set
            {
                phone = value;
            }

            get
            {
                return phone;
            }

        }

        //function able to access private int phone by SetPhone Method
        public void SetPhone (int number)
        {
            phone = number;
        }

    }
}
