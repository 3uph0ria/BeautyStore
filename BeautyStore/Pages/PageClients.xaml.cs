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
    /// Логика взаимодействия для PageClients.xaml
    /// </summary>
    public partial class PageClients : Page
    {
        public PageClients(string header)
        {
            InitializeComponent();
            Header.Text = header;
            DGridClients.ItemsSource = BeautyStoreEntities.GetContex().Clients.ToList();
        }

        private void BtnEditClient_Click(object sender, RoutedEventArgs e)
        {
            NavManager.AccountFrame.Navigate(new PageAddEditClients((sender as Button).DataContext as Clients));
        }

        private void BtnAddClient_Click(object sender, RoutedEventArgs e)
        {
            NavManager.AccountFrame.Navigate(new PageAddEditClients(null));
        }

        private void BtndelClient_Click(object sender, RoutedEventArgs e)
        {
            Clients currentClients = (sender as Button).DataContext as Clients;
            if (MessageBox.Show("Вы действительно хотите удалить клиента " + currentClients.Fullname + "?", "", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                BeautyStoreEntities.GetContex().Clients.Remove(currentClients);
                BeautyStoreEntities.GetContex().SaveChanges();
                NavManager.AccountFrame.Navigate(new PageServices(NavManager.BtnServices.Content + ""));
            }
        }
    }
}
