using System;

namespace CSClass
{
    public class Box
    {
        public int foo { get; set; }

        private int width;

        public int Width
        {
            get { return width; }
            set { 
                    if (value > 0) {
                    
                        width = value;
                    }
                    else
                    {
                        Console.WriteLine("Box의 가로는 양수여야 합니다.");
                    }
                }
        }

        private int height;

        public int Height
        {
            get { return height; }
            set {
                    if (value > 0)
                    {
                        height = value;
                    }
                    else
                    {
                        Console.WriteLine("Box의 세로는 양수여야 합니다.");
                    }
            } 
        }
        public Box(int w, int h)
        {
            this.Width = w;
            this.Height = h;
        }

        private int area;

        public int Area
        {
            get { return this.Width * this.Height; }
        }
    }
}