namespace LifetimeServicesSample.Services;

public class ActionService : IActionTransientService, IActionScopedService, IActionSingletonService 
{
    public ActionService() 
    {
        ActionCode = Guid.NewGuid().ToString();
    }

    public string ActionCode { get; }
}