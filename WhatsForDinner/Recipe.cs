namespace WhatsForDinner
{
    public class Recipe
    {
        public string Name { get; set; }
        public string Ingredients { get; set; }
        public string Instructions { get; set; }
        public double Cost { get; set; }

        //need Ingredients class - replace in line 10 and line 6
        //create one recipe, create ingredients (cost) - can be hardcoded for now, later call service
        //can later build recipes
        //storage of recipe: hard code, or csv, or spreadsheet
        public Recipe(string name, string ingredients, string instructions, double cost)
        {
            Name = name;
            Ingredients = ingredients;
            Instructions = instructions;
            Cost = cost;
        }

        public void PrintRecipe()
        {
            Console.WriteLine($"Recipe: {Name}");
            Console.WriteLine("Ingredients: " + Ingredients);
            //may return Ingredients to type List, or upgrade to List<Ingredients>, but so far has been tricky when instantiating class
/*             foreach (var ingredient in Ingredients)
            {
                Console.WriteLine(ingredient);
            } */
            Console.WriteLine("Instructions:");
            Console.WriteLine(Instructions);
            Console.WriteLine("Cost: $" + Cost);
        }
    }
}