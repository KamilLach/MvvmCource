using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MvvmCource.Views
{
   /// <summary>
   /// Interaction logic for CustomerListView.xaml
   /// </summary>
   public partial class CustomerListView : UserControl
   {
      public object SelectedItem
      {
         get { return GetValue(SelectedItemProperty); }
         set { SetValue(SelectedItemProperty, value); }
      }
      public IEnumerable ItemsSource
      {
         get { return (IEnumerable)GetValue(ItemsSourceProperty); }
         set { SetValue(ItemsSourceProperty, value); }
      }

      public static readonly DependencyProperty SelectedItemProperty =
          ListView.SelectedItemProperty.AddOwner(typeof(CustomerListView));

      public static readonly DependencyProperty ItemsSourceProperty =
         ListView.ItemsSourceProperty.AddOwner(typeof(CustomerListView));

      public CustomerListView()
      {
         InitializeComponent();
      }
   }
}
