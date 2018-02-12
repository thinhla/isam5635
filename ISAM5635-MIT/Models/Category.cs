

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISAM5635_MIT.Models
{
    public class Category
    {
        
        public string Category_Type { get; set; }
        //compact/mid-size/full-size/van/suv
        public int Amount { get; set; }

        public Category(string category_type, int amount)
        {
            Category_Type = category_type;
            Amount = amount;
        }

        public static Category[] GetCategory()
        {
            Category economy = new Category("Economy", 22);
            Category compact = new Category("Compact", 23);
            Category intermediate = new Category("Intermediate", 24);
            Category standard = new Category("Standard", 25);
            Category fullsize = new Category("Fullsize", 26);
            Category compactSuv = new Category("Compact SUV", 27);
            Category intermediateSuv = new Category("Intermediate SUV", 28);
            Category premium = new Category("Premium", 29);
            Category luxury = new Category("Luxury", 30);
            Category convertible = new Category("Convertible", 31);
            return new Category[] { economy, compact, intermediate, standard, fullsize, compactSuv, intermediateSuv, premium, luxury, convertible };
        }
    }
}
