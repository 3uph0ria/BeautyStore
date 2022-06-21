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
    /// Логика взаимодействия для PageCategories.xaml
    /// </summary>
    public partial class PageCategories : Page
    {
        public PageCategories()
        {
            InitializeComponent();
            DGridServices.ItemsSource = BeautyStoreEntities.GetContex().Categoris.ToList();
        }

        private void BtnAddService_Click(object sender, RoutedEventArgs e)
        {
            NavManager.AccountFrame.Navigate(new PageAddEditCategories(null));
        }

        private void BtnEditService_Click(object sender, RoutedEventArgs e)
        {
            NavManager.AccountFrame.Navigate(new PageAddEditCategories((sender as Button).DataContext as Categoris));
        }

        private void BtndelService_Click(object sender, RoutedEventArgs e)
        {
            Categoris currentServices = (sender as Button).DataContext as Categoris;
            if (MessageBox.Show("Вы действительно хотите удалить категорию " + currentServices.Name + "?", "", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                BeautyStoreEntities.GetContex().Categoris.Remove(currentServices);
                BeautyStoreEntities.GetContex().SaveChanges();
                NavManager.AccountFrame.Navigate(new PageCategories());
            }
        }
    }
}
