

namespace Lesson23.Models
{
    public class Quadrilateral : IPolygon, IWriteableToFile
    {
        public double Width { get; set; }
        public double Length { get; set; }
        public double Area { get; }

        public Quadrilateral(double width, double length)
        {
            Width = width;
            Length = length;
            Area = GetArea();
        }

        public double GetArea()
        {
            return  Width * Length;
        }
        public override string ToString()
        {
            return $"Quadrilatera : width {Width}, length {Length} and Area = {Area}";
        }

        public void WriteToFile(string fileName)
        {
            var toFile = new FileWriterService(fileName);
            toFile.AppendText(ToString());
        }
    }
}
 
