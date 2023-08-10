using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EUI
{
    public class ModelBase : Property
    {
        // public new void _Init_()
        // {
        //     base._Init_();
        //     // AddChangeWatcher();
        // }

        // private void AddChangeWatcher()
        // {
        //     var t = this.GetType();
        //     var properties = t.GetProperties();
        //     foreach (PropertyInfo property in properties)
        //     {
        //         var ooAtt = property.GetCustomAttribute<ObserveObjectAttribute>();
        //         if (ooAtt != null)
        //         {
        //             var value = ((ObservableObject)property.GetValue(this));
        //             value.PropertyChanged += (s, e) => {
        //                 InvokePropertyChanged(property.Name);
        //             };
        //             // Debug.Log(property.Name + " --- " + ((ObservableObject)property.GetValue(this)));
        //         }
        //     }
        // }
        protected new void OnPropertyChanged<T>(ref T field, T value, [CallerMemberName]string propertyName = null) 
        {
            base.OnPropertyChanged(ref field, value, propertyName);
            this.AddChangeWatcher();
        }
    }
}
