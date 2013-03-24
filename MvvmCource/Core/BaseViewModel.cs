using System.ComponentModel;
using System.Windows;

namespace MvvmCource.Core
{
   public class BaseViewModel : INotifyPropertyChanged
   {
      protected bool IsInDesignMode
      {
         get
         {
            return (bool)DesignerProperties.IsInDesignModeProperty
                .GetMetadata(typeof(DependencyObject)).DefaultValue;
         }
      }

      public event PropertyChangedEventHandler PropertyChanged;

      protected virtual void OnPropertyChanged(string a_propertyName)
      {
         PropertyChangedEventHandler handler = PropertyChanged;
         if (handler != null)
         {
            handler(this, new PropertyChangedEventArgs(a_propertyName));
         }
      }
   }
}