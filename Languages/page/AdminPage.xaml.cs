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
    /// Логика взаимодействия для AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Page
    {
        public AdminPage()
        {
            InitializeComponent();
            LVService.ItemsSource = BaseClass.Base.Service.ToList();
        }

        private void TBCost(object sender, RoutedEventArgs e)
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
            tb.Text =  str.Substring(0) + " руб";
        }

        private void Button_Delite(object sender, RoutedEventArgs e)
        {
            Button B = (Button)sender; 
            int ind = Convert.ToInt32(B.Uid); 
            Service ServiceDelete = BaseClass.Base.Service.FirstOrDefault(y => y.ID == ind); 
            BaseClass.Base.Service.Remove(ServiceDelete);  
            BaseClass.Base.SaveChanges();
            FrameClass.FrameMain.Navigate(new AdminPage());  
            MessageBox.Show("Запись удалена");
        }

     

        private void Back(object sender, RoutedEventArgs e)
        {
            FrameClass.FrameMain.Navigate(new MainWindow());
        }

        private void NewApp_Click(object sender, RoutedEventArgs e)
        {
            Button B = (Button)sender;
            int id = Convert.ToInt32(B.Uid);
            Service NewReg = BaseClass.Base.Service.FirstOrDefault(x => x.ID == id);
            FrameClass.FrameMain.Navigate(new Page1(NewReg));
        }

        private void btnShowEntries_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.FrameMain.Navigate(new UpcomingEntries());
        }
    }

}
