using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using CommunityToolkit.Mvvm.ComponentModel;
using UnityEngine;

public class MvvmVo : ObservableObject

{
    private string name;
    public string Name
    {
        get => name;
        set => SetProperty(ref name, value); 
    }
    private Vector3 pos;
    public Vector3 Pos
    {
        get => pos;
        set => SetProperty(ref pos, value); 
    }
    
    
}
