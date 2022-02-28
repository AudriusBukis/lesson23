using System;
using System.Collections.Generic;


namespace Lesson23.Models
{
    public class Bass : IMammal, IFish, IWriteableToFile
    {
        public bool Hungry { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Species => "Bass";
        public Bass(string gender, string name)
        {
            Hungry = false;
            Name = name;
            Gender = gender;
        }
        public void FindFood()
        {
            if (Hungry) Hungry = false;
            Console.WriteLine("Bass found food");
        }
        public IMammal GiveBirth()
        {
            if (Gender == "Female")
            {
                Console.WriteLine($"Born female bass {Name}");
                return new Bass("Female", "Bass11");
            }
            else
            {
                Console.WriteLine($"Born male bass {Name}");
                return new Bass("Male", "Bass22");
            }
        }
        public bool Swim()
        {
            if (!Hungry)
            {
                Console.WriteLine($"Bass {Name} is swiming");
                return true;
            }
            else
            {
                Console.WriteLine($"Bass {Name} is hungry");
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
    public class BassComparer : IComparer<Bass>
    {
        int IComparer<Bass>.Compare(Bass x, Bass y)
        {
            return string.Compare(x.Name, y.Name);
        }
    }
}
