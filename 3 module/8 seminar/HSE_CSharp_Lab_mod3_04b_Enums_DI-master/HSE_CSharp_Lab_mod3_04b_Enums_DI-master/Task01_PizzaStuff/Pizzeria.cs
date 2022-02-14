using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaStuff
{
    public class Pizzeria
    {
        // Склад для ингредиентов. Хранит количество каждого ингредиента.
        private Dictionary<Ingredients, int> storage = new Dictionary<Ingredients, int>();

        public Pizzeria()
        {
            foreach (Ingredients ingredient in Enum.GetValues(typeof(Ingredients)))
            {
                storage.Add(ingredient, 0);
            }
        }

        /// <summary>
        /// Привозит новые ингредиенты на склад.
        /// Увеличивает количество ингредиента ingredients на значение amount.
        /// </summary>
        /// <param name="ingredients"> Ингредиент, который будет привезен на склад. </param>
        /// <param name="amount"> Количество ингредиента. </param>
        public void DeliverIngredient(Ingredients ingredients, int amount)
        {
            storage[ingredients] += amount;
        }

        /// <summary>
        /// Возвращет информацию о количестве каждого ингредиента на складе.
        /// </summary>
        public (string name, int amount)[] GetStorage()
        {
            (string, int)[] ingredients = new (string, int)[storage.Count];
            int i = 0;
            foreach (var ingredient in storage)
            {
                ingredients[i] = (ingredient.Key.ToString(), ingredient.Value);
                i++;
            }
            return ingredients;
        }

        /// <summary>
        /// Готовит пиццу по рецепту.
        /// </summary>
        /// <param name="recipe"> Рецепт пиццы. </param>
        /// <returns> Приготовленная пицца. </returns>
        /// <exception cref="PizzaException"> Если на складе не хватает ингредиентов, чтобы приготовить пиццу по рецепту.</exception>
        public Pizza MakePizza(PizzaRecipe recipe)
        {
            if (HasIngredients(recipe))
            {
                UseIngredients(recipe);
                return new Pizza(recipe);
            }
            else
                throw new PizzaException($"Not enough ingredients to make {recipe}.");
        }

        public Pizza[] CompleteOrder(PizzaRecipe[] order)
        {
            List<Pizza> pizzas = new();
            foreach (var recipe in order)
            {
                if (HasIngredients(recipe))
                {
                    UseIngredients(recipe);
                    pizzas.Add(new Pizza(recipe));
                }
                else
                    throw new PizzaException($"Not enough ingredients to complete an order.");
            }
            return pizzas.ToArray();
        }

        /// <summary>
        /// Проверяет, есть ли на складе ингредиенты для рецепта.
        /// </summary>
        /// <param name="recipe"> Рецепт, наличие ингредиентов необходимо проверить. </param>
        /// <returns> true, если все ингредиенты есть на складе, false иначе. </returns>
        private bool HasIngredients(PizzaRecipe recipe)
        {
            foreach (var ingredient in storage)
            {
                if ((ingredient.Key & recipe.Ingredients) != 0)
                    if (ingredient.Value == 0)
                        return false;
            }
            return true;
        }

        /// <summary>
        /// Удаляет со склада по одному ингредиенту из рецепта.
        /// </summary>
        /// <param name="recipe"></param>
        private void UseIngredients(PizzaRecipe recipe)
        {
            foreach (var ingredient in storage)
                if ((ingredient.Key & recipe.Ingredients) != 0)
                    storage[ingredient.Key]--;
        }
    }
}
