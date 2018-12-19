using Nizzeria.Class.TypesOfPizza;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nizzeria.Class.Ingredients
{
    public class ChickenFillet : DecoratorForPizza
    {
        public ChickenFillet(Pizza pizza)
        {
            this.pizza = pizza;
        }

        public override string GetDescription()
        {
            return pizza.GetDescription() + ", Chicken Fillet";
        }

        public override double Cost()
        {
            return pizza.Cost() + 0.32;
        }
    }
}
