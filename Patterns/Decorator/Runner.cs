using System;

public class Runner
{
    public static void Main(string[] args)
    {
        FoodImplemetation Food = new FoodImplemetation();
        Console.WriteLine(String.Format("Total cost for {0} is {1}",Food.GetDescription(),Food.GetTotalCost()));

        FoodWithSide FoodWithSide = new FoodWithSide(Food);
        Console.WriteLine(String.Format("Total cost for {0} is {1}",FoodWithSide.GetDescription(),FoodWithSide.GetTotalCost()));

        FoodWithDrink FoodWithDrink = new FoodWithDrink(Food); 
        Console.WriteLine(String.Format("Total cost for {0} is {1}",FoodWithDrink.GetDescription(),FoodWithDrink.GetTotalCost()));
    }
}