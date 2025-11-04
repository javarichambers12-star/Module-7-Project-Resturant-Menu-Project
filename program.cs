/*this program purpose is from the perspective  of
a restaurant  owner trying to set their menu up.
This program allows you to add items & remove items. 
*/

// I (Javari) started step 1 , A & B of the overall program.
using System;
using System.Collections.Generic;
class Program
{
    //creates dictionary called 'resturantMenu' that stores a list of strings
    static Dictionary<string, List<string>> restaurantMenu = new Dictionary<string, List<string>>();

    static void Main()
    {
        Console.WriteLine("--- Welcome to the Restaurant Menu Manager ---\n");

        // Step a: Populate the dictionary with sample menu items
        PopulateMenu();

        // Step b: Display the dictionary contents using foreach
        DisplayMenu();
    }

    // Step a: Populate the dictionary
    static void PopulateMenu()
    {
        restaurantMenu.Clear(); // Start fresh


        //Creating Appetizers section of menu serving three items.
        restaurantMenu["Appetizers"] = new List<string> { "Fries", "Garlic Bread", "Wings" };
        
        //Creating Main Course section of menu serving three items.
        restaurantMenu["Main Course"] = new List<string> { "Grilled Chicken", "Pasta", "Burger" };
        
        //Creating Desserts section of menu serving three items.
        restaurantMenu["Desserts"] = new List<string> { "Chocolate Cake", "Ice Cream", "Pie" };
        
        
        //display message
        Console.WriteLine("Menu has been populated with sample items.");
    }

    // Step b: Display the dictionary contents
    static void DisplayMenu()
    {
        Console.WriteLine("\n--- Restaurant Menu ---");

        foreach (var category in restaurantMenu)
        {
            Console.WriteLine($"Category: {category.Key}");
            Console.WriteLine("Items: " + string.Join(", ", category.Value));
            Console.WriteLine();
        }
    }
}

//Next steps are C & D. the abiltiy to remove a key(C) & add new key values(D).
