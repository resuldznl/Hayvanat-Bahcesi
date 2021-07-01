using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanatBahcesi
{

    class AnimalFactory
    {
        public static List<Specie> CreateAnimal(SpecieType specie, Gender gender, int count = 1)
        {
            List<Specie> animals = new();
            Specie animal = null;
            for (int i = 0; i < count; i++)
            {
                

                switch (specie)
                {

                    case SpecieType.Chicken:
                        animal = new Chicken(gender, specie);
                        break;
                    case SpecieType.Sheep:
                        animal = new Sheep(gender, specie);
                        break;
                    case SpecieType.Cow:
                        animal = new Cow(gender, specie);
                        break;
                    case SpecieType.Lion:
                        animal = new Lion(gender, specie);
                        break;
                    case SpecieType.Rooster:
                        animal = new Rooster(gender, specie);
                        break;
                    case SpecieType.Wolf:
                        animal = new Wolf(gender , specie);
                        break;
                    case SpecieType.Hunter:
                        animal = new Hunter(gender, specie);
                        break;
                }

                if (animal != null)
                {
                    animals.Add(animal);
                }
            }
            animal.Notification(specie, count, gender);

            return animals;
        }

    }
}