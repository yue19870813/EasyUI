using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;


namespace EUI
{
    public class Property : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void _Init_()
        {
            AddChangeWatcher();
            OnInit();
        }

        public virtual void OnInit()
        {

        }

        private void AddChangeWatcher()
        {
            var t = this.GetType();
            var properties = t.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                var ooAtt = property.GetCustomAttribute<ObserveObjectAttribute>();
                if (ooAtt != null)
                {
                    var value = ((ObservableObject)property.GetValue(this));
                    value.PropertyChanged += (s, e) => {
                        InvokePropertyChanged(property.Name);
                    };
                    Debug.Log(property.Name + " --- " + ((ObservableObject)property.GetValue(this)));
                }
            }
        }

        protected void OnPropertyChanged<T>(ref T field, T value, [CallerMemberName]string propertyName = null) 
        {
            if (!EqualityComparer<T>.Default.Equals(field, value))
            {
                field = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        protected void InvokePropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
