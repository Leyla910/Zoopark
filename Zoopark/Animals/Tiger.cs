namespace Zoopark.Animals
{
    public class TigerAnimal:Animal
    {
        public TigerAnimal(string name, double mass, int age, double foodVolume):base(name, mass, age, foodVolume)
        {
            Biom = "Tayga";
            
            IsPredator = true;
            _square = 10;
        }
    }
}