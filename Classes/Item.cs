using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace praktika14.Classes
{
    public class Item
    {
        ///<summary>Наименование</summary>
        public string name {  get; set; }
        ///<summary>Цена</summary>
        public int price {  get; set; }
        ///<summay>Ссылка</summay>
        public string src { get; set; }
        public bool selected = false;
        public int count { get; set; }

        public Item(string name, int price, string src)
        {
            this.name = name;
            this.price = price;
            this.src = src;
        }

        public Item(string name, int price, string src, int count)
        {
            this.name = name;
            this.price = price;
            this.src = src;
            this.count = count;
        }
    }
}
