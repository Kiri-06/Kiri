using System;

namespace Program
{
    class Programd
    {
        static void Main(string[] args)
        {
            // //캐릭터
            // //hp
            // //att
            // //캐릭터이름
            // //등급
            // double cht_hp = 100;
            // double cht_att = 56.7;
            // string cht_name = "Tomas";
            // char cht_rank = 'S';
            // Console.WriteLine("Character");
            // Console.WriteLine("Hp : " + cht_hp);
            // Console.WriteLine("Att : " + cht_att);
            // Console.WriteLine("Name : " + cht_name);
            // Console.WriteLine("Rank : " + cht_rank);

            // int x = 10, y = 20, z = 30;
            // Console.WriteLine("x : " + x);
            // Console.WriteLine("y : " + y);
            // Console.WriteLine("z : " + z);

            // const double Pi = 3.141592;
            // Console.WriteLine("Pi : " + Pi);
            // // !error to "Pi = 3.14;"

            //기본 특성
            int Attack = 16755;
            int MaxHealth = 78103;

            //전투 특성
            int trait_Fatal = 36; //치명
            int trait_Special = 1017; //특화
            int trait_Subdue = 41; //제압
            int trait_Swift = 611; //신속
            int trait_Persev = 22; //인내
            int trait_Train = 39; //숙련

            Console.WriteLine("----------기본 특성----------");
            Console.WriteLine("공격력 : " + Attack);
            Console.WriteLine("최대 생명력 : " + MaxHealth);

            Console.WriteLine("\r\n----------전투 특성----------");
            Console.WriteLine("치명 : " + trait_Fatal);
            Console.WriteLine("특화 : " + trait_Special);
            Console.WriteLine("제압 : " + trait_Subdue);
            Console.WriteLine("신속 : " + trait_Swift);
            Console.WriteLine("인내 : " + trait_Persev);
            Console.WriteLine("숙련 : " + trait_Train);


            
            

        }
    }
}