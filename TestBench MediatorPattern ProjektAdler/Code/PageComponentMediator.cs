using System.Reflection.Metadata;
using TestBench_MediatorPattern_ProjektAdler.Code.Dependencies.Mediator;
namespace TestBench_MediatorPattern_ProjektAdler.Code;

//intended use: command structure inbetween blazor components on the same page


public class PageComponentMediator : BaseMediator
{
    public PageComponentMediator(BaseMediatorQueryHandler mediatorQueryHandler) : base(mediatorQueryHandler)
    {
        
    }
    
}

public class PageComponentMediatorQuery : BaseMediatorQuery
{
    public PageComponentMediatorQuery(string name, Action action) : base(name, action)
    {
    }
}