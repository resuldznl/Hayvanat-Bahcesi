using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanatBahcesi
{
    class Lion : Specie
    {
        public Lion(Gender gender , SpecieType specie)
        {
            this.Gender = gender;
            this.MaxMove = 4;
            SpecieType = specie;
            this.AttackRange = 5;
            PreyList.Add(SpecieType.Cow);
            PreyList.Add(SpecieType.Sheep);
        }

    }
}
