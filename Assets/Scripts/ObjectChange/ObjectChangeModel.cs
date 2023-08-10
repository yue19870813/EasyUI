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
        // obj = new ChangeObject();
        // obj.Name = "ChangeObject";
        // obj.Sub = new InnerChangeObject();
        // obj.Sub.Age = 99;
    }
}
