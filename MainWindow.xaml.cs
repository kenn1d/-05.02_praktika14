using System.Windows;
using System.Windows.Controls;

namespace praktika14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            OpenPage(new Pages.Main());
        }

        ///<summary>
        /// Функция лькрытия страниц
        /// </summary>
        /// <param name="page">страница которую необходимо открыть</param>
        public void OpenPage(Page page)
        {
            frame.Navigate(page);
        }
    }
}
