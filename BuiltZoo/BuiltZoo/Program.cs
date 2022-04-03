using System;

namespace BuiltZoo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******************************************************");
            Console.WriteLine("*************** Welcome To Hanan's ZOO ***************");
            Console.WriteLine("**************** HANAN NATHEM SAADEH *****************");
            Console.WriteLine("******************************************************");
            Console.WriteLine();

            // we Can't creat objects from Abstract Classes (Animals/Mmals/Birds/Fish)


            // Create new object from Tiger Class
            Tiger tigar1 = new Tiger();
            tigar1.Name = "Tigaroo";
            tigar1.Age = 5;
            tigar1.Weight = 60;
            tigar1.NumOfLegs = 4;
           Console.WriteLine( tigar1.Sleep());
            tigar1.Eat();
            Console.WriteLine(tigar1.Sound());
            tigar1.BreastFeeding();
            Console.WriteLine(tigar1.Carnivores());
            Console.WriteLine($"the {tigar1.Name} has {tigar1.NumOfLegs} legs " + "and his age: "+ tigar1.Age + " years old and his wight is: "+ tigar1.Weight + "KG");

            Console.WriteLine();
            Console.WriteLine("******************************************************");
            // Create new object from Kangaroo Class

            Kangaroo kangaroo1 = new Kangaroo();
            kangaroo1.Name = "Kangara";
            kangaroo1.Age = 10;
            kangaroo1.Weight = 50;
            kangaroo1.NumOfLegs = 2;
            Console.WriteLine(kangaroo1.Sleep());
            kangaroo1.Eat();
            Console.WriteLine(kangaroo1.Sound());
            kangaroo1.BreastFeeding();
            kangaroo1.Marsupials();
            Console.WriteLine($"the {kangaroo1.Name} has {kangaroo1.NumOfLegs} legs " + "and his age: " + kangaroo1.Age + " years old and his wight is: " + kangaroo1.Weight + "KG");

            Console.WriteLine();
            Console.WriteLine("******************************************************");
            // Create new object from Shark Class

            Shark shark = new Shark();
            shark.Name = "Shesho:)";
            shark.Age = 11;
            shark.Weight = 800;
            shark.SwimSpeed = 100;
            shark.NumberOfFins = 2;
            Console.WriteLine(shark.Sleep());
            shark.Eat();
            Console.WriteLine(shark.Sound());
            shark.Predators();
            Console.WriteLine($"the {shark.Name} has {shark.NumberOfFins} fins " + "and his age: " + shark.Age + " years old and his wight is: " + shark.Weight + "KG");

            Console.WriteLine();
            Console.WriteLine("******************************************************");
            // Create new object from ClownFish Class

            ClownFish clown = new ClownFish();
            clown.Name = "Clone";
            clown.Age = 4;
            clown.Weight = 3;
            clown.NumberOfFins = 2;
            clown.SwimSpeed = 50;
            clown.Color = "Orange & White";
            Console.WriteLine(clown.Sleep());
            clown.Eat();
            Console.WriteLine(clown.Sound());
            clown.Striped();
            Console.WriteLine($"the {clown.Name} has {clown.NumberOfFins} fins " + "and his age: " + clown.Age + " years old and his wight is: " + clown.Weight + "KG");

            Console.WriteLine();
            Console.WriteLine("******************************************************");

            // Create new object from parrot Class
            Parrot parrot1 = new Parrot();
            parrot1.Name = "Paroot";
            parrot1.Age = 6;
            parrot1.Weight = 4;
            Console.WriteLine(parrot1.Sleep());
            parrot1.Eat();
            Console.WriteLine(parrot1.Sound());
            parrot1.Fly();
            parrot1.ImitateSpeech();
            Console.WriteLine($"the {parrot1.Name} can fly " + "and his age: " + parrot1.Age + " years old and his wight is: " + parrot1.Weight + "KG");

            // Polymorphism call sleep method and it will call sleep method which is in parrot class not in the parent class
            Animals parrot = new Parrot();
            Console.WriteLine("this is Polymorphism ");

            Console.WriteLine( parrot.Sleep());







        }
    }
}
