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
    /// Логика взаимодействия для PageAddEditCategories.xaml
    /// </summary>
    public partial class PageAddEditCategories : Page
    {
        private Categoris _ccurrnetServices = new Categoris();
        public PageAddEditCategories(Categoris selectService)
        {
            InitializeComponent();
            if (selectService != null)
            {
                _ccurrnetServices = selectService;
            }

            DataContext = _ccurrnetServices;
        }

        private void BtnAddservice_Click(object sender, RoutedEventArgs e)
        {
            if (_ccurrnetServices.Id == 0)
                BeautyStoreEntities.GetContex().Categoris.Add(_ccurrnetServices);

            try
            {
                BeautyStoreEntities.GetContex().SaveChanges();
                MessageBox.Show("Товар успешно сохранен");
                NavManager.AccountFrame.Navigate(new PageCategories());
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
