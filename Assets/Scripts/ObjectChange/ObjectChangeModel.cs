using EUI;


public class ObjectChangeModel : ModelBase
{
    public ChangeObject obj = new();
    [ObserveObject]
    public ChangeObject Obj
    {
        get => obj;
        set => OnPropertyChanged(ref obj, value);
    }

    private string name;
    public string Name
    {
        get => name;
        set => OnPropertyChanged(ref name, value);
    }

    public override void OnInit() 
    {
        
    }
}
