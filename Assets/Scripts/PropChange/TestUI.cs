using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using EUI;

public class TestUI : ViewBase
{
    // TestModel model;
    // public TestUI()
    // {
    //     // model = new TestModel();

    //     // model.PropertyChanged += (s, e) => {
    //     //     Type type = s.GetType();
    //     //     PropertyInfo prop = type.GetProperty(e.PropertyName);
    //     //     Debug.Log(e.PropertyName + " = " + prop.GetValue(s));
    //     // };
    // }
    public override void Awake()
    {
        EUI.ModelManager.Register<TestModel>();
        base.Awake();
        Debug.Log("________TestUI:Awake__________");
    }

    [PropertyWatcher(Model = "TestModel", Name = "Name")]
    public void SetName(string name)
    {
        // model.Name = name;
        Debug.Log("Name数据产生变化，变化值为：" + name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick() 
    {
        Debug.Log("=== Button OnClick ===");
        TestModel model = EUI.ModelManager.GetModel<TestModel>();
        model.Name = "Yue";
    }
}
