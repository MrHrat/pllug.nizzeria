using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nizzeria.Class.TypesOfPizza
{
    public class NullPizza : Pizza
    {
        public NullPizza() : base("Not selected pizza") { }

        public override double Cost()
        {
            return 0;
        }
    }
}
