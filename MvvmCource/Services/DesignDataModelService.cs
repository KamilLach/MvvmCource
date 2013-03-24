using System.Collections.Generic;
using System.Collections.ObjectModel;
using MvvmCource.Core;
using MvvmCource.Models;

namespace MvvmCource.Services
{
   /// <summary>
   /// Sample data service
   /// </summary>
   public class DesignDataModelService : IModelLoader
   {
      /// <summary>
      /// Loads customer data
      /// </summary>
      /// <returns>Obserbale collection of customers</returns>
      public ObservableCollection<Customer> LoadCustomers()
      {
         return new ObservableCollection<Customer>(new List<Customer>
            {
               new Customer
                  {
                     FirstName = "John",
                     LastName = "Doe",
                     Age = 22,
                     Address = "Unknown"
                  }
            });
      }
   }
}