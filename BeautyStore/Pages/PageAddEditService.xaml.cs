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
    public partial class PageAddEditService : Page
    {
        private Services _ccurrnetServices = new Services();
        public PageAddEditService(Services selectService)
        {
            InitializeComponent();
            if (selectService != null)
            {
                _ccurrnetServices = selectService;
                CBoxCategory.SelectedItem = _ccurrnetServices.Categoris;
                CBoxCustomer.SelectedItem = _ccurrnetServices.Customers;

            }

            CBoxCategory.ItemsSource = BeautyStoreEntities.GetContex().Categoris.ToList();
            CBoxCustomer.ItemsSource = BeautyStoreEntities.GetContex().Customers.ToList();

            DataContext = _ccurrnetServices;
        }

        private void BtnAddservice_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors1 = new StringBuilder();

            if (Convert.ToInt32(Cost.Text) < 0)
                errors1.AppendLine("Цена не может быть меньше 0");
            else if(Convert.ToInt32(Amount.Text) < 0)
                errors1.AppendLine("Кол-во на складе не может быть меньше 0");

            if (errors1.Length > 0)
            {
                MessageBox.Show(errors1.ToString());
                return;
            }

            Categoris ca = (Categoris)CBoxCategory.SelectedItem;
            Customers cu = (Customers)CBoxCustomer.SelectedItem;
            _ccurrnetServices.IdCategory = ca.Id;
            _ccurrnetServices.IdCustomer = cu.Id;


            if (_ccurrnetServices.Id == 0)
                BeautyStoreEntities.GetContex().Services.Add(_ccurrnetServices);

            try
            {
                BeautyStoreEntities.GetContex().SaveChanges();
                MessageBox.Show("Товар успешно сохранен");
                NavManager.AccountFrame.Navigate(new PageServices(NavManager.BtnServices.Content + ""));
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
