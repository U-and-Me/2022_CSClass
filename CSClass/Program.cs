using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.SetInTime();
            car.SetOutTime();

            Random random = new Random();
            Console.WriteLine(random.Next(10, 100));    // 10 이상 100 미만 : 10 ~ 99
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));

            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble() * 10);    // 0부터 10 사이의 수
            
            /*
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3); 
            list.Add(4);
            */

            List<int> list = new List<int>() {1, 2, 3, 4};
            list.Remove(3); // 원하는 값 삭제
            list.RemoveAt(0); // 원하는 인덱스의 값 삭제

            foreach(var item in list)
            {
                Console.WriteLine("Count : " + list.Count + "\titem : " + item);
            }

            Console.WriteLine(Math.Abs(-52273));
            Console.WriteLine(Math.Ceiling(52.273));
            Console.WriteLine(Math.Floor(52.273));
            Console.WriteLine(Math.Max(52, 273));
            Console.WriteLine(Math.Min(52, 273));
            Console.WriteLine(Math.Round(52.273));
            Console.WriteLine(Math.Round(52.273, 2));
            Console.WriteLine(Math.PI);

            /*
            Product product = new Product();
            product.name = "고구마";
            product.price = 2000;
            */

            Product productA = new Product() { name = "감자", price = 3000 };
            Product productB = new Product() { price = 6000, name = "고구마" };
            Product productC = new Product() { name = "옥수수" };

            Console.WriteLine(productA);
            Console.WriteLine(productB);
            Console.WriteLine(productC);

            List<Student> students = new List<Student>() 
            {
                new Student() { name = "김유나", grade = 100 },
                new Student() { name = "AAA", grade = 98 },
                new Student() { name = "BBB", grade = 45 },
                new Student() { name = "CCC", grade = 57 },
                new Student() { name = "DDD", grade = 81 },
                new Student() { name = "EEE", grade = 91 },
                new Student() { name = "FFF", grade = 40 },
                new Student() { name = "GGG", grade = 17 },
                new Student() { name = "HHH", grade = 86 },
                new Student() { name = "III", grade = 70 }
            };

            // 점수가 60 이상인 학생 제거 - 방법1
            /*
            foreach (var student in students)
            {
                if(student.grade > 60)
                {
                    students.Remove(student);
                }
            }
            */

            // 방법2
            /*
            for(int i = 0; i < students.Count; i++)
            {
                if (students[i].grade > 60)
                {
                    students.Remove(students[i]);
                    i--;
                }
            }
            */

            // 방법3
            for (int i = students.Count - 1; i >= 0; i--)
            {
                if (students[i].grade > 60)
                {
                    students.Remove(students[i]);
                }
            }

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine(MyMath.Abs(52));
            Console.WriteLine(MyMath.Abs(-52));
            Console.WriteLine(MyMath.Abs(52.3));
            Console.WriteLine(MyMath.Abs(-52.3));
            Console.WriteLine(MyMath.Abs(52f));
            Console.WriteLine(MyMath.Abs(52L));
        }
    }

}
