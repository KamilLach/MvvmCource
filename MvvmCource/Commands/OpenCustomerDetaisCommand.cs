using System;
using System.Windows.Input;
using MvvmCource.Models;
using MvvmCource.ViewModels;
using MvvmCource.Views;

namespace MvvmCource.Commands
{
   /// <summary>
   /// Opend new details window
   /// </summary>
   public class OpenCustomerDetaisCommand : ICommand
   {
      /// <summary>
      /// Action fire after command exetutes
      /// </summary>
      public Action<Customer> AfterExecuted { get; set; }

      public void Execute(object a_parameter)
      {
         Customer customer = a_parameter as Customer;
         CustomerDetailsViewModel viewModel = customer != null
                                                 ? new CustomerDetailsViewModel(customer)
                                                 : new CustomerDetailsViewModel();
         CustomerDetailsView editView = new CustomerDetailsView
            {
               DataContext = viewModel
            };

         editView.ShowDialog();
         if (AfterExecuted != null)
         {
            AfterExecuted.Invoke(viewModel.CurrentCustomer);
         }
      }

      public bool CanExecute(object a_parameter)
      {
         return true;
      }

      public event EventHandler CanExecuteChanged;
   }
}