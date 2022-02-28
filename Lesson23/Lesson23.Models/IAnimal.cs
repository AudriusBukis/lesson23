namespace Lesson23.Models
{
    public interface IAnimal
    {
        public bool Tired { get; set;}
        public void Eat();
        public bool Play();
        public bool SLeep();

    }
}
