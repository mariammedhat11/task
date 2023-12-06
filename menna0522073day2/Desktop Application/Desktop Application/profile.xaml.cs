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
        public profile()
        {
            InitializeComponent();
        }
        user_ cc = new user_();

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            user_ cc = DataGrid.SelectedItem as user_;
            if (cc != null)
            {
                MessageBox.Show("false data");
            }
            else
            {
               DataGrid.SelectedItem = null;

            }
            this.NavigationService.Navigate(cc);
        }
    }
}
