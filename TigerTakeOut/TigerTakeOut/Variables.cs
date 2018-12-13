using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TigerTakeOut
{
    class Variables
    {
        //global lists that will hold the names and prices of each food item
        public static List<string> names = new List<string>();
        public static List<double> prices = new List<double>();

        //global lists for updating text in checkout and tracking
        public static List<string> items = new List<string>();
        public static List<double> costs = new List<double>();

        //global variables for subtotal and total
        public static double subTotal = 0;
        public static double total = 0;

    }
}
