namespace TestBench_MediatorPattern_ProjektAdler.Code.Dependencies.Mediator;

using MediatR;


namespace Interfaces
{
    #region Interfaces
    public interface IMediator : MediatR.IMediator
    {
        
    }

    public interface ISender : MediatR.ISender
    {
        
    }

    public interface IPublisher : MediatR.IPublisher
    {
        
    }
    
    public interface IRequest : MediatR.IRequest
    {
        
    }
    
    public interface IRequest<out TResponse> : MediatR.IRequest<TResponse>
    {
        
    }
    
    public interface IRequestHandler<in TRequest> : MediatR.IRequestHandler<TRequest>
        where TRequest : IRequest
    {
        
    }

    public interface IRequestHandler<in TRequest, TResponse>
        where TRequest : IRequest<TResponse>
    {
        
    }

    public interface INotificationHandler<in TNotification> : MediatR.INotificationHandler<TNotification>
        where TNotification : INotification
    {
        
    }

    
    public interface IStreamRequest<out TResponse> : MediatR.IStreamRequest<TResponse>
    {
        
    }

    public interface IStreamRequestHandler<in TRequest, out TResponse> : MediatR.IStreamRequestHandler<TRequest>
    {
        
    }
    #endregion
    

}

