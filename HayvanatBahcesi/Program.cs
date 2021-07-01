using System;
using System.Collections.Generic;
using System.Linq;

namespace HayvanatBahcesi
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Specie> gardenAnimals = new List<Specie>();




            gardenAnimals.AddRange(AnimalFactory.CreateAnimal(SpecieType.Cow, Gender.Male, 5));

            gardenAnimals.AddRange(AnimalFactory.CreateAnimal(SpecieType.Chicken, Gender.Male, 5));

            gardenAnimals.AddRange(AnimalFactory.CreateAnimal(SpecieType.Lion, Gender.Male, 4));

            gardenAnimals.AddRange(AnimalFactory.CreateAnimal(SpecieType.Cow, Gender.Female, 5));

            gardenAnimals.AddRange(AnimalFactory.CreateAnimal(SpecieType.Sheep, Gender.Male, 15));

            gardenAnimals.AddRange(AnimalFactory.CreateAnimal(SpecieType.Chicken, Gender.Female, 5));

            gardenAnimals.AddRange(AnimalFactory.CreateAnimal(SpecieType.Hunter, Gender.Male, 1));

            gardenAnimals.AddRange(AnimalFactory.CreateAnimal(SpecieType.Sheep, Gender.Female, 15));

            gardenAnimals.AddRange(AnimalFactory.CreateAnimal(SpecieType.Wolf, Gender.Male, 5));

            gardenAnimals.AddRange(AnimalFactory.CreateAnimal(SpecieType.Rooster, Gender.Female, 5));

            gardenAnimals.AddRange(AnimalFactory.CreateAnimal(SpecieType.Lion, Gender.Female, 4));

            gardenAnimals.AddRange(AnimalFactory.CreateAnimal(SpecieType.Rooster, Gender.Male, 5));

            gardenAnimals.AddRange(AnimalFactory.CreateAnimal(SpecieType.Wolf, Gender.Female, 5));

            
          

            
            

          


            var alibabaFarm = new Garden(new Area(new Size(1, 500), new Size(500, 1 )));
           
            alibabaFarm.PushAnimalToGarden(gardenAnimals);

            for (int i = 0; i < 1000; i++)
            {
                alibabaFarm.executeRound();
            }


            alibabaFarm.remainingAnimals();
            


        }
    }
}