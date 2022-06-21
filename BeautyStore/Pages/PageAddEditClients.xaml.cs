using BeautyStore.Models;
using BeautyStore.Classes;
using BeautyStore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
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
    /// Логика взаимодействия для PageAddEditClients.xaml
    /// </summary>
    public partial class PageAddEditClients : Page
    {
        private Clients _ccurrnetClients = new Clients();
        public PageAddEditClients(Clients selectClient)
        {
            InitializeComponent();
            if (selectClient != null)
                _ccurrnetClients = selectClient;
            DataContext = _ccurrnetClients;
        }

        private void BtnAddEditClients_Click(object sender, RoutedEventArgs e)
        {
            if (_ccurrnetClients.Id == 0)
                BeautyStoreEntities.GetContex().Clients.Add(_ccurrnetClients);

            try
            {
                BeautyStoreEntities.GetContex().SaveChanges();
                MessageBox.Show("Клиент успешно сохранен");
                NavManager.AccountFrame.Navigate(new PageClients(NavManager.BtClients.Content + ""));
            }
            catch (DbEntityValidationException ex)
            {
                if (ApplicationConfig.IsDev)
                {
                    foreach (var errors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in errors.ValidationErrors)
                        {
                            MessageBox.Show(validationError.ErrorMessage);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Произошла ошибка", "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
        }
    }
}
