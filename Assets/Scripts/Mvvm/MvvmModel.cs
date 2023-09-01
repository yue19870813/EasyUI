using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using UnityEngine;

[System.Serializable]
public class MvvmModel : ObservableObject
{
    private MvvmVo data;

    public MvvmVo Data
    {
        get => data;
        set => SetProperty(ref data, value);
    }

    private ObservableCollection<int> intList;
    public ObservableCollection<int> IntList
    {
        get => intList;
        set => SetProperty(ref intList, value);
    }

    private int age;
    public int Age
    {
        get => age;
        set => SetProperty(ref age, value); 
    }

}
