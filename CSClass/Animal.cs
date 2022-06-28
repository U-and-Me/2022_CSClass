using System;

namespace CSClass
{
    public class Animal
    {
        int Age;

        public Animal()
        {
            Age = 0;
        }

        public virtual void Eat()
        {
            Console.WriteLine("냠냠");
        }

        public void Sleep()
        {
            Console.WriteLine("쿨쿨");
        }
    }
}