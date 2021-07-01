namespace HayvanatBahcesi{

    public class Hunter : Specie
    {
        
        public Hunter(Gender gender, SpecieType specie)
        {
            this.Gender = gender;
            this.MaxMove = 1;
            this.AttackRange = 8;
            SpecieType = specie;
            PreyList.Add(SpecieType.Sheep);
            PreyList.Add(SpecieType.Chicken);
            PreyList.Add(SpecieType.Rooster);
            PreyList.Add(SpecieType.Lion);
            PreyList.Add(SpecieType.Cow);
            PreyList.Add(SpecieType.Wolf);
        }

    }
}