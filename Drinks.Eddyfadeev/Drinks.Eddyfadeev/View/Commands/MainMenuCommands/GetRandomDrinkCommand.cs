﻿using Drinks.Enums;
using Drinks.Interfaces.HttpManager;
using Drinks.Interfaces.View;
using Drinks.Services;
using Spectre.Console;

namespace Drinks.View.Commands.MainMenuCommands;

internal sealed class GetRandomDrinkCommand : ICommand
{
    private readonly IHttpManger _httpManger;
    private readonly ITableConstructor _tableConstructor;
    public GetRandomDrinkCommand(IHttpManger httpManger, ITableConstructor tableConstructor)
    {
        _httpManger = httpManger;
        _tableConstructor = tableConstructor;
    }
    
    public void Execute()
    {
        var drinks = _httpManger.GetResponse(ApiEndpoints.Random.RandomCocktail);

        var drinkTable = _tableConstructor.CreateDrinkTable(drinks[0]);
        
        AnsiConsole.Write(drinkTable);
        
        HelpService.WaitForEnter();
    }
}