namespace LearningPlace.EventExample;

public class EventProcessor
{
    //Processes which event, the TestEvent
    public event EventHandler<TestEvent> TestEvent;
    //When a TestEvent is created, this processor class will start to process the event,
    //e.g. prepare it for package to be sent to event handlers/listeners
    
    //Raise
    //Invoke method, will use this class to send the event.
    //The event being sent is a testEvent class.
    protected virtual void OnTestEvent(TestEvent e)
    {
        TestEvent.Invoke(this, e);
    }
    
    //Start processing the raised event. 
    public void StartEvent()
    {
        OnTestEvent(new TestEvent("Hello world!"));
    }
}

public class TestEvent : EventArgs
{
    public string Message { get; }

    public TestEvent(string message)
    {
        Message = message;
    }
}

public class TestEventHandler
{
    public void HandlerTestEvent(object sender, TestEvent testEvent)
    {
        Console.WriteLine(testEvent.Message);
    }
}