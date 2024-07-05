namespace Event_Extension_Method_Standart_Delegate;


class Run
{
    public void runFunc(string argument, Func func)
    {
        func.Invoke(argument);
    }
}

