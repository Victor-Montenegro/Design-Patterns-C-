namespace Design_Patterns.Structural_Patterns.Adapter;

//Client
public class PaymentService
{
    private readonly IQueue _queue;

    public PaymentService(IQueue queue)
    {
        _queue = queue;
    }

    public void CompleteCard()
    {
        _queue.Publish();
    }
}
