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

        public override void Say(string voice)
        {
            Console.WriteLine($"{Name}: {voice}");
        }

        public override void Eat()
        {
            Console.WriteLine($"{Name}: Я Пингвин, я покушал!");
        }

        public override void Voice()
        {
            Console.WriteLine($"{Name}: Я Пингвин, я издаю звук!");
        }

        public override void Play()
        {
            Console.WriteLine($"{Name}: Я Пингвин, я играю!");
        }
    }
}
