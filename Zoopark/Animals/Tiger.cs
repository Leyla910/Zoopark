namespace Zoopark.Animals
{
    public class TigerAnimal:AbstractAnimal
    {
        public TigerAnimal(string name, double mass, int age, double foodVolume):base(name, mass, age, foodVolume)
        {
            Biom = "Tayga";
            
            IsPredator = true;
            _square = 10;
        }


        public override void Say(string voice)
        {
            Console.WriteLine($"{Name}: {voice}");
        }

        public override void Eat()
        {
            Console.WriteLine($"{Name}: Я Тигр, я покушал!");
        }

        public override void Voice()
        {
            Console.WriteLine($"{Name}: Я Тигр, я издаю звук!");
        }

        public override void Play()
        {
            Console.WriteLine($"{Name}: Я Тигр, я играю!");
        }
    }
}