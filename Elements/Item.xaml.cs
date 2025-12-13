using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using praktika14.Pages;

namespace praktika14.Elements
{
    /// <summary>
    /// Логика взаимодействия для Item.xaml
    /// </summary>
    public partial class Item : UserControl
    {
        public Classes.Item item;
        public Item(Classes.Item item)
        {
            InitializeComponent();
            this.item = item;
            if(item != null)
            {
                // если файл существует
                if (File.Exists(Directory.GetCurrentDirectory() + "/Image/" + item.src))
                    // указывем файл
                    image.Source = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "/Image/" + item.src));
                else
                    //если файла нет, указываем изображение
                    image.Source = new BitmapImage(new Uri(System.IO.Directory.GetCurrentDirectory() + "/Image/placeholder.jpg"));

                // указываем цену
                price.Content = item.price;
                // указываем имя
                name.Content = item.name;
                // указываем количество
                totalCount.Text = item.count.ToString();
            }
        }

        private void GETDOWNMYWALLET(object sender, System.Windows.RoutedEventArgs e)
        {
            Classes.Basket.totalPrice -= item.price * item.count;
            item.selected = true;
            item.count = int.Parse(totalCount.Text);
            Classes.Basket.totalPrice += item.price * int.Parse(totalCount.Text);
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            if (mainWindow.frame.Content is Main mainPage)
            {
                mainPage.BasketUpdate();
            }
        }
    }
}
