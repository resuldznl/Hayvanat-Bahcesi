using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanatBahcesi
{
    public abstract class Specie
    {
        public Location location { get; private set; }
        protected Garden currentGarden;
        
        public List<SpecieType> PreyList { get; set; } = new List<SpecieType>();

        
        public int AttackRange { get; set; } = 0;

        protected void SetLocation(Location location)
        {
            this.location = location;
        }
        public void Notification(SpecieType specie, int count , Gender gender)
        {
            Console.WriteLine(count +" "+ gender + " " + specie + " were created");
        }
        public void SetGarden(Garden garden)
        {
            currentGarden = garden;

            var rand = new Random();
           
            var randomXLocation = rand.Next(currentGarden.Area.TopLeftCorner.X, currentGarden.Area.BottomRightCorner.X);
            var randomYLocation = rand.Next(currentGarden.Area.BottomRightCorner.Y, currentGarden.Area.TopLeftCorner.Y);

            this.location = new Location(randomXLocation, randomYLocation);
        }

        public void KillAnotherSpecie(SpecieType type)
        {
            IsAlive = false;
            Console.WriteLine(type + " killed");
        }

        public void GoToNextRandomSpot()
        {
            var rand = new Random();

            var newLocation = new Location(location.X, location.Y);
            for (int i = 0; i < this.MaxMove; i++)
            {
                int startLocationX = newLocation.X, startLocationY = newLocation.Y;

                switch (rand.Next(1, 5))
                {
                    //Yukarı
                    case 1:
                        startLocationY++;
                        break;
                    //Sağa
                    case 2:
                        startLocationX++;
                        break;
                    //Aşağı
                    case 3:
                        startLocationY--;
                        break;
                    //Sola
                    case 4:
                        startLocationX--;
                        break;
                }

                if (this.currentGarden.IsInArea(startLocationX, startLocationY))
                    newLocation = new Location(startLocationX, startLocationY);
            }

            SetLocation(newLocation);
        }

        public virtual void Attack()
        {
            var animalsOnRange = this.currentGarden.GetAnimalsOnArea(location,AttackRange);

            var animalToHunt = animalsOnRange.Where(w => PreyList.Contains(w.SpecieType)).ToList();

            foreach (var animal in animalToHunt)
            {
                animal.KillAnotherSpecie(animal.SpecieType);
            }
           
        }
        public virtual void GetAnimals()
        {
            var animals = this.currentGarden.GetAnimalsOnArea(location);

            var oppositeGender = this.Gender == Gender.Male ? Gender.Female : Gender.Male;

            var animalforspawning = animals.Where(p => SpecieType == p.SpecieType && p.Gender == oppositeGender ).ToList();



            foreach (var item in animalforspawning)
            {
                var random = new Random();
                switch (random.Next(1, 3))
                {
                    case 1:
                   this.currentGarden.PushAnimalToGarden(AnimalFactory.CreateAnimal(SpecieType, Gender.Female, 1));
                    break;
                    case 2:
                   this.currentGarden.PushAnimalToGarden(AnimalFactory.CreateAnimal(SpecieType, Gender.Male, 1));
                    break;
                }
            }

        }

       
        protected Gender Gender { get; set; }
        protected SpecieType SpecieType { get; set; }
        protected int MaxMove { get; set; }

        
        public bool IsAlive { get; private set; } = true;


    }
}