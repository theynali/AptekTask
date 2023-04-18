using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AptekTask
{
    internal class Category
    {
        public int _id;
        public int CategoryId { get; set; }

        public string Name { get; set; }

        public Category(string name)
        {
            Name = name;
            CategoryId = _id;
        }
      public static void Delete(int id)
      {
       Context.Categories.Remove(Search(id));
      }
        public static void Update(int id)
        {
            Console.WriteLine($"Silmek istediyiniz Category secin: {Search(id).Name} ");
            Console.WriteLine("New Category teyin edin");
            string newName=Console.ReadLine();
            Search(id).Name = newName;
        }

        public static Category Search(int id)
        {
            foreach (var item in Context.Categories)
            {
                if (item._id==id)
                {
                    return item;
                }
            }
            throw new NotFounException("Bele Category yoxdu!");
        }
    }
}
