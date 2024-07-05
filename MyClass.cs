
namespace Event_Extension_Method_Standart_Delegate;

public delegate void Func(string str);
class MyClass
{
    public void Space(string str)
    {
        foreach (char letter in str)
        {
            Console.Write(letter);
            Console.Write("_");
        }
    }
    public void Reverse(string str)
    {
        int count = str.Length;
        for (int i = count - 1; i >= 0; i--)
        {
            Console.WriteLine(str[i]);
        }
    }

}
