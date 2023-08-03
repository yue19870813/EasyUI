using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EUI
{
    public class ModelManager
    {
        private static readonly Dictionary<string, ModelBase> _modelTable = new();
        
        public static void Register<T>() where T : ModelBase, new()
        {
            var t = typeof(T);
            var name = t.FullName;
            var model = new T();
            model._Init_();
            var hasKey = _modelTable.ContainsKey(name);
            if (!hasKey)
            {
                _modelTable.Add(name, model);
            }
            else
            {
                Debug.LogWarning(name + " has already regist.");
            }
        }

        public static T GetModel<T>() where T : ModelBase, new()
        {
            var t = typeof(T);
            var name = t.FullName;
            if (ModelManager._modelTable.ContainsKey(name))
            {
                return (T)(ModelManager._modelTable[name]);
            }
            return null;
        }

        public static ModelBase GetModel(string name)
        {
            if (ModelManager._modelTable.ContainsKey(name))
            {
                return ModelManager._modelTable[name];
            }
            return null;
        }
    }
}
