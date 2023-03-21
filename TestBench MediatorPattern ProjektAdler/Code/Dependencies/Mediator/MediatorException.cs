namespace TestBench_MediatorPattern_ProjektAdler.Code.Dependencies.Mediator.Exceptions;


public class MediatorNotImplementedException : NotImplementedException
{ 
    public MediatorNotImplementedException() : base() { }
    public MediatorNotImplementedException(string? message) : base(message) { } 
    public MediatorNotImplementedException(string? message, Exception? inner) : base(message, inner) { }
}
