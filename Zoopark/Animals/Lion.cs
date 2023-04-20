namespace Zoopark.Animals
{
    public class Lion:Animal
    {
        public Lion(string name, double mass, int age, double foodVolume):base(name, mass, age, foodVolume)
        {
            Biom = "Desert";

            IsPredator = true;
            _square = 10;
        }
    }
}
