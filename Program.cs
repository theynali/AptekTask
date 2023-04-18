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
                Console.WriteLine("1.Category menyu");
                Console.WriteLine("2.Derman menyusu");
                Console.WriteLine("0.Exit");
                Console.Write("Secim edin:   ");
                input= Console.ReadLine();


                switch (input)
                {
                    case "1":Menu();
                        break;
                        case "2":MenuDerman();
                        break ;
                    default:
                        break;
                }
            } while (input !="0");
        }

        public static void Menu()
        {

            string input = "";
            do
            {
                Console.WriteLine("1.Create");
                Console.WriteLine("2.Delete");
                Console.WriteLine("3.Update");
                Console.WriteLine("0.Exit");
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("Category adini daxil edin:  ");
                        string CategoryName=Console.ReadLine();
                        Category category=new Category(CategoryName);
                        Context.AddCategory(category);
                        break;
                    case "2":Category.Delete(4);
                        break;
                    case "3":Category.Update(5);
                        break;
                    default:
                        break;
                }
            } while (input !="0");
        }
        public static void MenuDerman()
        {
            string input = "";
            do
            {
                Console.WriteLine("1.Create");
                Console.WriteLine("2.Delete");
                Console.WriteLine("3.Update");
                Console.WriteLine("0.Exit");
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("Dermanin adini daxil edin:  ");
                        string medicineName = Console.ReadLine();
                        Console.WriteLine("Dermanin qiymetini daxil edin:  ");
                        double medicinePrice = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Dermanin sayini daxil edin:  ");
                        int medicineCount=int.Parse(Console.ReadLine());
                        Console.WriteLine("Derman elave olundu!");
                        Medicine medicine = new Medicine(medicineName,medicinePrice,medicineCount);
                        Context.AddMedicine(medicine);
                        break ;
                        case "2":
                            break;
                    case "3":
                        break;
                    default:
                        break;
                }

            } while (input !="0");
        }
    }
}