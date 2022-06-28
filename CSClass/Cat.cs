using System;

namespace CSClass
{
    public class Cat : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("고양이가 조물조물 먹어요");
        }
        public void Meow()
        {
            Console.WriteLine("냥냥");
        }
    }
}