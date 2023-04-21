namespace Zoopark.Animals
{
    public class Animal
    {
        public string Name { get; protected set; }

        public string Biom { get; protected set; }

        public double Mass { get; protected set; }

        public int Age { get; protected set; }

        public bool IsPredator { get; protected set; }


        public double FoodVolume { get; set; }

        protected double _square;

        public Animal(string name, double mass, int age, double foodVolume)
        {
            Name = name;
            Mass = mass;
            Age = age;
            FoodVolume = foodVolume;
            
        }

        public virtual void Say(string voice)
        {
            Console.WriteLine($"{Name}: {voice}");
        }

        public virtual void Eat()
        {
            Console.WriteLine($"{Name}: Я покушал");
        }

        public virtual void Voice()
        {
            Console.WriteLine($"{Name}: Я издаю звук");
        }

        public virtual void Play()
        {
            Console.WriteLine($"{Name}: Я играю");
        }
    }
}
