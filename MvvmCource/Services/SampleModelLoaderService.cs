using System.Collections.Generic;
using System.Collections.ObjectModel;
using MvvmCource.Core;
using MvvmCource.Models;

namespace MvvmCource.Services
{
   /// <summary>
   /// Sample data service
   /// </summary>
   public class SampleModelLoaderService : IModelLoader
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
                     FirstName = "Mark",
                     LastName = "Spec",
                     Age = 22,
                     Address = "Flowers St. 7B"
                  },

                  new Customer
                  {
                     FirstName = "Vivian",
                     LastName = "Rosali",
                     Age = 29,
                     Address = "Benning Av. 18"
                  }
            });
      }
   }
}