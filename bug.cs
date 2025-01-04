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
        Console.WriteLine(_value); // Accessing _value directly instead of Value property
    }
}