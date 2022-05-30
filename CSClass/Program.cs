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

            Product product = new Product();
        }
    }

}
