using Lesson23.Models;
using System;
using System.Collections.Generic;

namespace Lesson23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lesson 23 interface - 2");

            var dog1 = new Dog("Male", "Raksas");
            var dog2 = new Dog("Female", "Dange");
            var dog3 = new Dog("Female", "Bandele");

            var cat1 = new Cat("Female", "Raine");
            var cat2 = new Cat("Male", "Ryzius");
            var cat3 = new Cat("Female", "Karamele");

            var bass1 = new Bass("Female", "Bass1");
            var bass2 = new Bass("Male", "Bass2");
            var carp1 = new Carp("Female", "Carp2");
            var carp2 = new Carp("Male", "Carp1");

            var listMammals = new List<IMammal>();
            var listAnimals = new List<IAnimal>();
            var listFish = new List<IFish>();

            listMammals.Add(dog1);
            listMammals.Add(dog2);
            listMammals.Add(dog3);
            listMammals.Add(cat1);
            listMammals.Add(cat2);
            listMammals.Add(cat3);
            listMammals.Add(carp1);
            listMammals.Add(carp2);
            listMammals.Add(bass1);
            listMammals.Add(bass1);

            var listMammalsBaby = new List<IMammal>();
            foreach (var mammal in listMammals)
            {
                listMammalsBaby.Add(mammal.GiveBirth());
            }
            var imammalComparer = new ImammalComparer();
            listMammals.AddRange(listMammalsBaby);
            listMammals.Sort(imammalComparer);

            listAnimals.Add(dog1);
            listAnimals.Add(dog2);
            listAnimals.Add(dog3);
            listAnimals.Add(cat1);
            listAnimals.Add(cat2);
            listAnimals.Add(cat3);
            foreach (var animal in listAnimals)
            {
                animal.Play();
                animal.Eat();
                animal.Play();
                animal.SLeep();
                animal.Eat();
                animal.SLeep();
                animal.Play();
            }
            listFish.Add(bass1);
            listFish.Add(carp2);
            listFish.Add(bass2);
            listFish.Add(carp1);
            foreach (var fish in listFish)
            {
                fish.Swim();
                fish.FindFood();
                fish.Swim();
                fish.Swim();
                fish.FindFood();
            }
                //////
                var triangle1 = new Triangle(15.5, 16.9);
            var quadrilateral1 = new Quadrilateral(5, 6);
            var pentagon1 = new Pentagon(8.8);
            var hexagon1 = new Hexagon(9);
            var listFigures = new List<IPolygon>();

            var emptyArray = new string[] { }; 
            var toFile = new FileWriterService("testFile.txt");
            toFile.WriteAllText(emptyArray);
            listFigures.Add(pentagon1);
            listFigures.Add(triangle1);
            listFigures.Add(quadrilateral1);
            listFigures.Add(hexagon1);
            var polygonAreaICompareble = new PolygonAreaICompareble();
            listFigures.Sort(polygonAreaICompareble);
            //////////
            var ListToFile = new List<IWriteableToFile>();
            ListToFile.Add(pentagon1);
            ListToFile.Add(triangle1);
            ListToFile.Add(quadrilateral1);
            ListToFile.Add(hexagon1);
            ListToFile.Add(dog1);
            ListToFile.Add(dog2);
            ListToFile.Add(dog3);
            ListToFile.Add(cat1);
            ListToFile.Add(cat2);
            ListToFile.Add(cat3);
            ListToFile.Add(carp1);
            ListToFile.Add(carp2);
            ListToFile.Add(bass1);
            ListToFile.Add(bass1);
           

            foreach (var item in ListToFile)
            {
                item.WriteToFile("testFile.txt");
            }
        }
    }
}
