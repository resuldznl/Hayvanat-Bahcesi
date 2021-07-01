using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanatBahcesi
{
    class Wolf : Specie
    {
        public Wolf(Gender gender , SpecieType specie)
        {
            this.Gender = gender;
            this.MaxMove = 3;
            this.AttackRange = 4;
            SpecieType = specie;
            PreyList.Add(SpecieType.Sheep);
            PreyList.Add(SpecieType.Chicken);
            PreyList.Add(SpecieType.Rooster);
        }
    }
}