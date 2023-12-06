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
    /// Interaction logic for login.xaml
    /// </summary>
    public partial class login : Page
    {
        dataEntities db=new dataEntities();

        public login()
        {
            InitializeComponent();
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            users_ ad = db.users_.FirstOrDefault(x => x.username == usertextbox.Text);

            if (ad.password_user == pass_txt.Text) 
            {
                string name = usertextbox.Text;
                users_ page = new users_(name);

                this.NavigationService.Navigate(page);

            }
            else
            {
                MessageBox.Show("incorrect username or password");
            }
        }
        private class forgetpassowrd
        {
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            forgetpassowrd page = new forgetpassowrd();
            this.NavigationService.Navigate(page);
        }
       

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            signup page = new signup();
            this.NavigationService.Navigate(page);
        }
    }
}
