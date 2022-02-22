using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails2022
{
    internal class Blend
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Ingredient> Ingredients { get; set; }

        public Blend(string Name, List<Ingredient> Ingredients)
        {
            this.Name = Name;
            this.Ingredients = Ingredients;
        }

        public Blend()
        {

        }
    }
}
