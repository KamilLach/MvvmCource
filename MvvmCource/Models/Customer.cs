using System.ComponentModel;

namespace MvvmCource.Models
{
   public class Customer : INotifyPropertyChanged
   {
      #region Fields

      private string m_firstName;
      private string m_lastName;
      private int m_age;
      private string m_address;

      #endregion

      #region Properties

      public string FirstName
      {
         get { return m_firstName; }

         set
         {
            if (value == m_firstName) return;
            m_firstName = value;
            OnPropertyChanged("FirstName");
         }
      }

      public string LastName
      {
         get { return m_lastName; }

         set
         {
            if (value == m_lastName) return;
            m_lastName = value;
            OnPropertyChanged("LastName");
         }
      }

      public int Age
      {
         get { return m_age; }

         set
         {
            if (value == m_age) return;
            m_age = value;
            OnPropertyChanged("Age");
         }
      }

      public string Address
      {
         get { return m_address; }

         set
         {
            if (value == m_address) return;
            m_address = value;
            OnPropertyChanged("Address");
         }
      }

      #endregion


      #region Events

      public event PropertyChangedEventHandler PropertyChanged;

      #endregion

      #region Events Invocator

      protected virtual void OnPropertyChanged(string a_propertyName)
      {
         PropertyChangedEventHandler handler = PropertyChanged;
         if (handler != null)
         {
            handler(this, new PropertyChangedEventArgs(a_propertyName));
         }
      }

      #endregion
   }
}