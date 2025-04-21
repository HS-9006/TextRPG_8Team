using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Text.Json;

namespace TextRPG_8Team
{
    public class Player
    {
        public string Name;
        public JobType Job = JobType.Warrior;
        public int Level = 1;

        // 기본 능력치
        public int BaseAttack = 10;
        public int BaseDefense = 5;
        public int MaxHP = 100;
        public int CurrentHP = 100;
        public int Gold = 1500;

        //아이템 장착으로 변한 능력치
        public int BonusAttack => EquippedItems.Sum(item => item.AttackBonus);
        public int BonusDefense => EquippedItems.Sum(item => item.DefenseBonus);

        //최종 능력치
        public int TotalAttack => BaseAttack + BonusAttack;
        public int TotalDefense => BaseDefense + BonusDefense;

        public List<Item> Inventory = new List<Item>();
        public List<Item> EquippedItems = new List<Item>();

        //직업에 따라 능력치 조절해주기 전사가 기본 스텟이니까 도적과 마법사만 조절
        //밸런스 공격력 1당 최대체력 -5, 방여력 -0.5(내림)
        public void ApplyJobStats()
        {
            switch (Job)
            {
                case JobType.Thief:
                    BaseAttack += 2;
                    BaseDefense -= 1;
                    MaxHP -= 10;
                    break;
                case JobType.Mage:
                    BaseAttack += 5;
                    BaseDefense -= 2;
                    MaxHP -= 25;
                    break;
            }

            CurrentHP = MaxHP;
        }
    }

    public enum JobType
    {
        Warrior,    // 전사
        Thief,      // 도적
        Mage        // 마법사
    }
}