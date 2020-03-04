using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restaurant
{
    class MenuItem 
    {
        private DateTime AddedOn { get; set; }
        public string Description { get; set; }
        
        public string Name { get; set; }
        public double Price { get; set; }
        public CategoryTypes Category { get; set; }
        public enum CategoryTypes { Appetizer, Main, Dessert}

        public bool NewItem()
        {
            if (AddedOn.Date <= DateTime.Now.Date.AddMonths(-3))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            string itemString = "$"+ Price + " "+Name + "-" + Description +"\n Item added on:"+ AddedOn;
            return itemString;
        }

        public MenuItem(string name, double price, string description, CategoryTypes category)
        {
            Name = name;
            Price = price;
            Description = description;
            Category = category;
            AddedOn = DateTime.Now;
    
           
        }

        public void Print()
        {
            Console.WriteLine(ToString());
        }

        public override bool Equals(Object obj)
        {
            if (obj == this)
            {
                return true;
            }
            if ((obj == null) || (obj.GetType() != GetType()))
            {
                return false;
            }
         MenuItem menuitemObj = obj as MenuItem;
            return Name == menuitemObj.Name;
        }
    }
    }

