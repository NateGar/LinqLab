using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 10, 2330, 112233, 10, 949, 3764, 2942 };

            var smallest = nums.Min();
            Console.WriteLine("Smallest Number: {0}", smallest);

            var largest = nums.Max();
            Console.WriteLine("Largest Number: {0}", largest);

           foreach(int i in nums)
            {
                if (i < 10000)
                {
                    var biggest = nums.Max();
                    Console.WriteLine("Largest Number under 10000: {0}", biggest);
                }
            }

            foreach (int i in nums)
            {
                if (i < 100)
                {
                    if (i > 10)
                    {                        
                        Console.WriteLine(i);
                    }
                }
            }


            foreach (int i in nums)
            {
                if (i <= 999999)
                {
                    if (i >= 100000)
                    {
                        Console.WriteLine(i);
                    }
                }
            }

            var evenElements = nums.Count(i => i % 2 == 0);

            Console.WriteLine("Even Numbers: {0}", evenElements);

            List<Student> students = new List<Student>();
            students.Add(new Student("Jimmy", 13));
            students.Add(new Student("Hannah Banana", 21));
            students.Add(new Student("Justin", 30));
            students.Add(new Student("Sarah", 53));
            students.Add(new Student("Hannibal", 15));
            students.Add(new Student("Phillip", 16));
            students.Add(new Student("Maria", 63));
            students.Add(new Student("Abe", 33));
            students.Add(new Student("Curtis", 10));

            Solution s = new Solution(students);
            s.FindStudentsOver21();
            s.FindStudentsOver21AndEven();
            s.FindTeanageStudents();


            var oldest = students.Max(s => s.Age);
            var result = from c in students
                         where c.Age == oldest
                         select c;

            foreach (Student a in result)
            {
                Console.WriteLine(a.Name);
            }

            var youngest = students.Min(s => s.Age);
            var otherResult = from c in students
                         where c.Age == youngest
                         select c;

            foreach (Student a in otherResult)
            {
                Console.WriteLine(a.Name);
            }

            var vowelNames = from v in students
                             where v.Name.ToLower().StartsWith("a")                             
                             select v;

            foreach (Student a in vowelNames)
            {
                Console.WriteLine(a.Name);
            }
        }
    }
}
