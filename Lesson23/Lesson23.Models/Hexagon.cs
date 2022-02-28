using System;

namespace Lesson23.Models
{
    public class Hexagon : IPolygon , IWriteableToFile
    {
        public double SideLenght { get; set; }
        public double Area { get; }
        public Hexagon(double sideLenght)
        {
            SideLenght = sideLenght;
            Area = GetArea();
        }
        public double GetArea()
        {
            return (3 * Math.Sqrt(3) * Math.Pow(SideLenght, 2)) / 2;
        }
        public override string ToString()
        {
            return $"Hexagon : side lenght {SideLenght} and Area = {Area}";
        }

        public void WriteToFile(string fileName)
        {
            var toFile = new FileWriterService(fileName);
            toFile.AppendText(ToString());
        }
    }
}
