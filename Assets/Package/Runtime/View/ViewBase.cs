using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace EUI
{
    public class ViewBase : MonoBehaviour
    {
        private class Watcher {
            public MethodInfo methodInfo;

            public string model;

            public string name;

        }

        private Dictionary<string, List<Watcher>> _watcherDict;

        public string viewName = "ViewBase";

        public ViewBase()
        {
            
        }
        public virtual void Awake()
        {
            InitWatcher();
            AddDelegate4Model();
        }

        void InitWatcher()
        {
            _watcherDict = new Dictionary<string, List<Watcher>>();
            var t = this.GetType();
            var methods = t.GetMethods();
            foreach (MethodInfo method in methods)
            {
                var pwAtt = method.GetCustomAttribute<WatcherAttribute>();
                if (pwAtt != null)
                {
                    List<Watcher> watcherList = null;
                    var modelName = pwAtt.Model;
                    _watcherDict.ContainsKey(modelName);
                    if (!_watcherDict.ContainsKey(modelName))
                    {
                        watcherList = new List<Watcher>();
                        _watcherDict.Add(modelName, watcherList);
                    }
                    else 
                    {
                        watcherList = _watcherDict[modelName];
                    }
                    var watcher = new Watcher();
                    watcher.methodInfo = method;
                    watcher.model = modelName;
                    watcher.name = pwAtt.Name;
                    watcherList.Add(watcher);
                }
            }
        }

        void AddDelegate4Model()
        {
            foreach (KeyValuePair<string, List<Watcher>> pair in _watcherDict)
            {
                var modelName = pair.Key;
                var model = ModelManager.GetModel(modelName);
                if (model != null) 
                {
                    model.PropertyChanged += (s, e) => {
                        Type type = s.GetType();
                        PropertyInfo prop = type.GetProperty(e.PropertyName);
                        foreach (var item in pair.Value)
                        {
                            if (e.PropertyName == item.name)
                            {
                                object[] arr = {prop.GetValue(s)};
                                item.methodInfo.Invoke(this, arr);
                            }
                        }
                    };
                }
            }
        }

        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            
        }

        void OnDestroy()
        {

        }
    }
}
