using Event_Extension_Method_Standart_Delegate;

MyClass myClass = new MyClass();
//string reversed = myClass.Reverse("Hello");
//Console.WriteLine(reversed);
string original = "Hello";
string spaced = myClass.Space(original);
Console.WriteLine(spaced);