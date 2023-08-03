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
        set => OnPropertyChanged(ref name, value);
    }

    public override void OnInit()
    {
        Debug.Log("===TestModel===");
    }
    
}
