namespace Zoopark.Animals
{
    public class Elephant
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

        public bool IsPredator { get; private set; }


        public double FoodVolume { get; set; }

        private double _square;

        public Elephant(string name, double mass, int age, double foodVolume)
        {
            Name = name;
            Biom = "Desert";
            Mass = mass;
            Age = age;
            FoodVolume = foodVolume;

            IsPredator = false;
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