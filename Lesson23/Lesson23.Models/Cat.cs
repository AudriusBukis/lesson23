using System;
using System.Collections.Generic;

namespace Lesson23.Models
{
    public class Cat : IMammal, IAnimal, IWriteableToFile
    {
        public bool Hungry { get; set; }
        public string Species { get; internal set; }
        public bool Tired { get; set; }
        public string Name { get; set; }
        public string Gender { get;  set; }
        public Cat(string gender, string name)
        {
            Hungry = false;
            Tired = false;
            Species = "Cat";
            Gender = gender;
            Name = name;
        }
        public void Eat()
        {
            if (Hungry == true) Hungry = false;
        }
        public IMammal GiveBirth()
        {

            if (Gender == "Male")
            {
                Console.WriteLine($"Born female cat {Name}");
                return new Cat("Female", "Kitten");
            }
            else
            {
                Console.WriteLine($"Born male cat {Name}");
                return new Cat("Male", "Kitten");
            }
        }
        public bool Play()
        {
            if (Tired == false)
            {
                Tired = true;
                Hungry = true;
                Console.WriteLine("Cat playing");
                return true;
            }
            else
            {
                Console.WriteLine("Cat is tired");
                return false;
            }

        }
        public bool SLeep()
        {
            if ((Tired == true) && (Hungry == false))
            {
                Tired = false;
                Hungry = true;
                Console.WriteLine("Cat sleeps");
                return true;
            }
            else
            {
                Console.WriteLine("Cat is not tired or hungry");
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
    public class CatComparer : IComparer<Cat>
    {
        int IComparer<Cat>.Compare(Cat x, Cat y)
        {
            return string.Compare(x.Name, y.Name);
        }
    }
}
