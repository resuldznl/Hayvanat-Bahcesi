using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanatBahcesi
{
    class Sheep : Specie
    {

        public Sheep(Gender gender, SpecieType specie)
        {
            this.Gender = gender;
            SpecieType = specie;
            this.MaxMove = 2;
            
        }
       
    }
}
