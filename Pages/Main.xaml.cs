using praktika14.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace praktika14.Pages
{
    /// <summary>
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Page
    {
        public List<Item> items = new List<Item>();

        public Main()
        {
            InitializeComponent();
            // Добавляем элемент в коллекцию
            items.Add(new Item("Шкаф", 20000, "Images/71euhy8b67gmcyp20f9qj8q7ytmvz8i1.jpg"));
            // вызываем метод генерации интерфейса
            LoadItems();
        }

        /// <summary>Загрузка вещей</summary>
        public void LoadItems()
        {
            parent.Children.Clear(); // очищаем parent

            foreach (Item item in items)
            {
                parent.Children.Add(new Elements.Item(item));
            }
        }
    }
}
