using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyExem
{
    class Box
    {
        private int width;
        private int height;

        public int Width
        {
            get { return width; }
            set
            {
                if (value > 0) { width = value; }
                else { Console.WriteLine("너비는 자연수로 입력해주세요."); }
            }
        }

        public int Height
        {
            get { return height; }
            set
            {
                if (value > 0) { height = value; }
                else { Console.WriteLine("높이는 자연수로 입력해주세요."); }
            }
        }

        public Box(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int Area
        {
            get { return Width * Height; }
        }
    }
}
