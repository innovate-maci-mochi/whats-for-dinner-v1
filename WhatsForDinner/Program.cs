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
            Console.WriteLine("What is your name?");
            string username = Console.ReadLine();

            Console.WriteLine("What's your weekly dinner budget cost?");
            int weeklyBudget = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What meal prep mode would you like to use?");
            Console.WriteLine("A). Same $ per day.");
            Console.WriteLine("B). Cheap 5x/week, Nice 2x/week.");
            string mealPrepMode = Console.ReadLine();

            Console.WriteLine("How many days would you like to prep dinner this week?");
            Console.WriteLine("A). 7 days.");
            Console.WriteLine("B). 5 days.");
            int mealsToPrep = Convert.ToInt32(Console.ReadLine());
            //string mealsToConfirm = RandomizeMeals(weeklyBudget, mealPrepMode, mealsToPrep);

            Console.WriteLine(username + ", Here is your meal plan for the week:");
            Console.WriteLine("Monday: " + "Peanut Butter Jelly Sandwiches" + " $7");
            Console.WriteLine("Tuesday: " + "Spaghetti" + " $10");
            Console.WriteLine("Wednesday: " + "Chicken Alfredo" + " $15");
            Console.WriteLine("Thursday: " + "Tacos" + " $20");
            Console.WriteLine("Friday: " + "Pizza" + " $10");
            Console.WriteLine("Saturday: " + "Steak" + " $25");
            Console.WriteLine("Sunday: " + "Salmon & Asparagus" + " $30");
            Console.WriteLine("Total Weekly Cost: $" + weeklyBudget);

        }

        //method to randomize meals
        /* static string RandomizeMeals(int weeklyBudget, string mealPrepMode, int mealsToPrep)
        {
            if (mealPrepMode == "A")
            {
                mealsToPrep = weeklyBudget / 7;
            }
            else if (mealPrepMode == "B")
            {
                int fiveCheapMealsBudget = (weeklyBudget / 7) * 5;
                int twoNiceMealsBudget = (weeklyBudget / 7) * 2;
            }
            return mealsToPrep;
        } */
    }
}    