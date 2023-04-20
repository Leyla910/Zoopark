namespace Zoopark.Animals
{
    public class ElephantAnimal:Animal
    {
        public ElephantAnimal(string name, double mass, int age, double foodVolume):base(name, mass, age, foodVolume)
        {
            Biom = "Desert";
            
            IsPredator = false;
            _square = 10;
        }
    }
}