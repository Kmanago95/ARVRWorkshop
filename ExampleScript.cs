using System.Collections;
using UnityEngine;

// Example class for SF Hacks workshop.
public class ExampleScript: MonoBehaviour {

    // Serialized structs and classes show up in the Inspector.
    [System.SerializeField]
    public struct DataStruct {
        public int valueA;
        public float valueB;
    }

    // Only non-abstract, non-generic custom classes can be serialized.
    [System.SerializeField]
    public class DataClass {
        public int valueA;
        public float valueB;
    }

    // Variables
    public DataClass data;

    // Properties can have default getters and setters, with restrictable visibility.
    public string Name { get; private set; }

    [SerializeField] private int visibleInEditor;

    private int notVisibleInEditor;

    // Unity utilizes this method in place of the constructor.
    void Awake () {
        // Initialize the instance here.
        Name = "John Doe";
    }

    void Start () {
        // Called before the first frame update only if the script instance is enabled.
        // See details at https://docs.unity3d.com/Manual/ExecutionOrder.html
    }

    void Update () {
        // Called once per frame.
    }

        // Functions
    int Multiply(int a, int b) {
        int output = 0;
        for (int i = 0; i < a; i++) {
            output += b;
        }
        return output;
    }

    void CallsMultiply() {
        Debug.Log(Multiply(3, 5));
    }
}