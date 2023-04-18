using System.ComponentModel;

namespace AptekTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            string input = "";
            do
            {

                Console.WriteLine("Menyunu secin");
                Console.WriteLine("1.Category menu");
                Console.WriteLine("2.Medicine menu");
                Console.WriteLine("0.Exit");
                Console.Write("Secim edin:   ");
                input= Console.ReadLine();


                switch (input)
                {
                    case "1":MenuCategory();
                        break;
                        case "2":MenuMedicine();
                        break ;
                    default:
                        break;
                }
            } while (input !="0");
        }

        public static void MenuCategory()
        {

            string input = "";
            do
            {
                Console.WriteLine("1.Category Create");
                Console.WriteLine("2.Category Delete");
                Console.WriteLine("3.Category Update");
                Console.WriteLine("0.Exit");
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("Category adini daxil edin:  ");
                        string CategoryName=Console.ReadLine();
                        Category category=new Category(CategoryName);
                        Context.Categories.Add(category);
                        Console.WriteLine($" Category yaradildi! Name: {CategoryName} Id: {category.CategoryId}");
                        break;
                    case "2":
                        if (Context.Categories.Count>0)
                        {
                            Console.WriteLine("Silmek istediyiniz catogorynin Id-si:  ");
                            int CategoryId = int.Parse(Console.ReadLine());
                            Category.Delete(CategoryId);
                            Console.WriteLine("Category silindi!");
                        }
                        else
                        {
                            Console.WriteLine("Category movcud deyil!");
                        }
                        
                        break;
                    case "3":
                        if (Context.Categories.Count > 0)
                        {
                            Console.WriteLine("Deyismek istediyiniz category Id-si:  ");
                            int NewName = int.Parse(Console.ReadLine());
                            Category.Update(NewName);
                        }
                        else
                        {
                            Console.WriteLine("Category movcud deyil!");
                        }
                        
                        break;
                    default:
                        break;
                }
            } while (input !="0");
        }
        public static void MenuMedicine()
        {
            string input = "";
            do
            {
                Console.WriteLine("1.Medicine Create");
                Console.WriteLine("2.Medicine Delete");
                Console.WriteLine("3.Medicine Update");
                Console.WriteLine("4.Medicine Sale");
                Console.WriteLine("0.Exit");
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        if (Context.Categories.Count==0)
                        {
                            Console.WriteLine("Category olmadan derman yaradila bilmez!");
                            break;
                        }
                       
                        Console.WriteLine("Dermanin adini daxil edin:  ");
                        string medicineName = Console.ReadLine();
                        Console.WriteLine("Dermanin qiymetini daxil edin:  ");
                        double medicinePrice = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Dermanin sayini daxil edin:  ");
                        int medicineCount=int.Parse(Console.ReadLine());
                        Medicine medicine = new Medicine(medicineName,medicinePrice,medicineCount);
                        Context.Medicines.Add(medicine);
                        foreach (var item in Context.Medicines)
                        {
                            Console.WriteLine($"Derman elave olundu!  Name: {item.MedicineName}  Price: {item.Price} Count: {item.MedicineCount}  Id: {item.MedicineId}");

                        }

                        break;
                        case "2":
                        if (Context.Medicines.Count>0)
                        {
                            Console.WriteLine("Silmek istediyinin dermanin Id-si:  ");
                            int MedicineId = int.Parse(Console.ReadLine());
                            Medicine.Delete(MedicineId);
                            Console.WriteLine("Derman silindi!");
                        }
                        else
                        {
                            Console.WriteLine("Derman movcud deyil!");
                        }
                            break;
                    case "3":
                        if (Context.Medicines.Count > 0)
                        {
                            Console.Write("Derman Idsini daxil edin: ");
                            int NewMedicine = int.Parse(Console.ReadLine());
                            Category.Update(NewMedicine);
                            Console.WriteLine("Derman update edildi!");
                        }
                        else
                        {
                            Console.WriteLine("Derman movcud deyil!");
                        }
                        
                        break;
                    case "4":
                        if (Context.Medicines.Count > 0)
                        {
                            foreach (var item in Context.Medicines)
                            {
                                Console.WriteLine($"Dermanin adi: {item.MedicineName} id: {item.MedicineId} sayi: {item.MedicineCount}");
                            }
                            Console.Write("Satilacaq mehsulun Id-si:   ");
                            int saledId = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ne qeder mehsul satilacaq:  ");
                            int SaleCount= int.Parse(Console.ReadLine());
                            Medicine.Sale(saledId,SaleCount);
                        }
                        else
                        {
                            Console.WriteLine("Mehsul sayi kifayet deyil!");
                            Console.WriteLine($"Mehsul sayi: {Context.Medicines.Count}");
                        }

                        break;
                    default:
                        break;
                }

            } while (input !="0");
        }
    }
}