namespace DesignPattern.CreationalPattern.BuilderPattern;

public class BurgerMealBuilder : MealBuilder
{
    public override void BuildDrink() {
        Meal.Drink = "Coke Cola";
    }

    public override void BuildMainDish() {
        Meal.MainDish = "Burger";
    }

    public override void BuildSideDish() {
        Meal.SideDish = "French Fries";
    }
}