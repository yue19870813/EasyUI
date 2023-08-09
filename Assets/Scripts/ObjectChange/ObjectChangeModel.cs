using EUI;


public class ObjectChangeModel : ModelBase
{
    public ChangeObject obj;
    [ObserveObject]
    public ChangeObject Obj
    {
        get => obj;
        set => OnPropertyChanged(ref obj, value);
    }


    public override void OnInit() 
    {
        obj = new ChangeObject();
        obj.Name = "ChangeObject";
        obj.Sub = new InnerChangeObject();
        obj.Sub.Age = 99;
    }
}
