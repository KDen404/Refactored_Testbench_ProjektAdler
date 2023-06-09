using MediatR;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace TestBench_MediatorPattern_ProjektAdler.Code.Dependencies.Mediator;

public class Response
{
    public object? Output { get; set; }
}
public class BaseMediatorQueryHandler : IRequestHandler<BaseMediatorQuery, Response>
{
    public virtual async Task<Response> Handle(BaseMediatorQuery request, CancellationToken cancellationToken)
    {
        var buf = request.Name;
        var action = request.Action;
        try
        {
            action();
        }
        catch (Exception error)
        {
            return Task.FromResult(new Response { Output = false }).Result;
        }
        return Task.FromResult(new Response { Output = true }).Result;
    }
}
public abstract class BaseMediatorQuery : IRequest<Response>
{
    public string Name;
    public Action Action;
    public BaseMediatorQuery(string name, Action action)
    {
        Name = name;
        Action = action;
    }
}
public abstract class BaseMediator
{
    protected BaseMediatorQueryHandler Handler;
    public BaseMediator(BaseMediatorQueryHandler handler)
    {
        Handler = handler;
    }
    [HttpGet]
    public async Task<IActionResult> Send(BaseMediatorQuery query)
    {
        var result = await Handler.Handle(query, CancellationToken.None);
        return new OkObjectResult(result);
    }
}