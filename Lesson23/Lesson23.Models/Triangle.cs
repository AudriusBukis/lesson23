namespace Lesson23.Models
{
    public class Triangle : IPolygon, IWriteableToFile
    {
        //rectangular triangle
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double Area { get; }
        public Triangle(double sideA, double sideB)
        {
            SideA = sideA;
            SideB = sideB;
            Area = GetArea();
        }
        public double GetArea()
        {
            return (SideA * SideB) / 2;
        }
        public override string ToString()
        {
            return $"rectangular triangle : sideA {SideA}, sideB {SideB} and Area = {Area}";
        }
        public void WriteToFile(string fileName)
        {
            var toFile = new FileWriterService(fileName);
            toFile.AppendText(ToString());
        }
    }
}
