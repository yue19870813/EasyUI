using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EUI
{
    public class ObservableObject : Property
    {
        // public new event PropertyChangedEventHandler PropertyChanged;
        // public ObservableObject()
        // {
        //     Debug.Log("----Base ObservableObject constructor----");
        // }

        // protected new void OnPropertyChanged<T>(ref T field, T value, [CallerMemberName]string propertyName = null) 
        // {
        //     if (!EqualityComparer<T>.Default.Equals(field, value))
        //     {
        //         field = value;
        //         PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //     }
        // }
    }
}