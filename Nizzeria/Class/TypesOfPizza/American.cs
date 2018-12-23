using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nizzeria.Class.TypesOfPizza
{
    public class American : Pizza
    {
        public American() : base("Pizza American") { }

        public override double Cost()
        {
            return 1.16;
        }
    }
}
