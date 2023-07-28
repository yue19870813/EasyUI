using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EUI
{
    public class ModelManager
    {
        private static readonly Dictionary<Type, ModelBase> _modelTable = new();
        
        public static void Register<T>() where T : ModelBase, new()
        {
            var t = typeof(T);
            var name = t.Name;

            var model = new T();
            model._Init_();

            var hasKey = _modelTable.ContainsKey(t);
            if (!hasKey)
            {
                Debug.Log("obj == null###model.ModelName  === " + name);
                _modelTable.Add(t, model);
            }
            else
            {
                Debug.LogWarning(name + "已经注册！");
            }
        }
        
    }
}
