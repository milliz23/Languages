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
    /// Логика взаимодействия для UpdatPage.xaml
    /// </summary>
    public partial class UpdatPage : Page
    {
        string path;  
        Service Service; 
        bool flag;
        public UpdatPage()
        {
            InitializeComponent();
            flag = true;  
           
        }
        public UpdatPage(Service CatUpdate) 
        {
            InitializeComponent();
            Service = CatUpdate; 
            TBName.Text = CatUpdate.Title;
            TBCost.Text = Convert.ToString( CatUpdate.Cost);
            TBDis.Text= Convert.ToString(CatUpdate.Discount);
            if (path != null)  
            {
                BitmapImage BI = new BitmapImage(new Uri(path, UriKind.RelativeOrAbsolute));
                Image.Source = BI;
            }
        }


        private void Button_photo(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Service(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
