using System;
using System.Collections.Generic;
using System.IO;
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

namespace praktika14.Elements
{
    /// <summary>
    /// Логика взаимодействия для Item.xaml
    /// </summary>
    public partial class Item : UserControl
    {
        public Item(Classes.Item item)
        {
            InitializeComponent();

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
            }
        }
    }
}
