using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AptekTask
{
    internal class Medicine
    {
        public int _id;
        public int CatagoryId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }


        public Medicine(string name, double price , int count)
        {
            CatagoryId = _id;
            Name = name;
            Price = price;
            Count = count;

        }
    }
}
