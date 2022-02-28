using System;
using System.Collections.Generic;


namespace Lesson23.Models
{
    public class Carp : IMammal, IFish, IWriteableToFile
    {
        public bool Hungry { get ; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Species => "Carp";
        public Carp(string gender, string name)
        {
            Hungry = false;
            Name = name;
            Gender = gender;
        }
        public void FindFood()
        {
            if (Hungry) Hungry = false;
            Console.WriteLine("Carp found food");
        }
        public IMammal GiveBirth()
        {
            if (Gender == "Male") 
            {
                Console.WriteLine($"Born female carp {Name}");
                return new Carp("Female", "Carp13");
            }
            else
            {
                Console.WriteLine($"Born male carp {Name}");
                return new Carp("Male", "Carp23");
            }
        }
        public bool Swim()
        {
            if (!Hungry)
            {
                Console.WriteLine($"Carp {Name} is swiming");
                return true;
            }
            else
            {
                Console.WriteLine($"Carp {Name} is hungry");
                return false;
            }
        }
        public override string ToString()
        {
            return $"{Species} : name {Name}, Gender {Gender}, is hungry {Hungry}";
        }

        public void WriteToFile(string fileName)
        {
            var toFile = new FileWriterService(fileName);
            toFile.AppendText(ToString());
        }
    }
    public class CarpComparer : IComparer<Carp>
    {
        int IComparer<Carp>.Compare(Carp x, Carp y)
        {
            return string.Compare(x.Name, y.Name);
        }
    }
}
