using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Restaurant.MenuItem;

namespace Restaurant
{

    class Menu 
    {
        public List<MenuItem> Items { get; set; } = new List<MenuItem>();
        private DateTime AddedOn { get; set; }
        // public bool NewItems { get; set; }

        public Menu()
        {
            List<MenuItem> items  = new List<MenuItem>();
            DateTime addedOn = DateTime.Now;
            Items = items;
            AddedOn = addedOn;
        }

        public void PrintMenu() 
        {
            foreach (MenuItem item in Items)
            {
                 item.Print();
            }
        }
        
        public void PrintCategory(CategoryTypes category)
        {
            if ( category == CategoryTypes.Appetizer)
            {
                foreach(MenuItem item in Items)
                {
                    if(item.Category == CategoryTypes.Appetizer)
                    {
                        Console.WriteLine(item.ToString());
                    }
                }
            }
            if (category == CategoryTypes.Main)
            {
                foreach (MenuItem item in Items)
                {
                    if (item.Category == CategoryTypes.Main)
                    {
                        Console.WriteLine(item.ToString());
                    }
                }
            }
            if (category == CategoryTypes.Dessert)
            {
                foreach (MenuItem item in Items)
                {
                    if (item.Category == CategoryTypes.Dessert)
                    {
                        Console.WriteLine(item.ToString());
                    }
                }
            }
        }

        public void Add(MenuItem addItem)
        {
            Items.Add(addItem);
            AddedOn = DateTime.Today;
        }

        

        public void Remove(MenuItem toRemove)
        {
            Items.Remove(toRemove);
        }

        public override string ToString()
        {
            string menuString = "";
            foreach(MenuItem item in Items)
            {
                menuString += item.ToString();
            }
            menuString += "Last Updated:" + AddedOn;
            return menuString;
        }
        
         public bool IsNew()
        {
            
           {
             return Items.Any(x => x.NewItem());
           }
         }

    }
}
