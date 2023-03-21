using TestBench_MediatorPattern_ProjektAdler.Code.Dependencies.Mediator.Wrapper;

namespace TestBench_MediatorPattern_ProjektAdler.Code.Dependencies.Mediator;


public class Mediator : IMediator
{
    public virtual Task<TResponse> Send<TResponse>(IRequest<TResponse> request, CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }
    public virtual Task Send<TRequest>(TRequest request, CancellationToken cancellationToken = new CancellationToken())
        where TRequest : IRequest
    {
        throw new NotImplementedException();
    }
    public virtual Task<object?> Send(object request, CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }
    public virtual IAsyncEnumerable<TResponse> CreateStream<TResponse>(IStreamRequest<TResponse> request, CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }
    public virtual IAsyncEnumerable<object?> CreateStream(object request, CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }
    public virtual Task Publish(object notification, CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }
    public virtual Task Publish<TNotification>(TNotification notification, CancellationToken cancellationToken = new CancellationToken())
        where TNotification : INotification
    {
        throw new NotImplementedException();
    }
}
