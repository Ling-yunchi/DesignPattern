using NUnit.Framework;

namespace DesignPattern.CreationalPattern.BuilderPattern;

public static class Program
{
    class MealOrder
    {
        private readonly MealBuilder _mealBuilder;
        public MealOrder(MealBuilder mealBuilder) {
            _mealBuilder = mealBuilder;
        }
        // Client control how to build a meal
        public Meal PrepareMeal() {
            _mealBuilder.BuildDrink();
            _mealBuilder.BuildMainDish();
            _mealBuilder.BuildSideDish();
            return _mealBuilder.GetMeal();
        }
    }
    
    [Test]
    public static void Test() {
        MealBuilder burgerMealBuilder = new BurgerMealBuilder();
        MealBuilder pizzaMealBuilder = new PizzaMealBuilder();
        MealOrder mealOrder = new MealOrder(burgerMealBuilder);
        Meal meal = mealOrder.PrepareMeal();
        Console.WriteLine($"BurgerMealBuilder prepared meal is {meal.Drink}, {meal.MainDish}, {meal.SideDish}");
        mealOrder = new MealOrder(pizzaMealBuilder);
        meal = mealOrder.PrepareMeal();
        Console.WriteLine($"PizzaMealBuilder prepared meal is {meal.Drink}, {meal.MainDish}, {meal.SideDish}");
    }
}