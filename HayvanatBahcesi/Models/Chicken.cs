using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanatBahcesi
{
    class Chicken : Specie
    {
        public Chicken(Gender gender, SpecieType specie)
        {
            this.Gender = gender;
            SpecieType = specie;
            this.MaxMove = 1;
        }

    }
}
