using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nizzeria.Class.TypesOfPizza;

namespace Nizzeria.Class.Ingredients
{
    public class Cheese : DecoratorForPizza
    {
        public Cheese(Pizza pizza)
        {
            this.pizza = pizza;
        }

        public override string GetDescription()
        {
            return pizza.GetDescription() + ", Cheese";
        }

        public override double Cost()
        {
            return pizza.Cost() + 0.25;
        }
    }
}
