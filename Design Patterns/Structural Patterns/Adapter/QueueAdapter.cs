namespace Design_Patterns.Structural_Patterns.Adapter;

//Adapter class
public class QueueAdapter : IQueue
{
    private readonly IQueueXml _queueXml;

    public QueueAdapter(IQueueXml queueXml)
    {
        _queueXml = queueXml;
    }

    public void Publish()
    {
        _queueXml.PublishXML();
    }

    public void Subscribe()
    {
        _queueXml.SubscribeXML();
    }
}

