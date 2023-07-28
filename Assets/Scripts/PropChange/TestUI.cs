using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using EUI;

public class TestUI
{
    TestModel model;
    public TestUI()
    {
        model = new TestModel();

        model.PropertyChanged += (s, e) => {
            Type type = s.GetType();
            PropertyInfo prop = type.GetProperty(e.PropertyName);
            Debug.Log(e.PropertyName + " = " + prop.GetValue(s));
        };
    }

    [RegisterModel("TestModel")]
    public void SetName(string name)
    {
        model.Name = name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
