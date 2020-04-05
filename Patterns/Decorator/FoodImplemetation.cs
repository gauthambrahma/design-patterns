public class FoodImplemetation:IFood
{
    private string Description = "Entree";
    private double Cost = 4; 
    public string GetDescription(){
        return Description;
    }
    public double GetTotalCost(){
        return Cost;
    }
}