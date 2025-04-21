using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_8Team
{
    public class Item
    {
        public string Name { get; set; }
        public int AttackBonus { get; set; }
        public int DefenseBonus { get; set; }
        public int Price { get; set; }

        public Item() { }

        public Item(string name, int atk, int def, int price)
        {
            Name = name;
            AttackBonus = atk;
            DefenseBonus = def;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name} (공격력 +{AttackBonus}, 방어력 +{DefenseBonus}, 가격: {Price}G)";
        }

    }
}
