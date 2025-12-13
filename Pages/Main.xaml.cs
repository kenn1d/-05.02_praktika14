using praktika14.Classes;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows;
using static System.Net.Mime.MediaTypeNames;

namespace praktika14.Pages
{
    /// <summary>
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Page
    {
        List<Classes.Item> AllItems;
        public Main(List<Classes.Item> items)
        {
            InitializeComponent();
            LoadItems(items);
            BasketUpdate();
        }

        /// <summary>Загрузка вещей</summary>
        public void LoadItems(List<Classes.Item> items)
        {
            parent.Children.Clear(); // очищаем parent

            foreach (Item item in items)
            {
                parent.Children.Add(new Elements.Item(item));
            }
        }

        private void getBack(object sender, System.Windows.RoutedEventArgs e)
        {
            MainWindow mainwindow = (MainWindow)System.Windows.Application.Current.MainWindow;
            mainwindow.OpenPage(MainWindow.pages.Categories);
        }

        public void BasketUpdate()
        {
            int totalPrice = Basket.totalPrice;
            basketPrice.Content = $"Корзина ({totalPrice})";
        }
    }
}
