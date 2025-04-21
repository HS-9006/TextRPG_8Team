using System.Security.Cryptography.X509Certificates;

namespace TextRPG_8team
{
    internal class Program
    {
        static StartPage startPage = new StartPage();
        static void Main(string[] args)
        {
            startPage.StartGame();
        }
    }
}
