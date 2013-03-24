using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using MvvmCource.Core;
using MvvmCource.Models;
using MvvmCource.Services;

namespace MvvmCource.ViewModels
{
   public class CustomerListViewModel : BaseViewModel
   {
      #region Fields

      private readonly IModelLoader m_modelLoader;
      private ObservableCollection<Customer> m_customers;

      #endregion

      public ObservableCollection<Customer> Customers
      {
         get { return m_customers; }
         set
         {
            m_customers = value;
            OnPropertyChanged("Customers");
         }
      }

      public CustomerListViewModel()
      {
         m_modelLoader = IsInDesignMode 
            ? (IModelLoader) new DesignDataModelService() 
            : new SampleModelLoaderService();

         Customers = m_modelLoader.LoadCustomers();
      }
   }
}