using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using UnityEngine;
using EUI;

public class TestModel : EUI.ModelBase
{

    private string name;
    public string Name
    {
        get => name;
        set {
            if (name != value) {
                name = value;
                OnPropertyChanged();
            }
        }
    }

    private Vector3 pos;
    public Vector3 Pos
    {
        get => pos;
        set {
            if (!pos.Equals(value)) {
                pos = value;
                OnPropertyChanged();
            }
        }
    }

    public override void OnInit()
    {
        Debug.Log("===TestModel===");
    }
    
}
