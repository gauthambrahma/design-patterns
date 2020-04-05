public class FoodWithDrink : Decorator
{
    private string description = " and a drink";
    private double cost = 1.5;
    public FoodWithDrink(IFood food):base(food)
    {

    }

    public string GetDescription()
    {
        return base.GetDescription() + description;
    }

    public double GetTotalCost()
    {
        return base.GetTotalCost() + cost;
    }
}