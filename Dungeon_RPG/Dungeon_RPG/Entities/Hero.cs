using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_RPG.NewFolder
{
    public class Hero
    {

        public string Name;
        public int Level;
        public string HeroType;

        //método
        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType;
        }

        //método
        public virtual string Attack()
        {
            return this.Name + " atacou com sua espada";
        }

        public Hero(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public Hero()
        {

        }


    }


}

