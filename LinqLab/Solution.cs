using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LinqLab
{
    class Solution
    {
        public List<Student> Students { get; set; } = new List<Student>();

        public Solution(List<Student> testData)
        {
            this.Students = testData;
        }

        
       

        public List<Student> FindStudentsOver21()
        {
            List<Student> output = new List<Student>();
            output = Students.Where(s => s.Age >= 21).ToList();

            PrintStudents(output);
            return output;
        }        

        public List<Student> FindStudentsOver21AndEven()
        {
            List<Student> output = new List<Student>();
            output = Students.Where(s => s.Age >= 21 && s.Age % 2 == 0).ToList();

            PrintStudents(output);
            return output;
        }

        public List<Student> FindTeanageStudents()
        {
            List<Student> output = new List<Student>();
            foreach (Student s in Students)
            {
                if (s.Age >= 13)
                {
                    if (s.Age <= 19)
                    {
                        output.Add(s);
                    }
                }
            }
            PrintStudents(output);
            return output;
        }

        public void PrintStudents(List<Student> input)
        {
            foreach (Student s in input)
            {
                Console.WriteLine("Name: " + s.Name);
                Console.WriteLine("Age: " + s.Age);
                Console.WriteLine();
            }
        }
    }
}
