using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace praktika14.Classes
{
    public class Basket
    {
        public static List<Item> AllItems { get; set; } = new List<Item>();
        public static int totalPrice = 0;
    }
}
