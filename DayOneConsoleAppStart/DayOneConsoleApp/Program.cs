using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DayOneConsoleAppLogic;

namespace DayOneConsoleApp
{
    class Program
    {
        private static Animal myStaticAnimal;
        private static Animal myOtherStaticAnimal;
        private static Jail tempJail = new Jail();
        private static Inventory jacobsMurse = new Inventory(5,2);
        #region privateStaticMethods
        private static void outputAnimalInfo(Animal animal)
        {
            Console.WriteLine(string.Format("The animal named {0} is now {1} days old. They are the color {2}.", animal.Name, animal.DayzOld, animal.GetMyAnimalColor()));
        }
        private static void jailPrompt(Jail superAwesomeJail)
        {
            Console.WriteLine("Welcome to the super awesome Jail! Please input the number of villains and your superhero name so we can track the latest hero");
            int numOfVillains = int.Parse(Console.ReadLine());
            string heroName = Console.ReadLine();
            superAwesomeJail.acceptVillains(numOfVillains, heroName);
            //superAwesomeJail.villainCount();            
            Console.WriteLine("The number of villains in jail right now is: " + superAwesomeJail.villainCount());
            Console.WriteLine("The last superhero to return villains was: " + heroName);

        }
        private static void helloWorld()
        {
            string firstName = string.Empty;
            Console.WriteLine("Hello World");
            Console.WriteLine("What is your name?");
            firstName = System.Console.ReadLine();
            Console.WriteLine("Hello " + firstName);
            Console.ReadLine();
        }
        private static void doMath()
        {
            int numToSquare = 4;
            Console.WriteLine("The square of " + numToSquare + " is " + MathHelper.SquareInput(numToSquare));
            Console.WriteLine(string.Format("The square of {0} is {1}", numToSquare, MathHelper.SquareInput(numToSquare)));
            Console.WriteLine(MathHelper.Quotient(7, 4));
        }
        
        /* private static void createAnimals()
         {
             Animal animal = new Animal("Steve", 5600f);
             animal.DayzOld = 0;
             animal.Eat(6);
             animal.Sleep();
             animal.MakeNoise();
             Animal.Color = "Blue";

             Animal otherAnimal = new Animal("Hankie", 6f);
             otherAnimal.DayzOld = 5;
             otherAnimal.Eat(4);
             otherAnimal.Sleep();
             otherAnimal.MakeNoise();
             Animal.Color = "Red";

             myStaticAnimal = new Animal("George", 120f);
             myStaticAnimal.DayzOld = 4;
             Animal.Color = "Green";

             myOtherStaticAnimal = new Animal("Barf", 310f);
             myOtherStaticAnimal.DayzOld = 0;
             // animal.DayzOld = 2;

             for (int i = 0; i < 100; i++)
             {
                 animal.GetOlder();
                 //animal.DayzOld = 2;
                 // Console.WriteLine(string.Format("The animal named {0} is now {1} days old. They are the color {2}.", animal.Name, animal.DayzOld, animal.GetMyAnimalColor()));
                 otherAnimal.GetOlder();
                 //Console.WriteLine(string.Format("The animal named {0} is now {1} days old. They are the color {2}.", otherAnimal.Name, otherAnimal.DayzOld, otherAnimal.GetMyAnimalColor()));
                 myStaticAnimal.GetOlder();
                 //Console.WriteLine(string.Format("The animal named {0} is now {1} days old. They are the color {2}.", myStaticAnimal.Name, myStaticAnimal.DayzOld, myStaticAnimal.GetMyAnimalColor()));
                 myOtherStaticAnimal.GetOlder();
                 outputAnimalInfo(animal);
                 Console.ForegroundColor = ConsoleColor.Blue;
                 outputAnimalInfo(otherAnimal);
                 Console.ForegroundColor = ConsoleColor.Red;
                 Console.BackgroundColor = ConsoleColor.DarkMagenta;
                 outputAnimalInfo(myStaticAnimal);
                 Console.ForegroundColor = ConsoleColor.Green;
                 Console.BackgroundColor = ConsoleColor.Black;
                 outputAnimalInfo(myOtherStaticAnimal);
                 //Console.WriteLine(string.Format("The animal named {0} is now {1} days old. They are the color {2}.", myOtherStaticAnimal.Name, myOtherStaticAnimal.DayzOld, myOtherStaticAnimal.GetMyAnimalColor()));
             }
             Console.WriteLine(string.Format("{0}{1}{2}{3}", myStaticAnimal.DayzOld, myOtherStaticAnimal.DayzOld, animal.DayzOld, otherAnimal.DayzOld));
             Console.BackgroundColor = ConsoleColor.Yellow;
             //animal.Name = "Not Steve";
             Console.Write(animal.Name + " ");
             Console.WriteLine(animal.CurrentWeight);
         }*/
        private static void createSuperheroes()
        {
            Superhero firstHero = new Superhero("Spiderman");
            Superhero secondHero = new Superhero("Spiderman", "Whining all the time");
            Superhero thirdHero = new Superhero("Spiderman", "Not Gotham", 0);
            Console.WriteLine("Our Superheros name is " + firstHero.Name);
            Console.WriteLine(secondHero.Name + " has the superpower of " + secondHero.Superpower);
            Console.WriteLine(thirdHero.Name + " fights crime in " + thirdHero.City + " and has a total of " + thirdHero.NumberOfSidekicks + " friends... I mean sidekicks.");

        }
        private static void createPhysicists()
        {
            Physicist physics = new Physicist("Quantum Optics", "Dr. Richard Feynman", 48);

            Console.WriteLine(physics.ScientistName + " studied in the field of " + physics.FieldOfStudy
                + " with " + physics.NumberOfPublications + " publications to his name.");
        }
        private static void createBears()
        {
            Bear bear1 = new Bear("Steve");
            Bear bear2 = new Bear("Thomas");
            Bear bear3 = new Bear("Juan");

            Console.WriteLine("We have 3 bears, they are named: {0}, {1}, {2}.", bear1.Name, bear2.Name, bear3.Name);
            BrownBear brownBear1 = new BrownBear("Not Michael");
            Console.WriteLine("We have 1 bear named {0}.", brownBear1.Name);
            Console.WriteLine("Is the bear out fishing?");
            string bearOutFishing = System.Console.ReadLine();
            Console.WriteLine(bear1.GoneFishing(bearOutFishing));
            Console.ReadLine();
        }
        private static void createSidekicks()
        {
            Sidekick sidekick1 = new Sidekick("Cleft: the Boy Chin Wonder", "Slingshotting");
            Console.WriteLine("{0} {1}", sidekick1.Name, sidekick1.Superpower);
        }
        private static void createJails()
        {
            Jail superAwesomeJail = new Jail();
            jailPrompt(superAwesomeJail);
            //superAwesomeJail.acceptVillains(numOfVillains, heroName);
            //Console.WriteLine("The number of villains in jail right now is: " + numOfVillains);
            //Console.WriteLine("The last superhero to return villains was: " + heroName);
            //Console.WriteLine()
        }
        private static void createLions()
        {
            Lion lion1 = new Lion("Simba", 125);
            Console.WriteLine(lion1.ScareOffHyenas());
            Console.WriteLine("How many lions are entering the pride? ");
            int LionsEnteringPride = int.Parse(Console.ReadLine());
            lion1.AcceptLionToPride(LionsEnteringPride);
            Console.WriteLine("The number of lions in the pride is: " + lion1.LionsCurrentlyInPride());
        }
        private static void createCars()
        {
            Car car1 = new Car("Black", 1, 5, 4, 6, 13.2f);
            car1.AcceptPassenger(2);
            Console.WriteLine(car1.NumPassengers());
            Console.ReadLine();
        }

     
        private static void createNonEquippableItem()
        {
            Item potion = new NonEquippableItem("Blue Potion",1,2);
        }

        private static void funWithArrays()
        {
            int[] simpleArray = new int[3];
            simpleArray[0] = 45;
            simpleArray[1] = 2;
            simpleArray[2] = 1012;
            for (int i = 0; i < simpleArray.Length; i++)
            {
                Console.WriteLine("The values in simpleArray are " + simpleArray[i]);

            }
            int[,] multidimensionalArray = new int[2, 2];
            multidimensionalArray[0, 0] = 58;
            multidimensionalArray[0, 1] = 27;
            multidimensionalArray[1, 0] = 44;
            multidimensionalArray[1, 1] = -8;
            //multidimensionalArray[2, 0] = 23;

            for (int i = 0; i < multidimensionalArray.GetLength(0); i++)
            {
                for (int j = 0; j < multidimensionalArray.GetLength(1); j++)
                {
                    Console.WriteLine("The values in the multidimensionalArray are " + multidimensionalArray[i, j]);
                }
            }
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[5] { 0, 1, 2, 3, 4 };
            jaggedArray[1] = new int[4] { 8, 9, 10, 11 };
            jaggedArray[2] = new int[2] { 15, 16 };

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.WriteLine("The values in the jaggedArray are " + jaggedArray[i][j]);
                }
            }


            Console.ReadLine();
        }

        private static void arrayOfObjects()
        {
            Car[] cars = new Car[3];

            cars[0] = new Car("Black", 1, 5, 4, 6, 13.2f);
            cars[1] = new Car("White", 1, 5, 4, 6, 16.0f);
            cars[2] = new Car("Silver", 2, 4, 4, 6, 12.0f);

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i].ToString());
            }
            Console.ReadLine();
        }

        private static void arrayOfAnimals()
        {
            Animal[] animals = new Animal[3];

            animals[0] = new Bear("Steve", 6500.3f);
            animals[1] = new Lion("Scar", 120.8f);
            animals[2] = new Tiger("Tony", 210.9f);

            for (int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine(animals[i].ToString());
            }
            Console.ReadLine();
        }

        static void createMatrices()
        {
            Random rand = new Random(4);
            int rows = 2;
            int columns = 7;
            int[,] createdMatrix = MathHelper.CreateMatrix(rows,columns);

            for (int i = 0; i < createdMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < createdMatrix.GetLength(1); j++)
                {
                    createdMatrix[i, j] = rand.Next(0, 11);
                    Console.WriteLine(string.Format("The element at row {0} and column {1} has a value of {2}",i,j,createdMatrix[i, j]));
                }
            }
            Console.ReadLine();
        }

        static void createItems()
        {
            jacobsMurse.ChangeItem(new Item("Potion", 1, 1),true);
            jacobsMurse.ChangeItem(new Item("shield", 1, 1),true);
            jacobsMurse.ChangeItem(new Item("stuff", 1, 1),true);
            jacobsMurse.ChangeItem(new Item("garbage", 1, 1),true);
            jacobsMurse.ChangeItem(new Item("sword", 1, 1),true);

        }



        static void createVillain()
        {
            string tempName = string.Empty;
            string tempEvilPower = string.Empty;
            string tempEmblem = string.Empty;
            string tempPrimaryColor = string.Empty;
            string tempSecondaryColor = string.Empty;

            Console.WriteLine("What is the inmate's name: ");
            tempName = System.Console.ReadLine();
            Console.WriteLine("What is their evil power?: ");
            tempEvilPower = System.Console.ReadLine();
            Console.WriteLine("What emblem do they use to distinguish themself?: ");
            tempEmblem = System.Console.ReadLine();
            Console.WriteLine("What is the primary color of their disguise?: ");
            tempPrimaryColor = System.Console.ReadLine();
            Console.WriteLine("What is the secondary color of their disguise?: ");
            tempSecondaryColor = System.Console.ReadLine();

            
            

            Villain tempVillain = new Villain(tempName, tempEvilPower, tempEmblem, tempPrimaryColor, tempSecondaryColor);
            Villain villain2 = new Villain(tempName, tempEvilPower, tempEmblem, tempPrimaryColor, tempSecondaryColor);
            Villain villain3 = new Villain(tempName, tempEvilPower, tempEmblem, tempPrimaryColor, tempSecondaryColor);

            tempJail.PlaceVillain(tempVillain);
            tempJail.PlaceVillain(villain2);
            tempJail.PlaceVillain(villain3);




        }

        private static void CreateGarages()
        {
            Garage[] garages = new Garage[3];
            Garage garage1 = new Garage(4);
            Garage garage2 = new Garage(100);
            Garage garage3 = new Garage(20);

            garages[0] = garage1;
            garages[1] = garage2;
            garages[2] = garage3;
        }




       // private static int jailCapacity = 10;
        //private static string[] arrayForJail = new string[jailCapacity];

        //static string[] PlaceVillain()
       // {
        //    return arrayForJail;
        //}


        #endregion privateStaticMethods

        static void Main(string[] args)
        {

            //helloWorld();
            //doMath();
            //createAnimals();
            //createSuperheroes();
            //createPhysicists();
            //createBears();
            //createSidekicks();
            //createJails();
            //createLions();
            //arrayOfAnimals();
            //createCars();
            //createNBATeam();
            //funWithArrays();
            //arrayOfObjects();
            //createMatrices();
            createItems();
            jacobsMurse.AdjustWidthDimension(8);
            jacobsMurse.AdjustHeightDimension(6);
            
            //createNonEquippableItem();
            //Console.WriteLine(PlaceVillain());
            //Console.WriteLine(arrayForJail);
            //Console.ReadLine();
            //createVillain();
            // Console.WriteLine()
            Console.ReadLine();
        }
    }
}
