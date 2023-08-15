using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EUI
{
    public class ObservableObject : Property
    {
        // public new void _Init_()
        // {
        //     AddValueChangeWatcher();
        //     base._Init_();
        // }

        // protected new void OnPropertyChanged<T>(ref T field, T value, [CallerMemberName]string propertyName = null) 
        // {
        //     base.OnPropertyChanged(ref field, value, propertyName);
            
        // }

        // protected void AddValueChangeWatcher()
        // {
        //     var t = this.GetType();
        //     var properties = t.GetProperties();
        //     foreach (PropertyInfo property in properties)
        //     {
        //         var ooAtt = property.GetCustomAttribute<ObserveObjectAttribute>();
        //         if (ooAtt != null)
        //         {
                    
        //             // Debug.Log("===AddChangeWatcher:" + property.Name + " ---- " + ((ObservableObject)property.GetValue(this)));
        //         }
        //     }
        // }

        // protected ModelBase mModel;

        // protected event PropertyChangedEventHandler MPropertyChanged;

        
    }
}