using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EUI;

public class TestModel2 : ModelBase
{

    private int age;
    public int Age
    {
        get => age;
        set => OnPropertyChanged(ref age, value);
    }

    private Vector3 pos;
    public Vector3 Pos
    {
        get => pos;
        set => OnPropertyChanged(ref pos, value);
    }

    public override void OnInit()
    {
        Debug.Log("===TestModel2===");
    }
    
}
