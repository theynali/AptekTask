using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AptekTask
{
    internal class Medicine
    {
        public static int _id;
        public int MedicineId { get; set; }
        public string MedicineName { get; set; }
        public double Price { get; set; }
        public int MedicineCount { get; set; }
        public int SaleCount;


        public Medicine(string name, double price, int count)
        {
            _id++;
            MedicineId = _id;
            MedicineName = name;
            Price = price;
            MedicineCount = count;
            

        }
        public static void Delete(int id)
        {
            Context.Medicines.Remove(Search(id));
        }
        public static void Update(int id)
        {
            Console.WriteLine($"Update etmek istediyiniz Medicine: {Search(id).MedicineName}");
            Console.Write("Yeni adi daxil edin: ");
            string newName = Console.ReadLine();
            Search(id).MedicineName = newName;
        }
        public static Medicine Search(int id)
        {
            foreach (var item in Context.Medicines)
            {
                if (item.MedicineId == id)
                {
                    return item;
                }
            }
            throw new NotFounException("Bele bir Derman Movcud deyil!");
        }
        public static void Sale(int id, int SaleCount)
        {
            Medicine saledMedicine = Search(id);
            
            if (Context.Medicines.Count > 0 && Context.Medicines.Count<=SaleCount)
            {
                Console.WriteLine("Satis heyata kecirildi!");
            }
            else
            {
                Console.WriteLine("Kifayet qeder mehsul yoxdur!");
            }

        }
    }
}
