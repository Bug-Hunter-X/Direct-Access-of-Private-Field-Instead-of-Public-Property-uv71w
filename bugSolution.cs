public class ExampleClass
{
    private int _value;

    public int Value
    {
        get { return _value; }
        set { _value = value; }
    }

    public void PrintValue()
    {
        Console.WriteLine(Value); // Accessing _value through the Value property
    }
}