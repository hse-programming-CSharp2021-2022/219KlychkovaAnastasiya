using System;

namespace PizzaStuff.Recipes
{
    public sealed class PizzaPeperoni : PizzaRecipe
    {
        public override string Name => "Peperoni";

        public override Ingredients Ingredients { get => Ingredients.Peperoni | Ingredients.Dough | Ingredients.OliveOil | Ingredients.Herbs | Ingredients.Mozzarella; }
    }
}
