namespace CSClass
{
    class Product
    {
        public string name = "no name";
        public int price = 1000;

        public override string ToString()
        {
            return this.name + " : " + this.price;
        }
    }
}