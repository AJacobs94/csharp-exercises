using System.Collections.Generic;

using System;
using static Restaurant.MenuItem;
using static Restaurant.Menu;

namespace Restaurant
{
    class Program :Menu
    {
        static void Main(string[] args)
        {

            Menu newMenu = new Menu();
            MenuItem newItems = new MenuItem("Canneloni", 3.99, "Fried sweet pastry.",CategoryTypes.Dessert);
            MenuItem newItems1 = new MenuItem("Spaghetti", 9.99, "Noodles in Marinara sauce.", CategoryTypes.Main);

            newMenu.Add( newItems);
            newMenu.Add(newItems1);
            newMenu.PrintMenu();
            newItems.Print();


        }

    }
    
}


