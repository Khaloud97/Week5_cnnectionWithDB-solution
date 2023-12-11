using Week5_cnnectionWithDB.MyDbContext;

namespace Week5_cnnectionWithDB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            ApplicationDbContext db = new ApplicationDbContext();
        }
    }
}