using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainbowSchoolPage
{
    class Student
    {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Grade { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string filePath = @"C:\\Users\\vpava.DESKTOP-U064AL2\\OneDrive\\Desktop\\Simplilearn\\AssistedPractice\\PracticeProblem_2\\students.txt";

            
            using (StreamReader reader = new StreamReader(filePath))
            {
                
                reader.ReadLine();

              
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] data = line.Split(',');

                    
                    Student student = new Student
                    {
                        Name = data[0].Trim(),
                        Age = int.Parse(data[1].Trim()),
                        Grade = data[2].Trim()
                    };

                    students.Add(student);
                }
            }

           
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name}, {student.Age}, {student.Grade}");
            }

        }
    }
}
