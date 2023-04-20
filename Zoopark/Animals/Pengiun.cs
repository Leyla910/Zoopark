namespace Zoopark.Animals
{
    public class PenguinAnimal:Animal
    {
        public PenguinAnimal(string name, double mass, int age, double foodVolume):base(name, mass, age, foodVolume)
        {
            Biom = "Tropics";

            IsPredator = false;
            _square = 10;
        }
    }
}
