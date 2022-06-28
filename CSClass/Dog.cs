using System;

namespace CSClass
{
    public class Dog : Animal
    {
        string Color;

        public new void Eat()
        {
            Console.WriteLine("강아지가 와구와구 먹어요");
        }

        public void Bark()
        {
            Console.WriteLine("멍멍");
        }
    }
}