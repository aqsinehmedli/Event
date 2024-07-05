using Event_Extension_Method_Standart_Delegate;
using System.Text;

Console.Write("Enter string:");
var str = Console.ReadLine();
MyClass cls = new MyClass();
Run runInstance = new Run();
Func funcDell1 = new Func(cls.Space);
Func funcDell2 = new Func(cls.Reverse);
runInstance.runFunc(str, funcDell1);
Console.WriteLine();
runInstance.runFunc(str, funcDell2);