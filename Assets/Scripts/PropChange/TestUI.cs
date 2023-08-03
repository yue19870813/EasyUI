using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using EUI;

public class TestUI : ViewBase
{
    public override void Awake()
    {
        EUI.ModelManager.Register<TestModel>();
        EUI.ModelManager.Register<TestModel2>();
        base.Awake();
        Debug.Log("________TestUI:Awake__________");
    }

    [Watcher(Model = "TestModel", Name = "Name")]
    public void SetName(string name)
    {
        // model.Name = name;
        Debug.Log("TestUI --- Name数据产生变化，变化值为：" + name);
    }

    [Watcher(Model = "TestModel2", Name = "Age")]
    public void SetAge(int age)
    {
        // model.Name = name;
        Debug.Log("TestUI --- Age数据产生变化，变化值为：" + age);
    }

    
    void Update()
    {
        
    }

    public void OnClick() 
    {
        Debug.Log("=== Button OnClick ===");
        TestModel model = EUI.ModelManager.GetModel<TestModel>();
        model.Name = "Yue";

        TestModel2 model2 = EUI.ModelManager.GetModel<TestModel2>();
        model2.Age = 33;
        model2.Pos = new Vector3(1, 2, 3);
    }
}
