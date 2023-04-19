namespace Zoopark.Animals
{
    public class Penguin
    {
        public string Name
        {
            get
            {
                return Name;
            }
            set
            {
                if (Name.Length == 0)
                {
                    throw new ArgumentException();
                }
            }
        }

        public string Biom { get; private set; }

        public double Mass { get; private set; }

        public int Age { get; private set; }

        public string Predator { get; private set; }

        public string Herbivore { get; private set; }

        public double FoodVolume { get; set; }

        private double _square;

        public Penguin(string name, string biom, double mass, int age, double foodVolume)
        {
            Name = name;
            Biom = biom;
            Mass = mass;
            Age = age;
            FoodVolume = foodVolume;

            _square = 10;
        }

        public void Say(string voice)
        {
            Console.WriteLine($"{Name}: {voice}");
        }

        public void Eat()
        {
            Console.WriteLine($"{Name}: Я покушал");
        }

        public void Voice()
        {
            Console.WriteLine($"{Name}: Я издаю звук");
        }

        public void Play()
        {
            Console.WriteLine($"{Name}: Я играю");
        }
    }
}
