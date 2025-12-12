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
            items.Add(new Item("Шкаф", 20000, "71euhy8b67gmcyp20f9qj8q7ytmvz8i1.jpg"));
            items.Add(new Item("Диван", 12000, "4488921.jpg"));
            items.Add(new Item("Кресло-диван", 15000, "1732024351652-800x600.jpg"));
            items.Add(new Item("Пуфик", 6000, "product_modal_cover_d133a33f-cea6-4472-9670-bf9ff8a270c0.jpg"));
            items.Add(new Item("Комод", 11000, "fe9db6540f2fd063f36b6e4d89be8720.jpg"));
            items.Add(new Item("Книжная полка", 20000, "denver-grafit-knizhnaya-polka-sv-mebel-krasnodar.jpg"));
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
