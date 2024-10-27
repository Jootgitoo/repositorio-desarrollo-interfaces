using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Containers.domain
{
    internal class Character
    {
        public static int cont = 0;
        public int id { get; set; } 
        public String name { get; set; }
        public int points { get; set; }
    
        List<Ability> abilities { get; set; }

        public Character (String name)
        {
            this.id = cont++;
            this.name = name;
           this.points = 100;
            abilities = new List<Ability>();
        }

        public void addList(Ability a)
        {
            abilities.Add(a);
        }

    }
}
