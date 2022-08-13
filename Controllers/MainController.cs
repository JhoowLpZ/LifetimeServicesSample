using Microsoft.AspNetCore.Mvc;
using LifetimeServicesSample.Services;

namespace LifetimeServicesSample.Controllers;

public class MainController : Controller
{
    private readonly IActionTransientService _actionTransientServiceOne;
    private readonly IActionTransientService _actionTransientServiceTwo;
    private readonly IActionScopedService _actionScopedServiceOne;
    private readonly IActionScopedService _actionScopedServiceTwo;
    private readonly IActionSingletonService _actionSingletonServiceOne;
    private readonly IActionSingletonService _actionSingletonServiceTwo;

    public MainController(
        IActionTransientService actionTransientServiceOne,
        IActionTransientService actionTransientServiceTwo,
        IActionScopedService actionScopedServiceOne,
        IActionScopedService actionScopedServiceTwo,
        IActionSingletonService actionSingletonServiceOne,
        IActionSingletonService actionSingletonServiceTwo
    ) 
    {
        _actionTransientServiceOne = actionTransientServiceOne;
        _actionTransientServiceTwo = actionTransientServiceTwo;
        _actionScopedServiceOne = actionScopedServiceOne;
        _actionScopedServiceTwo = actionScopedServiceTwo;
        _actionSingletonServiceOne = actionSingletonServiceOne;
        _actionSingletonServiceTwo = actionSingletonServiceTwo;
    }

    public string GetActionsCode() 
    {
        return 
            $"Transient_One : {_actionTransientServiceOne.ActionCode} \n" +
            $"Transient_Two : {_actionTransientServiceTwo.ActionCode} \n" +
            $"Scoped_One : {_actionScopedServiceOne.ActionCode} \n" +
            $"Scoped_Two : {_actionScopedServiceTwo.ActionCode} \n" +
            $"Singleton_One : {_actionSingletonServiceOne.ActionCode} \n" +
            $"Singleton_Two : {_actionSingletonServiceTwo.ActionCode} \n" ;
    }
}