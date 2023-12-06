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
    /// Interaction logic for delet.xaml
    /// </summary>
    public partial class delet : Page
    {
        dataEntities db=new dataEntities();
        public delet()
        {
            InitializeComponent();
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           users_ b=new users_();
            b = db.users_.FirstOrDefault(x => x.Phonenumber == int.Parse(phonenumbertxt.Text));
            if(b != null )
            {
                db.users_.Remove(b);
                db.SaveChanges();
            }
        }
    }
}
