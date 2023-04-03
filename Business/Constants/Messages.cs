using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{   
    //static : new leme gereği duymaz.
    //public Pascal case yazılır.
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün isimi geçersiz";
        internal static string MaintenanceTime = "Sistem bakımda";
        internal static string ProductsListed = "Ürünler listelendi";
    }
}
