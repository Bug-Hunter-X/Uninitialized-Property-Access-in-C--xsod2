public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass() // Constructor to initialize the property
    {
        MyProperty = 0; // Initialize MyProperty 
    }

    public void MyMethod()
    {
        Console.WriteLine(MyProperty); // Accessing the initialized property
    }
}