using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement
{
    class Program
    {
        static void Main(string[] args)
        {

            Mobile mobile = new Mobile();
            mobile.SetMobileData(1001, "X", "iphone", 78000, 12, "12MP", "Toughened glass");
            mobile.Display();

            Product p1 = new Mobile(1002, "8", "iphone", 48000, 8, "5MP", "Toughened glass");
            // Product p2 = new Refrigerator();
            // Product p3 = new AC();

            DisplayProduct(p1);
        }

        static void DisplayProduct(Product product)
        {
            if (product.GetType() == typeof(Mobile))
                ((Mobile)product).Display();
            //else if (product.GetType() == typeof(Refrigerator))
            //    ((Refrigerator)product).Display();
        }


    }
}