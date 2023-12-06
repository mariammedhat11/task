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

namespace Desktop_Application
{
    /// <summary>
    /// Interaction logic for searchadmin.xaml
    /// </summary>
    public partial class searchadmin : Page
    {
        dataEntities db=new dataEntities(); 
        public searchadmin()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            dg.ItemsSource=db.users_.Where(x=>x.City.Contains(deletcity.Text)).ToList();
            this.DataContext =dg;
        }

       
    }
}
