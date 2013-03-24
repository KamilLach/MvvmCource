using System;
using System.Windows;
using System.Windows.Input;
using MvvmCource.Models;
using MvvmCource.ViewModels;
using MvvmCource.Views;

namespace MvvmCource.Commands
{
   /// <summary>
   /// Opend new details window
   /// </summary>
   public class CloseWindowCommand : ICommand
   {
      public void Execute(object a_parameter)
      {
         Window window = a_parameter as Window;
         if (window == null)
         {
            return;
         }

         window.Close();
      }

      public bool CanExecute(object a_parameter)
      {
         return a_parameter is Window;
      }

      public event EventHandler CanExecuteChanged;
   }
}