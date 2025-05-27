using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyExem
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box(100, 200);
            Console.WriteLine(box.Area());
        }
    }
}
