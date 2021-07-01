using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanatBahcesi
{
    class Rooster : Specie
    {
        public Rooster(Gender gender, SpecieType specie)
        {
            this.Gender = gender;
            SpecieType = specie;
            this.MaxMove = 1;
        }

    }
}
