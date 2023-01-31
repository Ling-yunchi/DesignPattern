namespace DesignPattern.CreationalPattern.BuilderPattern;

public class PizzaMealBuilder:MealBuilder
{
    public override void BuildDrink() {
        Meal.Drink = "Sprite";
    }

    public override void BuildMainDish() {
        Meal.MainDish = "Pizza";
    }

    public override void BuildSideDish() {
        Meal.SideDish = "Garlic Bread";
    }
}