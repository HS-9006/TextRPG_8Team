using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_8team
{
    internal class StartPage
    {
        //시작 화면
        public void StartGame()
        {
            Console.Clear();
            Console.WriteLine("스파르타 던전에 오신 여러분 환영합니다.\n이제 전투를 시작할 수 있습니다.\n");

            Console.WriteLine("1. 상태 보기\n2. 전투 시작\n");

            Console.WriteLine("원하시는 행동을 입력해주세요.");
            Console.Write(">>");

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. 상태 보기\n2. 전투 시작\n");

                Console.WriteLine("원하시는 행동을 입력해주세요.");
                Console.Write(">>");

                bool isChoiceNum = int.TryParse(Console.ReadLine(), out int choiceNum);

                //선택한 것이 숫자가 아니라면 실행
                if (!isChoiceNum)
                {
                    Console.WriteLine("잘못된 입력입니다");
                    continue;
                }
                //1~2의 값이 아니라면 실행
                if(choiceNum>2 || choiceNum<1)
                {
                    Console.WriteLine("잘못된 입력입니다");
                    continue;
                }

                StartChoice enumChoice = (StartChoice)choiceNum;

                switch(enumChoice)
                {
                    case StartChoice.Status:
                        break;
                    case StartChoice.Battle:
                        break;
                    default:
                        break;
                }
            }
        }

        enum StartChoice
        { 
            Status = 1,
            Battle
        }

    }
}
