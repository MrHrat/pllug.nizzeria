using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nizzeria.Class.TypesOfPizza
{
    public abstract class Pizza
    {
        public string Description { set; get; } = "Unknown Pizza";
        public virtual string GetDescription()
        {
            return Description;
        }

        public Pizza() { }

        public Pizza(string Name)
        {
            Description = Name;
        }

        public abstract double Cost();
    }
}
