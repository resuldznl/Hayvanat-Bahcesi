using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanatBahcesi
{
    class Cow : Specie
    {
        public Cow(Gender gender , SpecieType species)
        {
            this.Gender = gender;
            SpecieType = species;
            this.MaxMove = 2;
        }
    }
}
