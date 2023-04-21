using Zoopark.Animals;

ElephantAnimal elephant = new ElephantAnimal("Petya", 2000, 15, 300);

PenguinAnimal penguin = new PenguinAnimal("Zuzu", 550, 35, 200);

TigerAnimal tiger = new TigerAnimal("Simba", 780, 78, 400);

LionAnimal lion = new LionAnimal("Matilda", 1500, 106, 700);

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