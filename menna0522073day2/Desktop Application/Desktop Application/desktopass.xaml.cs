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
    /// Interaction logic for profile.xaml
    /// </summary>
    public partial class profile : Page
    {
        dataEntities db=new dataEntities();
        public profile(string name)
        {
            InitializeComponent();
            dg.ItemsSource=db.users_.Where(x=>x.username==name).ToList();
            lable.Content ="profil "+name;
        }
       

       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            login nn = new login();
            this.NavigationService.Navigate(nn);
        }
    }
}
