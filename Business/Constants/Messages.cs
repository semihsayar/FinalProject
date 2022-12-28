using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    // Constants = Sabit

    // Sabit olduğu için static
    // newlenmeye gerek yoktur
    public static class Messages
    {
        // Public - PascalCase
        public static string ProductAdded = "Ürün Eklendi";
        // Ürün ismi geçersiz
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string ProductListed = "Ürünler Listelendi";
    }
}
