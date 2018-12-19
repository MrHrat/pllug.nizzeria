using Nizzeria.Class.TypesOfPizza;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nizzeria.Class.Ingredients
{
    public class Ham : DecoratorForPizza
    {
        public Ham(Pizza pizza)
        {
            this.pizza = pizza;
        }

        public override string GetDescription()
        {
            return pizza.GetDescription() + ", Ham";
        }

        public override double Cost()
        {
            return pizza.Cost() + 0.34;
        }
    }
}
