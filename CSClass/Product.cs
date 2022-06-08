using System;

namespace CSClass
{
    class Product
    {
        public static int counter = 0;
        public string name = "no name";
        public int price = 1000;
        private int id = -1;

        public Product()
        {

        }

        public Product(string name, int price)
        {
            this.id = counter;
            counter = counter + 1; 
            this.name = name;
            this.price = price;
        }

        public override string ToString()
        {
            return "[" + this.id + "] " + this.name + " : " + this.price;
        }

        ~Product(){
            Console.WriteLine(this.name + "의 소멸자 호출");
        }
    }
}