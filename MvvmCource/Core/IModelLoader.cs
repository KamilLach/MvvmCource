using System.Collections.ObjectModel;
using MvvmCource.Models;

namespace MvvmCource.Core
{
   /// <summary>
   /// Loads model data
   /// </summary>
   public interface IModelLoader
   {
      /// <summary>
      /// Loads customer data
      /// </summary>
      /// <returns>Obserbale collection of customers</returns>
      ObservableCollection<Customer> LoadCustomers();
   }
}