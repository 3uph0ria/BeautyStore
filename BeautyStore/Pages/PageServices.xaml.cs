using BeautyStore.Classes;
using BeautyStore.Models;
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

namespace BeautyStore.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageServices.xaml
    /// </summary>
    public partial class PageServices : Page
    {
        public PageServices(string header)
        {
            InitializeComponent();
            DGridServices.ItemsSource = BeautyStoreEntities.GetContex().Services.ToList();
            Header.Text = header;
        }

        private void BtnEditService_Click(object sender, RoutedEventArgs e)
        {
            NavManager.AccountFrame.Navigate(new PageAddEditService((sender as Button).DataContext as Services));
        }

        private void BtnAddService_Click(object sender, RoutedEventArgs e)
        {
            NavManager.AccountFrame.Navigate(new PageAddEditService(null));
        }

        private void BtndelService_Click(object sender, RoutedEventArgs e)
        {
            Services currentServices = (sender as Button).DataContext as Services;
            if (MessageBox.Show("Вы действительно хотите удалить услугу " + currentServices.Name + "?", "", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                BeautyStoreEntities.GetContex().Services.Remove(currentServices);
                BeautyStoreEntities.GetContex().SaveChanges();
                NavManager.AccountFrame.Navigate(new PageServices(NavManager.BtnServices.Content + ""));
            }
        }
    }
}
