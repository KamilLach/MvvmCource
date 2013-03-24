using System.Collections.ObjectModel;
using System.Windows.Input;
using MvvmCource.Commands;
using MvvmCource.Core;
using MvvmCource.Models;
using MvvmCource.Services;

namespace MvvmCource.ViewModels
{
   public class MainViewModel : BaseViewModel
   {
      #region Fields

      private readonly IModelLoader m_modelLoader;
      private ObservableCollection<Customer> m_customers;
      private OpenCustomerDetaisCommand m_customerDetailsCommand;

      #endregion

      #region Properties

      /// <summary>
      /// Customer Details command
      /// </summary>
      public OpenCustomerDetaisCommand CustomerDetailsCommand
      {
         get { return m_customerDetailsCommand; }
         set
         {
            m_customerDetailsCommand = value;
            OnPropertyChanged("CustomerDetailsCommand");
         }
      }

      /// <summary>
      /// Customer collection
      /// </summary>
      public ObservableCollection<Customer> Customers
      {
         get { return m_customers; }
         set
         {
            m_customers = value;
            OnPropertyChanged("Customers");
         }
      }

      #endregion


      public MainViewModel()
      {
         m_modelLoader = IsInDesignMode
            ? (IModelLoader)new DesignDataModelService()
            : new SampleModelLoaderService();

         Customers = m_modelLoader.LoadCustomers();
         CustomerDetailsCommand = new OpenCustomerDetaisCommand();
         CustomerDetailsCommand.AfterExecuted += a_customer =>
            {
               if (a_customer == null || Customers.Contains(a_customer))
               {
                  return;
               }

               Customers.Add(a_customer);
            };
      }
   }
}