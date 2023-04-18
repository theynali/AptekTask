using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AptekTask
{
    internal class Category
    {
        public static int _id;
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }
        public int CategoryCount { get; set; }

        public Category(string name)
        {
            _id++;
            CategoryCount++;
            CategoryId = _id;
            CategoryName = name;
        }
        public static void Delete(int id)
        {
            Context.Categories.Remove(Search(id));
        }
        public static void Update(int id)
        {
            Console.WriteLine($"Update etmek istediyiniz category: {Search(id).CategoryName}");
            Console.WriteLine("Yeni adi daxil edin: ");
            string newName = Console.ReadLine();
            Search(id).CategoryName = newName;
            Console.WriteLine($"Yeni category adi: {newName}");
        }
        public static Category Search(int id)
        {
            foreach (var item in Context.Categories)
            {
                if (item.CategoryId == id)
                {
                    return item;
                }
            }
            throw new NotFounException("Bele bir category yoxdur");
        }


    }
}
