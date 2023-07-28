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
            var t = this.GetType();
            var props = t.GetProperties();

            // var methods = t.GetMethods();

            // foreach (MethodInfo method in methods)
            // {
            //     Debug.Log("method name : " + method.Name);
            // }

            foreach (PropertyInfo prop in props)
            {
                if (prop.IsDefined(typeof(ChangeWatcherAttribute)))
                {
                    // string setterName = "set_" + prop.Name;
                    // Debug.Log("setterName = " + setterName);
                    // DynamicMethod setterMethod = new DynamicMethod(setterName, null, new Type[] {t, prop.GetType()}, t, true);
                    // ILGenerator il = setterMethod.GetILGenerator();
                    // il.Emit(OpCodes.Ldarg_0);
                    // il.Emit(OpCodes.Ldarg_1);
                    // il.Emit(OpCodes.Call, prop.GetSetMethod());
                    // il.Emit(OpCodes.Ret);

                    // // prop.SetMethod = setterMethod;
                    // prop.SetMethod.CreateDelegate();
                }
            }
            OnInit();
            
        }

       
        public virtual void OnInit()
        {

        }

        public void SetProperty(object obj, object value)
        {

        }

        protected void OnPropertyChanged([CallerMemberName]string propertyName = null) 
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void InterceptSetter(PropertyInfo property, object obj)
        {
            MethodInfo setMethod = property.GetSetMethod();
            if (setMethod != null)
            {
                // 自定义 Setter 拦截逻辑
                // 在这里可以添加你的逻辑处理
                OnPropertyChanged();
            }
        }
    }
}
