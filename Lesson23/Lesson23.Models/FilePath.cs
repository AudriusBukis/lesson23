namespace Lesson23.Models
{
    public class FilePath
    {
        public string FileName { get; private set; }
        public string Path { get; private set; }
        public FilePath(string fileName)
        {
            FileName = fileName;
            Path = $@"C:\Users\audri\Documents\Code_Academy_mokymai\lesson23\Lesson23\Lesson23\{FileName}";
            //C:\Users\asus\Desktop\Lesson23\Lesson23
            //C:\Users\audri\Documents\Code_Academy_mokymai\lesson23\Lesson23\Lesson23
        }
    }
}
