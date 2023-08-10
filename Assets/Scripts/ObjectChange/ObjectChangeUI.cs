using System.Collections;
using System.Collections.Generic;
using EUI;
using UnityEngine;

public class ObjectChangeUI : ViewBase
{
    public override void Awake()
    {
        ModelManager.Register<ObjectChangeModel>();
        base.Awake();
        Debug.Log("________ObjectChangeUI:Awake__________");
    }

    [Watcher(Model = "ObjectChangeModel", Name = "Name")]
    public void SetName(string name)
    {
        // model.Name = name;
        Debug.Log("ObjectChangeUI --- Name数据产生变化，变化值为：" + name);
    }

    [Watcher(Model = "ObjectChangeModel", Name = "Obj")]
    public void SetObjName(ChangeObject obj)
    {
        // model.Name = name;
        Debug.Log("ObjectChangeUI --- ChangeObject.Name数据产生变化，变化值为：" + obj.Name);
        Debug.Log("ObjectChangeUI --- ChangeObject.Sub.Age数据产生变化，变化值为：" + obj.Sub?.Age);
    }

    public void OnClick() 
    {
        Debug.Log("=== ObjectChangeUI Button OnClick ===");
        ObjectChangeModel model = ModelManager.GetModel<ObjectChangeModel>();
        model.Name = "Model name Jack ~~~~";
    }

    public void OnChangeObjClick() 
    {
        Debug.Log("=== OnChangeObjClick Button OnClick ===");
        ObjectChangeModel model = ModelManager.GetModel<ObjectChangeModel>();
        model.Obj.Name = "Obj name JJJJJohn~~~~";
    }

    public void OnChangeSubObjClick() 
    {
        Debug.Log("=== OnChangeSubObjClick Button OnClick ===");
        ObjectChangeModel model = ModelManager.GetModel<ObjectChangeModel>();
        model.Obj.Sub.Age = 99;
    }
}
