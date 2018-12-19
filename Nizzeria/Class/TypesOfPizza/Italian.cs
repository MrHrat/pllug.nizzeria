using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nizzeria.Class.TypesOfPizza
{
    public class Italian : Pizza
    {
        public Italian()
        {
            Description = "Pizza Italian";
        }

        public override double Cost()
        {
            return 1.48;
        }
    }
}
