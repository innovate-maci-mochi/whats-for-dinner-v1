using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//main application for prompting questions for user
namespace WhatsForDinner
{    
    class Questions 
    {
        static void Main(string[] args)
        {
            //recipes variable for iterating For loop
            int recipes;
            //create list to hold meals to display
            List<Recipe> recipesToDisplay = new List<Recipe>();
            //variable for total cost
            double totalCostOfRecipes = 0;

            Console.WriteLine("What is your name?");
            string username = Console.ReadLine();

            Console.WriteLine("How many meals do you need prepped?");
            int recipesToPrep = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What's your weekly dinner budget cost?");
            double weeklyBudget = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What cost variance mode would you like to use?");
            Console.WriteLine("A). Same $ per day.");
            Console.WriteLine("B). Cheap 5x/week, Nice 2x/week.");
            string costVarianceModeSelected = Console.ReadLine();

            recipesToDisplay = RandomizeMeals(weeklyBudget, costVarianceModeSelected, recipesToPrep, recipesToDisplay);

            //display recipes for week - iterate over recipesToDisplay List
            //display total cost of recipes for week - iterate over recipesToDisplay List to calculate
            foreach (Recipe r in recipesToDisplay)
            {
                //Console.WriteLine(r.PrintRecipe); --outputs System.Action, not the recipe!
                Console.WriteLine($"Recipe: {r.Name}");
                Console.WriteLine("Ingredients: " + r.Ingredients);
                Console.WriteLine("Instructions:");
                Console.WriteLine(r.Instructions);
                Console.WriteLine("Cost: $" + r.Cost);
                totalCostOfRecipes += r.Cost;
            }

            Console.WriteLine("Total Cost of Recipes: $" + totalCostOfRecipes);
            Console.WriteLine("Budget Usage: " + Convert.ToString((totalCostOfRecipes/weeklyBudget) * 100) + "%");

            //do math for cost of recipe, from ingredients - give individual cost per ingredient
            //total weekly cost            
        }

        //method to handle cost variance logic
        //what to return? Can pivot to use this method as the CHECK, run from recipe randomizer method
        //Need a class for Day? Property: cost per day, load results from CostVariance method
        //QUESTION: HOW TO EXTRACT COST VARIANCE --> DAILY COST SO CAN USE FOR COST CHECK @ RANDOMIZER
        //LATER FEATURE - KEEP SIMPLE FOR NOW
        static void CostVariance(double weeklyBudget, string costVarianceMode, int recipesToPrep)
        {
            if (costVarianceMode == "A")
            {
                recipesToPrep = Convert.ToInt32(weeklyBudget) / recipesToPrep;
            }
            else if (costVarianceMode == "B")
            {
                double fiveCheapMealsBudget = (weeklyBudget * .6 ) / 5;
                double twoNiceMealsBudget = (weeklyBudget * .4 ) / 2;
            }
            return;
        }

        //method to handle recipe randomizer logic
        static List<Recipe> RandomizeMeals(double weeklyBudget, string mealPrepMode, int recipesToPrep, List<Recipe> recipesToDisplay)
        {
            //v1 hardcode list until develop recipe repository
            recipesToDisplay.Add(new Recipe("Spaghetti", "1. Pasta. 2. Sauce.", "1. Boil water. 2. Add pasta. 3. Add sauce.", 10.50));
/*             for (recipes = 0; recipes < recipesToPrep; recipes++) 
            {
                recipesToDisplay[recipes] = ;
            } */

            return recipesToDisplay;
        }

        //method to display meals
        static void DisplayMeals(int mealsToPrep) 
        {
            //include cost variable > hard coding
            //Console.WriteLine(username + ", Here is your meal plan for the week:");
            Console.WriteLine("Here is your meal plan for the week:");
            Console.WriteLine("Monday: " + "Peanut Butter Jelly Sandwiches" + "$7");
            Console.WriteLine("Tuesday: " + "Spaghetti" + " $10");
            Console.WriteLine("Wednesday: " + "Chicken Alfredo" + " $15");
            Console.WriteLine("Thursday: " + "Tacos" + " $20");
            Console.WriteLine("Friday: " + "Pizza" + " $10");
            Console.WriteLine("Saturday: " + "Steak" + " $25");
            Console.WriteLine("Sunday: " + "Salmon & Asparagus" + " $30");
        }
    }
}    