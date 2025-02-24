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

            // //기본 특성
            // int Attack = 16755;
            // int MaxHealth = 78103;

            // //전투 특성
            // int trait_Fatal = 36; //치명
            // int trait_Special = 1017; //특화
            // int trait_Subdue = 41; //제압
            // int trait_Swift = 611; //신속
            // int trait_Persev = 22; //인내
            // int trait_Train = 39; //숙련

            // Console.WriteLine("----------기본 특성----------");
            // Console.WriteLine("공격력 : " + Attack);
            // Console.WriteLine("최대 생명력 : " + MaxHealth);

            // Console.WriteLine("\r\n----------전투 특성----------");
            // Console.WriteLine("치명 : " + trait_Fatal);
            // Console.WriteLine("특화 : " + trait_Special);
            // Console.WriteLine("제압 : " + trait_Subdue);
            // Console.WriteLine("신속 : " + trait_Swift);
            // Console.WriteLine("인내 : " + trait_Persev);
            // Console.WriteLine("숙련 : " + trait_Train);

            // int intValue = 100; long longValue = 1234567890L; float flValue = 0.4f; double dblValue = 3.1415926535;
            // Console.WriteLine("intValue : " + intValue);
            // Console.WriteLine("longValue : " + longValue);
            // Console.WriteLine("flValue : " + flValue);
            // Console.WriteLine("dblValue : " + dblValue);

            // byte byteValue = 1; //byte는 1~ sbyte가 -n~
            // ushort ushortValue = 2;
            // uint uintValue = 9999;
            // sbyte sbyteValue = -128;
            // Console.WriteLine("byteValue : " + byteValue);
            // Console.WriteLine("ushortValue : " + ushortValue);
            // Console.WriteLine("uintValue : " + uintValue);
            // Console.WriteLine("sbyteValue : " + sbyteValue);

            // float singlePre = 3.14f;
            // double doublePre = 3.14;
            // decimal decimalPre = 3.14m;
            // Console.WriteLine("singlePre : " + singlePre);
            // Console.WriteLine("doublePre : " + doublePre);
            // Console.WriteLine("decimalPre : " + decimalPre);

            // string greeting = "Hello World";
            // string name = "Alice";
            // Console.WriteLine(greeting + " " + name);

            // //Console.Write => \n미적용 Console.WriteLine => \n적용
            // Console.Write("1"); Console.WriteLine("2"); Console.WriteLine("3");

            // bool isGo = false;
            // Console.WriteLine("isGo : " + isGo);
            
            // Int32 number = 123;
            // String text = "Hello";
            // Boolean flag = true;
            // Console.WriteLine("number : " + number);
            // Console.WriteLine("text : " + text);
            // Console.WriteLine("flag : " + flag);

            // int intostr = 123;
            // string intostring = intostr.ToString();
            // Console.WriteLine("intostring : " + intostring);
            // bool flag = true;
            // string flagAsString = flag.ToString();
            // Console.WriteLine("flagAsString : " + flagAsString);

            //이진수
            // Console.WriteLine("2진수를 입력하시오");
            // string Two = Console.ReadLine();
            // int twoChange = Convert.ToInt32(Two, 2);
            // string tenChange = Convert.ToString(twoChange, 2);
            // Console.WriteLine($"{twoChange}");
            // Console.WriteLine($"{tenChange}");

            // //var
            // var name = "Alice"; //이러면 var가 알아서 string으로 저장시킴
            // var isTime = false;
            // var Time = 360;
            // Console.WriteLine($"{name}은/는 {Time}second에 도착했고 늦었냐 물어보면 {isTime}이다.");

            //default 값이 기본값으로 설정된다
            // int a = default; //dafault = 0
            // string b = default; //dafault = null
            // bool c = default; //dafault = false
            // Console.WriteLine($"{a}, {b}, {c}");

            // //산술연산자
            // int a = 1;
            // int b = 2;
            // int sum = a + b; // %=나눈거 나머지
            // Console.WriteLine($"a({a}) + b({b}) : {sum}");
            // //관계연산자
            // a = 1;
            // b = 2;
            // bool c = (a == b); //woooow
            // Console.WriteLine($"a({a}) == b({b}) : {c}");
            // //단항연산자
            int number = 5;
            Console.WriteLine(number~);



        }
    }
}