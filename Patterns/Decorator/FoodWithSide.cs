public class FoodWithSide : Decorator
{
    private string description = " and a side";
    private double cost = 2.5;
    public FoodWithSide(IFood food):base(food)
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