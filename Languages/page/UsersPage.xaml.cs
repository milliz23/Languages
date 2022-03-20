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

namespace Languages.page
{
    /// <summary>
    /// Логика взаимодействия для UsersPage.xaml
    /// </summary>
    public partial class UsersPage : Page
    {
        public UsersPage()
        {
            InitializeComponent();
            LVService.ItemsSource = BaseClass.Base.Service.ToList();
        }

        private void TextBlock_Cost(object sender, RoutedEventArgs e)
        {
            TextBlock tb = (TextBlock)sender;
            int index = Convert.ToInt32(tb.Uid);
            List<Service> TC = BaseClass.Base.Service.Where(x => x.ID == index).ToList();
            string str = "";
            foreach (Service item in TC)
            {
                if (item.Discount != 0)
                {

                    int cs = Convert.ToInt32(item.Cost) - Convert.ToInt32(Convert.ToDouble(item.Cost) * Convert.ToDouble(item.Discount));
                    str += cs;
                }
                else
                {
                    int cs = Convert.ToInt32(item.Cost);
                    str += cs;
                }
            }
            tb.Text = str.Substring(0) + " руб";
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            FrameClass.FrameMain.Navigate(new MainWindow());
        }
    }
}
