using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
    /// Interaction logic for forgetpassword.xaml
    /// </summary>
    public partial class forgetpassword : Page
    {
        dataEntities db=new dataEntities();

        public forgetpassword()
        {
            InitializeComponent();
        }
       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           

            users_ n = db.users_.FirstOrDefault(x =>x.Phonenumber == int.Parse(phonetxtbox.Text));
           users_ pa=new users_();
            pa.password_user = newpasstextbox.Text;
            db.users_.AddOrUpdate(pa);
            db.SaveChanges();
           
        }

       
    }
}
