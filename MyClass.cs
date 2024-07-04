
namespace Event_Extension_Method_Standart_Delegate;

public class MyClass
{
    public string Space(string str)
    {
        char[] charArray = str.ToCharArray();
        return new string(charArray);
    }
    public string Reverse(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }


}
