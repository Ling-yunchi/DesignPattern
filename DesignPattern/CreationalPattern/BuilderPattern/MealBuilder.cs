namespace DesignPattern.CreationalPattern.BuilderPattern;

public abstract class MealBuilder
{
    protected readonly Meal Meal;
    
    protected MealBuilder() {
        Meal = new Meal();
    }
    
    public abstract void BuildDrink();
    public abstract void BuildMainDish();
    public abstract void BuildSideDish();
    
    public Meal GetMeal() {
        return Meal;
    }
}

