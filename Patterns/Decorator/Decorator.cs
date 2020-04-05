public abstract class Decorator
{
    private IFood Food;

    public Decorator(IFood food)
    {
        Food = food;
    }

    public string GetDescription()
    {
       return Food.GetDescription();
    }

    public double GetTotalCost()
    {
        return Food.GetTotalCost();
    }
}