using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyExem
{
    class Item
    {
        private static int count;
        public readonly int Id = -1;
        public string name;
        public int price;

        public Item(string name, int price)
        {
            Id = count++;
            this.name = name;
            this.price = price;
        }
    }
}
