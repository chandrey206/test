using System;

delegate void MyEventHandler();

class MyEvent
{
    public event MyEventHandler SomeEvent;

    public void OnSomeEvent()
    {
        if (SomeEvent != null)
            SomeEvent();
    }
}
class EventDemo
{
    // Обработчик события.
    static void Handler()
    {
        Console.WriteLine("Произошло событие");
    }
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        MyEvent evt = new MyEvent();
        evt.SomeEvent += Handler;
        evt.OnSomeEvent();
        Console.ReadKey();
    }
}
