using DrinkInfoPractice.Services;
UserInput userInput = new UserInput();
await userInput.Start();

//var drinks = await cocktailService.GetDrinksByCategoryAsync("Beer");

//foreach (var drink in drinks)
//{
//    Console.WriteLine($"Drink Id: {drink.IdDrink}\n" +
//        $"Drink: {drink.StrDrink}\n\n");
    
//}

//Console.ReadLine();

//var drink1 = await cocktailService.GetDrinkByIdAsync("14378");

//Console.WriteLine($"Drink ID: {drink1.IdDrink}\n" +
//    $"Drink:  {drink1.StrDrink}\n" +
//    $"Category: {drink1.StrCategory}\n" +
//    $"Glass: {drink1.StrGlass}\n" +
//    $"Instructions: {drink1.StrInstructions}\n\n");

//Console.WriteLine($"Ingredients:");

//foreach (var ingredient in drink1.Ingredients)
//{
//    Console.WriteLine($"-{ingredient.Value.Ingredients}: {ingredient.Value.Measure}");
//}