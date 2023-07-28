
using UnityEngine;

public class TestComponent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        EUI.ModelManager.Register<TestModel>();

        var ui = new TestUI();
        ui.SetName("Jhon Deep");

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void watch() {

    }
}
