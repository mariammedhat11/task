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
    /// Interaction logic for signup.xaml
    /// </summary>
    public partial class signup : Page
    {
        dataEntities db=new dataEntities();
        public signup()
        {
            InitializeComponent();
        }
        public bool isvaild(string pass)
        {
            bool upper, lower, num, sempioy;
            upper = lower = num = sempioy = false;
            string spactial = "!@#$%&";
            foreach (char c in pass)
            {
                if(c>='A' && c <= 'Z')
                {
                    upper = true;
                }
                else if(c>='a' && c <= 'z')
                {
                    lower = true;
                }
                else if(c>='0'&&c <= '9')
                {
                    num = true;
                }
                else if(spactial.Contains(c))
                {
                    sempioy=true;
                }
            }
            return upper &&lower&&num&&sempioy;

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            int ages = int.Parse(agetextbox.Text);
            {
                if (isvaild(p_txt.Text))
                {
                    if (ages >= 16 && ages <= 60)
                    {
                        if (numtextbox.MaxLength == 11)
                        {
                            users_ m = new users_();
                            m.username = usernametextbox.Text;
                            m.Age = int.Parse(agetextbox.Text);
                            m.password_user = p_txt.Text;
                            m.Gender = combo_txt.Text;
                            m.Phonenumber = int.Parse(numtextbox.Text);
                            m.City = c_txt.Text;
                            db.users_.Add(m);
                            db.SaveChanges();   
                        }

                    }
                    
                }
                
            }


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            users_ page = new users_();
            this.NavigationService.Navigate(page);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            login x = new login();
            this.NavigationService.Navigate(x);
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
