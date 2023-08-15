using EUI;
using UnityEngine;

public class InnerChangeObject : ObservableObject
{
    private int age;
    [ObserveObject]
    public int Age
    {
        get => age;
        set => OnPropertyChanged(ref age, value);
    }

}

public class ChangeObject : ObservableObject
{
    private string name = "default";
    public string Name
    {
        get => name;
        set => OnPropertyChanged(ref name, value);
    }

    private InnerChangeObject sub;
    [ObserveObject]
    public InnerChangeObject Sub
    {
        get => sub;
        set => OnPropertyChanged(ref sub, value);
    }

    public ChangeObject() 
    {
        Debug.Log("----ChangeObject constructor----");
    }

}
