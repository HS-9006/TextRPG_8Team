using System.Security.Cryptography.X509Certificates;
using TextRPG_8Team.TextRPG_8team.TextRPG_8team;

namespace TextRPG_8team
{
    internal class Program
    {
        static StartPage StartPage = new StartPage();
        static Player Player = new Player();
        static void Main(string[] args)
        {
            StartPage.StartGame(Player);
        }
    }
}
