using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nizzeria.Class.TypesOfPizza
{
    public class Chicago : Pizza
    {
        public Chicago()
        {
            Description = "Pizza Chicago";
        }

        public override double Cost()
        {
            return 1.26;
        }
    }
}
