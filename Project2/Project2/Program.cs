using System;
using System.Threading;
using System.Threading.Tasks;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("□□□□□□□□□□");
            Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine("■□□□□□□□□□");
            Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine("■■□□□□□□□□");
            Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine("■■■□□□□□□□");
            Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine("■■■■□□□□□□");
            Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine("■■■■■□□□□□");
            Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine("■■■■■■□□□□");
            Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine("■■■■■■■□□□");
            Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine("■■■■■■■■□□");
            Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine("■■■■■■■■■□");
            Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine("■■■■■■■■■■");
            Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine("엘든링 온라인");

            string input;

            float actionRuinSkillDamage;
            float actionCardGaugeGet;
            float actionUltimateDamage;
            int actionMaxMana;
            int actionBattlingManaCharge;
            int actionNotBattlingManaCharge;
            float actionSpeed;
            float actionRideSpeed;
            float actionCarrySpeed;
            float actionCoolSkill;

            Console.WriteLine("루인 스킬 피해(floatValue) : ");
            input = Console.ReadLine(); actionRuinSkillDamage = float.Parse(input);
            Console.WriteLine("카드 게이지 획득량(floatValue) : ");
            input = Console.ReadLine(); actionCardGaugeGet = float.Parse(input);
            Console.WriteLine("각성기 피해(floatValue) : ");
            input = Console.ReadLine(); actionUltimateDamage = float.Parse(input);
            Console.WriteLine("최대 마나(intValue) : ");
            input = Console.ReadLine(); actionMaxMana = int.Parse(input);
            Console.WriteLine("전투 중 마나 회복량(intValue) : ");
            input = Console.ReadLine(); actionBattlingManaCharge = int.Parse(input);
            Console.WriteLine("비전투 중 마나 회복량(intValue) : ");
            input = Console.ReadLine(); actionNotBattlingManaCharge = int.Parse(input);
            Console.WriteLine("이동 속도(floatValue) : ");
            input = Console.ReadLine(); actionSpeed = float.Parse(input);
            Console.WriteLine("탈 것 속도(floatValue) : ");
            input = Console.ReadLine(); actionRideSpeed = float.Parse(input);
            Console.WriteLine("운반 속도(floatValue) : ");
            input = Console.ReadLine(); actionCarrySpeed = float.Parse(input);
            Console.WriteLine("스킬 재사용 대기시간 감소(floatValue) : ");
            input = Console.ReadLine(); actionCoolSkill = float.Parse(input);
            Console.Clear();

            Console.WriteLine("------------------활동------------------");
            Console.WriteLine($"루인 스킬 피해 : {actionRuinSkillDamage}%");
            Console.WriteLine($"카드 게이지 획득량 : {actionCardGaugeGet}%");
            Console.WriteLine($"각성기 피해 : {actionUltimateDamage}%");
            Console.WriteLine($"최대 마나 : {actionMaxMana}");
            Console.WriteLine($"전투 중 마나 회복량 : {actionBattlingManaCharge}");
            Console.WriteLine($"비전투 중 마나 회복량 : {actionNotBattlingManaCharge}");
            Console.WriteLine($"이동 속도 : {actionSpeed}%");
            Console.WriteLine($"탈 것 속도 : {actionRideSpeed}%");
            Console.WriteLine($"운반 속도 : {actionCarrySpeed}%");
            Console.WriteLine($"스킬 재사용 대기시간 감소 : {actionCoolSkill}%");





        }
    }
}