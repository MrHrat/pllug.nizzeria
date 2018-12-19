using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nizzeria.Class.TypesOfPizza
{
    public abstract class Pizza
    {
        private string _description = "Unknown Pizza";
        public string Description
        {
            set
            {
                _description = value;
            }
        }
        public virtual string GetDescription()
        {
            return _description;
        }

        public abstract double Cost();
    }
}
