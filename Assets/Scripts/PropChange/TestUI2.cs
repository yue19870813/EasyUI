using System.Collections;
using System.Collections.Generic;
using EUI;
using UnityEngine;

public class TestUI2 : ViewBase
{
    public override void Awake()
    {
        ModelManager.Register<TestModel>();
        ModelManager.Register<TestModel2>();
        base.Awake();
        Debug.Log("2________TestUI2:Awake__________");
    }
    [Watcher(Model = "TestModel2", Name = "Age")]
    public void SetAge(int age)
    {
        // model.Name = name;
        Debug.Log("TestUI2 +++ Age数据产生变化，变化值为：" + age);
    }

    [Watcher(Model = "TestModel2", Name = "Pos")]
    public void SetPos(Vector3 pos)
    {
        // model.Name = name;
        Debug.Log("TestUI2 +++ Pos数据产生变化，变化值为：" + pos.ToString());
    }
}
