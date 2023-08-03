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
    public class ModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void _Init_()
        {
            OnInit();
        }

       
        public virtual void OnInit()
        {

        }

        protected void OnPropertyChanged<T>(ref T obj, T value, [CallerMemberName]string propertyName = null) 
        {
            if (obj == null || !obj.Equals(value))
            {
                obj = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
