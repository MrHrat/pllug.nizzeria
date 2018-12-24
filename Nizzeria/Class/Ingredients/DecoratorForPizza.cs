using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nizzeria.Class.TypesOfPizza;

namespace Nizzeria.Class.Ingredients
{
    public abstract class DecoratorForPizza : Pizza
    {
        public Pizza pizza;
        public abstract override string GetDescription();
        public abstract override double Cost();

        public DecoratorForPizza(Pizza pizza)
        {
            this.pizza = pizza;
        }
    }
}
