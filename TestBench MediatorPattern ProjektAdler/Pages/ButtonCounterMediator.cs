namespace TestBench_MediatorPattern_ProjektAdler.Pages;

public static class TestMediator
{
    public static Code.PageComponentMediator mediator;
    static TestMediator()
    {
        var queryHandler = new Code.Dependencies.Mediator.BaseMediatorQueryHandler();
        mediator = new Code.PageComponentMediator(queryHandler);
    }
}