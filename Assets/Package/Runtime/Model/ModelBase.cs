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

        protected new bool OnPropertyChanged<T>(ref T field, T value, [CallerMemberName]string propertyName = null) 
        {
            var flag = base.OnPropertyChanged(ref field, value, propertyName);
            AddChangeWatcher();
            return flag;
        }
    }
}
