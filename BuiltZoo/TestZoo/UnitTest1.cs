using System;
using Xunit;
using BuiltZoo;

namespace TestZoo
{
    public class UnitTest1

    {
        Tiger tiger1 = new Tiger();
        Kangaroo Kangaroo1 = new Kangaroo();
        Shark Shark1 = new Shark();
        ClownFish ClownFish1 = new ClownFish();
        Parrot Parrot1 = new Parrot();
        Mammals mammal1 = new Mammals();

        [Fact]
        public void TestNumOfLegsTiger()
        {
            Assert.Equal(4, tiger1.NumOfLegs);
        }
        [Fact]
        public void TestTigerName()
        {
            Assert.Equal("Tiger", tiger1.Name);
        }
        [Fact]
        public void TestKangarooLegFromMammals()
        {
            Assert.Equal(2, mammal1.NumOfLegs);

        }
        [Fact]
        public void TestTigerSleep()
        {
            Assert.Equal("Tiger Class Say : All Tigers Sleepping", tiger1.Sleep());
        }
        [Fact]
        public void TestKangarooWight()
        {
            Assert.Equal(30, Kangaroo1.Weight);
        }
        [Fact]
        public void TestKangarooEat()
        {
            Assert.Equal("Kangaroo Class Say : All Kangaroo has a sound and it is like (chortle)", Kangaroo1.Sound());
        }
        [Fact]

        public void TestKangarooMarsupials()
        {
            Assert.Equal("Kangaroo Class Say : Kangaroo animal is a Marsupials", Kangaroo1.Marsupials());
        }
        [Fact]

        public void TestFishNumberOfFins()
        {
            Assert.Equal(2, Shark1.NumberOfFins);
        }
        [Fact]

        public void TestFishSwim()
        {
            Assert.Equal("Fish Class Say : This Fish can Swim", Shark1.Swim());
        }
        [Fact]

        public void TestsharkSwimSpeed()
        {
            Assert.Equal(500, Shark1.SwimSpeed);
        }
        [Fact]

        public void TestsharkPredators()
        {
            Assert.Equal("Shark Class Say : Sharks are Predators", Shark1.Predators());
        }

        [Fact]
        public void TestClownFishColor()
        {

            Assert.Equal("Orange and white", ClownFish1.Color);
        }
        [Fact]
        public void TestClownFishNumberOfFins()
        {

            Assert.Equal(2, ClownFish1.NumberOfFins);
        }
        [Fact]
        public void TestParrotImitateSpeech()
        {

            Assert.Equal("Parrot Class Say : Parrots ImitateSpeech", Parrot1.ImitateSpeech());
        }
        [Fact]
        public void TestParrotParrot()
        {

            Assert.Equal("Parrot", Parrot1.Name);
        }
        //Test For interfaces
        [Fact]
        public void TestImplementIpreyInterfaceClownFish()
        {
            Assert.Equal("The ClownFish runs away !! ", ClownFish1.Flee());
        }
        [Fact]
        public void TestImplementIpreyInterfaceKangaroo()
        {
            Assert.Equal("It is runs away !! ", Kangaroo1.Flee());
        }
        [Fact]
        public void TestImplementIpreyInterfaceParrot()
        {
            Assert.Equal("The Parrot runs away !! ", Parrot1.Flee());
        }
        [Fact]
        public void TestImplementIpredatorInterfaceShark()
        {
            Assert.Equal("The shark searching for a food", Shark1.Hunt());
        }
        [Fact]
        public void TestImplementIpredatorInterfaceTiger()
        {
            Assert.Equal("It is searching for a food", tiger1.Hunt());
        }
        [Fact]
        public void TestPolymorphism()
        {

            Mammals Tiger = new Tiger();
            Assert.Equal("Tiger Class Say : All Tigers Sleepping", Tiger.Sleep());
        }
        [Fact]
        public void TestPolymorphism2()
        {

            Birds ParrotSweet = new Parrot();

            Assert.Equal(1, ParrotSweet.Age);
        }
        [Fact]
        public void TestInheretance()
        {
            // Test inheritance.
            Mammals mammal1 = new Mammals();
            Assert.Equal("Mammals Class Say : All Mammals Sleepping", mammal1.Sleep());
            Assert.Equal(2, mammal1.NumOfLegs);
        }
        [Fact]
        public void IsAnimal()
        {
            //test if tiger is animal
            Assert.True(tiger1 is Animals);
        }
        [Fact]
        public void ParrotIsAnimal()
        {
            //test if parrot  is animal
            Assert.True(Parrot1 is Animals);
        }

    }
}
