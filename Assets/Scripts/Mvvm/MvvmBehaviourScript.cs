using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;
using EUI;
using UnityEngine;

public class MvvmBehaviourScript : MonoBehaviour
{
    public MvvmModel model;
    // Start is called before the first frame update
    void Start()
    {
        model = new MvvmModel();
        model.Data = new MvvmVo();
        model.IntList = new ObservableCollection<int>();

        model.PropertyChanged += (s, e) =>
        {
            Type type = s.GetType();
            PropertyInfo prop = type.GetProperty(e.PropertyName);
            Debug.Log("11===Model名：" + type.Name + ", 属性名：" + e.PropertyName + ", 值：" + prop.GetValue(s));
        };
        model.Data.PropertyChanged += (s, e) =>
        {
            Type type = s.GetType();
            PropertyInfo prop = type.GetProperty(e.PropertyName);
            Debug.Log("22==Data名：" + type.Name + ", 属性名：" + e.PropertyName + ", 值：" + prop.GetValue(s));
        };
        model.IntList.CollectionChanged += (s, e) =>
        {
            Type type = s.GetType();
            Debug.Log("33==List名：" + type.Name + "，操作名称：" + e.Action + ", Old属性：" + e.OldItems + ", new属性：" + e.NewItems);
        };
        
    }

    public void ClickData()
    {
        model.Data.Name = "Yue";
    }

    public void ClickList()
    {
        model.IntList.Add(88);
    }

    public void ClickValue()
    {
        model.Age = 987;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
