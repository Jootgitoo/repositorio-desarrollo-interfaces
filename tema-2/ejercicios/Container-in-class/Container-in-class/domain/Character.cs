using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Container_in_class.domain
{

    internal class Character
    {
        public int id { get; set; }
        public String name { get; set; }
        public int points { get; set; }

        public int idCounter { get; set; }


        public Character(string name, int id = 0, int points = 0) 
        {
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show($"\"{nameof(name)}\"Can´t be null.", nameof(name));
                throw new ArgumentException($"\"{nameof(name)}\"Can´t be null.", nameof(name));
            }

            this.id = id;
            this.name = name;
            this.points = points;
            this.idCounter++;

        }

        public override string ToString() {
            return name;
        }



    }
    
}
