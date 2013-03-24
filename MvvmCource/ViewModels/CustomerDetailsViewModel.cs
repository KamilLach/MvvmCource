using MvvmCource.Commands;
using MvvmCource.Core;
using MvvmCource.Models;

namespace MvvmCource.ViewModels
{
   public class CustomerDetailsViewModel : BaseViewModel
   {
      #region Fields

      private Customer m_currentCustomer;
      private CloseWindowCommand m_closeWindowCommandCommand;

      #endregion

      #region Properties

      public Customer CurrentCustomer
      {
         get { return m_currentCustomer; }
         set
         {
            m_currentCustomer = value;
            OnPropertyChanged("CurrentCustomer");
         }
      }

      public CloseWindowCommand CloseWindowCommandCommand
      {
         get { return m_closeWindowCommandCommand; }
         set
         {
            m_closeWindowCommandCommand = value;
            OnPropertyChanged("CloseWindowCommandCommand");
         }
      }

      #endregion

      public CustomerDetailsViewModel()
      {
         if (IsInDesignMode)
         {
            m_currentCustomer = new Customer
               {
                  FirstName = "Frank",
                  LastName = "Spolsky",
                  Age = 12,
                  Address = "BamBam !"
               };
         }
         else
         {
            m_currentCustomer = new Customer();
         }

         CloseWindowCommandCommand = new CloseWindowCommand();
      }

      public CustomerDetailsViewModel(Customer a_currentCustomer)
         : this()
      {
         m_currentCustomer = a_currentCustomer;
      }
   }
}