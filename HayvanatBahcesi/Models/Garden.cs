using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanatBahcesi
{
    public class Garden
    {
        public Area Area { get; private set; }
        public List<Specie> GardenAnimals { get; private set; } = new();
        public Garden(Area area)
        {
            if (area.TopLeftCorner.X < area.BottomRightCorner.X &&
            area.TopLeftCorner.Y > area.BottomRightCorner.Y)
                Area = area;
            else
                throw new Exception("CANNOT CREATE A GARDEN : AREA IS NOT VALID");
        }

        public void PushAnimalToGarden(List<Specie> gardenAnimals)
        {
            if (gardenAnimals != null && gardenAnimals.Count > 0)
                GardenAnimals.AddRange(gardenAnimals);

            gardenAnimals.ForEach(animal => animal.SetGarden(this));

        }

        public void executeRound()
        {
            GardenAnimals.ForEach(animal => animal.GoToNextRandomSpot());
            foreach (var item in GardenAnimals)
            {
                if (item.AttackRange > 0)
                {
                    item.Attack();
                }
            }

            for (int i = 0; i < GardenAnimals.Count; i++)
            {
                GardenAnimals[i].GetAnimals();
            }

            

        }

        public List<Specie> GetAnimalsOnArea(Location location , int attackRange)
        {

            
            return GardenAnimals.Where(animal =>
             animal.IsAlive == true && IsInArea(animal.location, location , attackRange)
            ).ToList();
        }
        public List<Specie> GetAnimalsOnArea(Location location)
        {
            
            return GardenAnimals.Where(animal =>
             animal.IsAlive == true && IsInArea(animal.location, location)
            ).ToList();
        }
        public bool IsInArea(Location spicieLocation, Location location)
        {
            bool LocationIsValid = false;
          

            int x = location.X - spicieLocation.X;
            int y = location.Y - spicieLocation.Y;
            var xUs = Math.Pow(x, 2);
            var yUs = Math.Pow(y, 2);

            var result = Math.Sqrt((xUs + yUs));
           

        
            LocationIsValid = (result <= 3);


            return LocationIsValid;
        }

        public bool IsInArea(Location spicieLocation, Location location , int attackRange)
        {
            bool LocationIsValid = false;


            int x = location.X - spicieLocation.X;
            int y = location.Y - spicieLocation.Y;
            var xUs = Math.Pow(x, 2);
            var yUs = Math.Pow(y, 2);

            var result = Math.Sqrt((xUs + yUs));



            LocationIsValid = (result <= attackRange);


            return LocationIsValid;

        }

        public bool IsInArea(int spicieLocationX, int spicieLocationY)
        {
            bool xLocationIsValid = false;
            bool yLocationIsValid = false;

            xLocationIsValid = (spicieLocationX >= this.Area.TopLeftCorner.X && spicieLocationX <= this.Area.BottomRightCorner.X);
            yLocationIsValid = (spicieLocationY >= this.Area.BottomRightCorner.Y && spicieLocationY <= this.Area.TopLeftCorner.Y);


            return xLocationIsValid && yLocationIsValid;
        }

        public void remainingAnimals()
        {
            Console.WriteLine("Number of Animals Remaining: " + GardenAnimals.Count(p => p.IsAlive && !p.GetType().Name.Contains("Hunter")));
        }

    }
}