using System;

namespace PizzaStuff.Recipes
{
    public sealed class PizzaHawaii : PizzaRecipe
    {
        public override string Name => "Hawaii";

        public override Ingredients Ingredients { get => Ingredients.Dough | Ingredients.Ham | Ingredients.Mozzarella | Ingredients.Pineapple; }
    }
}
