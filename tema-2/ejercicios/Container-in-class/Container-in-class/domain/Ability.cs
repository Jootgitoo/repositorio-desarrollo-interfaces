using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Container_in_class.domain
{
    internal class Ability
    {
        public int id { get; set; }
        public String name { get; set; }
        public int point { get; set; }


        public Ability(String name)
        {
            this.id = 0;
            this.name = name;
            this.point = 100;
        }

        public Ability(String name, int points)
        {
            this.id = 0;
            this.name = name;
            this.point = points;
        }
    }
}
