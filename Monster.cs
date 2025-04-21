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
        public int amount { get; set; }
        public bool isAlive => health > 0;

        public virtual void Attack(Monster target)
        {
            if (!isAlive)
            {
                Console.WriteLine($"{name}은(는) 사망 상태라 공격할 수 없습니다.");
                return;
            }

            if (!target.isAlive)
            {
                Console.WriteLine($"{target.name}은(는) 이미 사망했습니다. 공격 무효!");
                return;
            }

            int damage = attack - target.def;
            damage = Math.Max(0, damage);
            target.health -= damage;

            Console.WriteLine($"{name}이(가) {target.name}에게 {damage}의 피해를 입혔습니다!");

            if(target.health < 0)
            {
                target.health = 0;
                target.isAlive = false;
                Console.WriteLine($"{target.name}은(는) 쓰러졌습니다.");
            }
        }

    }
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

    public class Gongjungwi : Monster
{
    public Gongjungwi()
    {
        name = "공정위";
        level = 5;
        health = 50;
        attack = 30;
        def = 14;
        speed = 25;
        exp = 40;
        gold = 100;

    }
}
}