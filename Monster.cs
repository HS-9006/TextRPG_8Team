using System;
namespace TextRPG_8Team
{
    public class Monster
    {
        public string name;
        public int level;
        public int health { get; set; }
        public int attack { get; set; }
        public int def { get; set; }
        public int speed { get; set; }
        public int exp { get; set; }
        public int gold { get; set; }
        public bool isAlive => health > 0;
    }

    public class Ssalsoong : Monster
    {
        public Ssalsoong()
        {
            name = "쌀숭이";
            level = 1;
            health = 30;
            attack = 10;
            def = 5;
            speed = 15;
            exp = 10;
            gold = 5;
        }
    }

    public class Reshoongjwak : Monster
    {
        public Reshoongjwak()
        {
            name = "리슝좍";
            level = 2;
            health = 35;
            attack = 15;
            def = 7;
            speed = 20;
            exp = 15;
            gold = 10;
        }
    }
}