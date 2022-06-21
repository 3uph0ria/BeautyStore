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
    /// Логика взаимодействия для PageAddRditClientService.xaml
    /// </summary>
    public partial class PageAddRditClientService : Page
    {
        private ClientService _ccurrnetClientService = new ClientService();
        public PageAddRditClientService(ClientService selectClientService)
        {
            InitializeComponent();
            if (selectClientService != null)
            {
                _ccurrnetClientService = selectClientService;
                CBoxClient.SelectedItem = selectClientService.Clients;
                CBoxService.SelectedItem = selectClientService.Services;
            }
            CBoxClient.ItemsSource = BeautyStoreEntities.GetContex().Clients.ToList();
            CBoxService.ItemsSource = BeautyStoreEntities.GetContex().Services.ToList();
            DataContext = _ccurrnetClientService;
        }

        private void BtnAddClientservic_Click(object sender, RoutedEventArgs e)
        {

            Services p = (Services)CBoxService.SelectedItem;
            Clients o = (Clients)CBoxClient.SelectedItem;
            _ccurrnetClientService.IdService = p.Id;
            _ccurrnetClientService.IdClient = o.Id;

            

            try
            {
                if (_ccurrnetClientService.Id == 0)
                    BeautyStoreEntities.GetContex().ClientService.Add(_ccurrnetClientService);

                BeautyStoreEntities.GetContex().SaveChanges();
                MessageBox.Show("Запись успешно сохранена");
                NavManager.AccountFrame.Navigate(new PageClientService(NavManager.BtnClientService.Content + ""));
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
