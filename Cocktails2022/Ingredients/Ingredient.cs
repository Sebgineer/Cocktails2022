using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails2022
{
    internal abstract class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Amount { get; set; }

        public Ingredient(string Name, double Amount)
        {
            this.Name = Name;
            this.Amount = Amount;
        }

        public Ingredient()
        {

        }
    }
}
