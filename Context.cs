using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AptekTask
{
    internal  class Context
    {
        public static List<Medicine> Medicines = new List<Medicine>();
        
     
        
        public static List<Category> Categories = new List<Category>();


        public static void AddMedicine(Medicine medicine)
        {
            Medicines.Add(medicine);
        }
        public static void AddCategory(Category category)
        {
            Categories.Add(category);   
        }
    }
    
}
