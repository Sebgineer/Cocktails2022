using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails2022
{
    internal class Glass
    {
        public int id { get; set; }
        public string GlassType { get; set; }
        public Blend Blend { get; set; }

        public Glass(string GlassType)
        {
            this.GlassType = GlassType;
        }

        public Glass(string GlassType, Blend Blend) : this(GlassType)
        {
            this.Blend = Blend;
        }
        public Glass()
        {

        }
    }
}
