namespace Animals
{
    using Animals;
    using Exceptions;
    using System;
    using System.Collections.Generic;

    public class AnimalsEntryPoint
    {
        // using polymorphism - pass more specific object ro a method that expects a parameter of more generic type
        public static void SayAnimalName(IAnimal animal)
        {
            //// this is anti QPC => Don't do it!
            //if (animal is Cat)
            //{
            //    var animalAsCat = animal as Cat;
            //    Console.WriteLine(animalAsCat.Purr());
            //}

            Console.WriteLine(animal.Name);
        }

        public static void Main()
        {
            // polymorphism - we use given data type through other data type (interface or parent class)
            IAnimal cat = new Cat("Dzhoni", 7);
            IAnimal dog = new Dog("Sharo", 5);

            Console.WriteLine(cat.Speak());
            Console.WriteLine(dog.Speak());

            // no polymorphism
            var secondCat = new Cat("Dzhinks", 3);
            Cat thirdCat = new Cat("Fluffy", 1);

            Console.WriteLine(secondCat.Purr());
            Console.WriteLine(thirdCat.Purr());
            // cat has no Purr() method, because it's IAnimal

            var secondDog = new Dog("Doggy", 3);
            Dog thirdDog = new Dog("Spike", 4);

            Console.WriteLine(secondDog.CatchBone());
            Console.WriteLine(thirdDog.CatchBone());
            // dog has no CatchBone() method, because it's IAnimal

            Console.WriteLine();

            // without polymorphism
            List<Cat> cats = new List<Cat>();
            cats.Add(secondCat);
            cats.Add(thirdCat);

            List<Dog> dogs = new List<Dog>();
            dogs.Add(secondDog);
            dogs.Add(thirdDog);

            foreach (var curCat in cats)
            {
                Console.WriteLine(curCat.Speak());
            }

            foreach (var curDog in dogs)
            {
                Console.WriteLine(curDog.Speak());
            }

            Console.WriteLine();

            // using polymorphism - mix different related types in the same collection
            List<IAnimal> animals = new List<IAnimal>();
            animals.Add(cat);
            animals.Add(secondCat);
            animals.Add(thirdCat);
            animals.Add(dog);
            animals.Add(secondDog);
            animals.Add(thirdDog);

            foreach (var curAnimal in animals)
            {
                Console.WriteLine(curAnimal.Speak());
            }

            Console.WriteLine();

            // using polymorphism - invoke abstract operations
            SayAnimalName(cat);
            SayAnimalName(secondCat);
            SayAnimalName(thirdCat);
            SayAnimalName(dog);
            SayAnimalName(secondDog);
            SayAnimalName(thirdDog);

            Console.WriteLine();

            // using polymorphism - declare a more generic field which will be initialized and "specialized" later
            IAnimal animal;
            string animalType = "Cat";
            switch (animalType)
            {
                case "Cat": { animal = new Cat("Puh", 1); Console.WriteLine(animal.Name); break; }
                case "Dog": { animal = new Dog("Snoop", 1); Console.WriteLine(animal.Name); break; }
                default:
                    break;
            }

            Console.WriteLine();

            // polymorphism
            Animal fourthCat = new Cat("Sam", 5);
            Animal fourthDog = new Dog("Chestar", 4);

            Console.WriteLine(fourthCat.ToString());//Animals.Animals.Cat
            Console.WriteLine(fourthDog.ToString());//I'm a dog.

            Console.WriteLine(fourthCat.Age);
            Console.WriteLine(fourthDog.Age);

            Kitten kitten = new Kitten("Baby", 1);
            Console.WriteLine(kitten.Speak());

            Console.WriteLine();

            try
            {
                Animal oldCat = new Cat("Oldi", 150);
            }
            catch (InvalidAnimalAgeException ex)    // defined exception class in folder Exceptions
            {
                Console.WriteLine(ex.MinAge);
                Console.WriteLine(ex.MaxAge); 
            }
 
        } 
    }
}