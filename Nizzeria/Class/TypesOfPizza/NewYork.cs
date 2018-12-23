using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nizzeria.Class.TypesOfPizza
{
    public class NewYork : Pizza
    {
        public NewYork() : base("Pizza New-York") { }

        public override double Cost()
        {
            return 1.02;
        }
    }
}
