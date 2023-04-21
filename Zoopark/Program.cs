using Zoopark.Animals;

Animal elephant = new Animal("Petya", 2000, 15, 300);

Animal penguin = new Animal("Zuzu", 550, 35, 200);

Animal tiger = new Animal("Simba", 780, 78, 400);

Animal lion = new Animal("Matilda", 1500, 106, 700);

elephant.Say("Auf!");
penguin.Say("Dddd!");
tiger.Say("Rrrr!");
lion.Say("Rrr!");
Console.WriteLine();

elephant.Eat();
elephant.Voice();
elephant.Play();
Console.WriteLine();

penguin.Eat();
penguin.Voice();
penguin.Play();
Console.WriteLine();

tiger.Eat();
tiger.Voice();
tiger.Play();
Console.WriteLine();

lion.Eat();
lion.Voice();
lion.Play();
Console.WriteLine();