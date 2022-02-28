using System.Collections.Generic;

namespace Lesson23.Models
{
    public interface IMammal
    {
        public bool Hungry { get; set; }
        public string Species { get; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public IMammal GiveBirth();
    }
    public class ImammalComparer : IComparer<IMammal>
    {
        int IComparer<IMammal>.Compare(IMammal x, IMammal y)
        {
            return string.Compare(x.Name, y.Name);
        }
    }
}
