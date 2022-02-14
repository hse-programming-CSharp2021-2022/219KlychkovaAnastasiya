using System;

namespace PizzaStuff.Recipes
{
    public sealed class PizzaSicilian : PizzaRecipe
    {
        public override string Name => "Sicilian";

        public override Ingredients Ingredients { get => Ingredients.Dough | Ingredients.TomatoSauce | Ingredients.Anchovies | Ingredients.Parmesan; }
    }
}
