using System;

namespace Lesson23.Models
{
    public class Pentagon : IPolygon, IWriteableToFile
    {
        public double SideLenght { get; set; }
        public double Area { get; }
        public Pentagon(double sideLenght)
        {
            SideLenght = sideLenght;
            Area = GetArea();
        }
        public double GetArea()
        {
            return Math.Sqrt(25 + 10 * Math.Sqrt(5)) / 4 * Math.Pow(SideLenght, 2);
        }
        public override string ToString()
        {
            return $"Pentagon : side lenght {SideLenght} and Area = {Area}";
        }

        public void WriteToFile(string fileName)
        {
            var toFile = new FileWriterService(fileName);
            toFile.AppendText(ToString());
        }
    }
}
