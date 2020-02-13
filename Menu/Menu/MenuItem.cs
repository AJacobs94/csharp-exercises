using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class MenuItem
    {
        private int dateEdit { get; set; }
        public string Description { get; set; }
        public bool IsNew { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public enum Category { Appetizer, Main, Dessert}
    }
}
