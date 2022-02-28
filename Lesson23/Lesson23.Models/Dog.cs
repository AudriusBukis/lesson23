using System;
using System.Collections.Generic;

namespace Lesson23.Models
{
    public class Dog : IMammal, IAnimal, IWriteableToFile
    {
        public bool Hungry { get; set; }
        public string Species { get; internal set; }
        public bool Tired { get; set; }
        public string Gender { get;  set; }
        public string Name { get; set; }
        public Dog(string gender, string name)
        {
            Hungry = false;
            Tired = false;
            Species = "Dog";
            Gender = gender;
            Name = name;
        }    
        public void Eat()
        {
            if (Hungry == true) Hungry = false;
        }
        public IMammal GiveBirth()
        {
            
            if (Gender == "Female") 
            {
                Console.WriteLine($"Born female dog {Name}");
                return new Dog("Female", "Puppy");
            }
            else 
            {
                Console.WriteLine($"Born male cat {Name}");
                return new Dog("Male", "Puppy");
            }
        }
        public bool Play()
        {
            if (Tired == false)
            {
                Tired = true;
                Hungry = true;
                Console.WriteLine("Dog playing");
                return true;
            }
            else
            {
                Console.WriteLine("Dog is tired");
                return false;
            }
               
        }
        public bool SLeep()
        {
            if ((Tired == true) && (Hungry == false))
            {
                Tired = false;
                Hungry = true;
                Console.WriteLine("Dog sleeps");
                return true;
            }
            else
            {
                Console.WriteLine("Dog is not tired or hungry");
                return false;
            }

        }
        public override string ToString()
        {
            return $"{Species} : name {Name}, Gender {Gender}, is hungry {Hungry}, is tired {Tired}";
        }
        public void WriteToFile(string fileName)
        {
            var toFile = new FileWriterService(fileName);
            toFile.AppendText(ToString());
        }
    }
    public class DogComparer : IComparer<Dog>
    {
        int IComparer<Dog>.Compare(Dog x, Dog y)
        {
            return string.Compare(x.Name, y.Name);
        }
    }
}
