using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Program
{
    class Programd
    {
        static async Task Main(string[] args)
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
            // int a = 10;
            // int b = 3;
            // int sum = a + b; // %=나눈거 나머지
            // Console.WriteLine(a + b);
            // Console.WriteLine(a - b);
            // Console.WriteLine(a * b);
            // Console.WriteLine(a / b);
            // Console.WriteLine(a % b);
            // Console.WriteLine($"a({a}) + b({b}) : {sum}");
            // //관계연산자
            // a = 1;
            // b = 2;
            // bool c = (a == b); //woooow
            // Console.WriteLine($"a({a}) == b({b}) : {c}");
            // //단항연산자
            // int number = 5;
            // Console.WriteLine(number);
            // //변환연산자
            // double pi = 3.1415926535;
            // int intPi = (int)pi; //같은 int끼리해야 오류안남 소수경우 내림 판정
            // Console.WriteLine($"intPi : {intPi}"); 

            //
            // int a = 1;
            // int b = 2;
            // int sum = a + b;
            // float average;
            // average = sum / 2f;
            // Console.WriteLine("평균 : " + average);

            //추출시 string 공간
            // string name = "Alice";
            // string name2 = "Bob";
            // Console.WriteLine("name : " + name + " " + name2);

            // //할당연산자
            // int a = default;
            // a += 5; a -= 3; a *= 3; a /= 3;
            // Console.WriteLine("a : " + a);

            /*문제 1. 학점 평균 계산 프로그램
            설명:
            국어, 영어, 수학 점수를 사용자로부터 입력받아 총점과 평균을 구하는 프로그램을 작성하세요.
            요구사항:

            각 과목의 점수는 정수형으로 입력받습니다.
            총점을 구한 후, 평균을 계산할 때 정수형 총점을 실수형으로 캐스팅하여 소수점까지 정확하게 계산합니다.
            평균은 소수점 둘째 자리까지 출력하세요.
            문제 2. 비트 반전(~) 연산자 활용 프로그램
            설명:
            사용자로부터 정수를 입력받아, 해당 정수의 모든 비트를 반전(~)한 결과를 출력하는 프로그램을 작성하세요.
            요구사항:

            정수를 입력받습니다.
            비트 반전 연산자(~)를 이용하여 입력된 정수의 비트를 반전합니다.
            원래의 값과 비트 반전 후의 값을 함께 출력합니다.*/

            // int scoreKorean, scoreEnglish, scoreMath;
            // int scoreSum;
            // int inputInt;
            // float average;
            // Console.WriteLine("문제 1--------------------------------------------");
            // Console.WriteLine("국어 점수를 입력하세요 : ");
            // inputInt = Convert.ToInt32(Console.ReadLine());
            // scoreKorean = inputInt;
            // Console.WriteLine("영어 점수를 입력하세요 : ");
            // inputInt = Convert.ToInt32(Console.ReadLine());
            // scoreEnglish = inputInt;
            // Console.WriteLine("수학 점수를 입력하세요 : ");
            // inputInt = Convert.ToInt32(Console.ReadLine());
            // scoreMath = inputInt;

            // scoreSum = scoreKorean + scoreEnglish + scoreMath;
            // average = (float)scoreSum / 3;
            // Console.Write($"국어 점수 + 영어 점수 + 수학 점수의 평균 점수 : {average:F2}\n\n");
            // Console.WriteLine("문제 2--------------------------------------------");
            // Console.WriteLine("정수를 입력하세요 : ");
            // inputInt = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine($"입력받은 값 : {inputInt}, 비트 반전한 값 : {~inputInt}");

            //

            //b = 1
            //전위 연산자 ++b 1+b, 후위 연산자 b++ b+1
            // int b;
            // b = 1;
            // b++;
            // Console.WriteLine("b : " + b);

            // == || &&
            // int x = 5, y = 10;
            // bool a = true;
            // bool b = false;
            // Console.WriteLine(x < y);
            // Console.WriteLine(x*2 <= y);
            // Console.WriteLine(x != y);
            // Console.WriteLine((x >= y) || (x != y));
            // a = !b;
            // Console.WriteLine(a);

            // //비트연산자
            // int a = 7 , b = 3; // 0111 0011
            // Console.WriteLine(a & b); //0011
            // Console.WriteLine(a | b); //0111
            // Console.WriteLine(a ^ b); //0100
            // Console.WriteLine(~a); //-8
            // // >> << 시프트연산자 비트옮기기
            // int aa = 4; // 0100
            // Console.WriteLine(aa >> 1); // 0010
            // //기타 연산자
            // //1.삼항 연산자
            // int? aaa = 5, bbb = 10;
            // Console.WriteLine(aaa == bbb ? 100 : 200);
            // //is 객체 확인
            // Console.WriteLine(aaa is int);
            // //null 병합 연산자
            // int? nul = default;
            // Console.WriteLine(nul ?? 1); //aaa 는 null값 반환값 1
            // Console.WriteLine(nul ??= 2); //aaa 는 2
            // Console.WriteLine(nul ?? 1); //aaa가 null이 아니여서 그대로 2

            // //예제
            // int key = 0;
            // Console.WriteLine((key > 0) ? "문이 열렸다." : "키가 없다.");

            // //사칙연산 
            // int result = 2 + 5 * 10; //52
            // Console.WriteLine(result);
            // result = (2 + 5) * 10; //70
            // Console.WriteLine(result);

            //조건문
            // string ID = "ak47";
            // if(ID == "ak47")
            // {
            //     Console.WriteLine("a47");
            // }
            // else if(ID == "ak20")
            // {
            //     Console.WriteLine("a20");
            // }
            // else
            // {
            //     Console.WriteLine("a");
            // }

            // //소지금을 입력하세요 0~100 = 무한의대검, 101~200 카타나, 201~300 진은검
            // //301~400 집판검, 401~500 엑스칼리버, 501~600 유령검
            // int money = 0, input = 0, attackDefault = 100, attackPlus = 0;
            // string sword = default;
            // Console.WriteLine("소지금을 입력하세요 : ");
            // input = int.Parse(Console.ReadLine());
            // money = input;
            // Console.WriteLine(money);

            // if(0 <= money && money <= 100)
            // {
            //     attackPlus += 1;
            //     sword = "무한의 대검";
            // }
            // else if(101 <= money && money <= 200)
            // {
            //     attackPlus += 2;
            //     sword = "카타나";
            // }
            // else if (201 <= money && money <= 300)
            // {
            //     attackPlus += 3;
            //     sword = "진은검";
            // }
            // else if (301 <= money && money <= 400)
            // {
            //     attackPlus += 4;
            //     sword = "집판검";
            // }
            // else if (401 <= money && money <= 500)
            // {
            //     attackPlus += 5;
            //     sword = "엑스칼리버";
            // }
            // else if (501 <= money && money <= 600)
            // {
            //     attackPlus += 6;
            //     sword = "유령검";
            // }
            // else if(601 <= money)
            // {
            //     attackPlus += 7;
            //     sword = "전설의검";
            // }
            // Console.WriteLine($"캐릭터 : 멋사검존\n무기 : {sword} \n공격력 : {attackDefault}(+{attackPlus})");

            //

            /*문제 3. 간단한 사칙연산 계산기
            문제 설명:
            사용자로부터 두 개의 숫자와 연산자(+, -, *, /)를 입력받아 해당 연산을 수행하고 결과를 출력하는 계산기 프로그램을 작성하세요.
            요구사항:

            두 개의 숫자와 연산자 기호를 입력받습니다.
            if문을 사용하여 연산자를 확인하고 해당 연산을 수행합니다.
            나눗셈의 경우 0으로 나누는 상황을 처리하여 에러 메시지를 출력합니다.
            결과는 “결과: X” 형식으로 출력합니다.

            //시간남는사람
            나만의 텍스트노벨 배운내용 더 넣어서 만들기*/

            // int input = default, a = 0, b = 0, sign = 0;
            // double value;
            // Console.WriteLine("계산기------------------------------------------------\n\n숫자를 입력해주세요 : ");
            // input = int.Parse(Console.ReadLine());
            // a = input;
            // Console.WriteLine("1. 더하기(+)\n\n2. 빼기(-)\n\n3. 곱하기(*)\n\n4. 나누기(/)\n\n번호를 입력해주세요");
            // input = int.Parse(Console.ReadLine());
            // if(1 <= sign && sign <= 4)
            // {
            //     Console.WriteLine("1~4 사이의 번호만 입력하세요. 기본값 1로 대체됩니다");
            //     sign = 1;
            // }
            // else
            // {
            //     sign = input;
            // }
            // Console.WriteLine("숫자를 입력해주세요 : ");
            // input = int.Parse(Console.ReadLine());
            // b = input;
            // if (sign == 1)
            // {
            //     value = a + b;
            //     Console.WriteLine($"\n첫번째값[ {a} ] + 두번째값[ {b} ] = {value}");
            // }
            // else if(sign == 2)
            // {
            //     value = a - b;
            //     Console.WriteLine($"\n첫번째값[ {a} ] - 두번째값[ {b} ] = {value}");
            // }
            // else if(sign == 3)
            // {
            //     value = a * b;
            //     Console.WriteLine($"\n첫번째값[ {a} ] * 두번째값[ {b} ] = {value}");
            // }
            // else if(sign == 4)
            // {
            //     value = (float)a / b;
            //     Console.WriteLine($"\n첫번째값[ {a} ] / 두번째값[ {b} ] = {value:F2}");
            // }

            // //문제 1
            // int a, b, c;
            // int input;
            // Console.WriteLine("정수를 차례대로 적어주세요. 첫번째 정수 : ");
            // input = int.Parse(Console.ReadLine());
            // a = input;
            // Console.WriteLine("정수를 차례대로 적어주세요. 두번째 정수 : ");
            // input = int.Parse(Console.ReadLine());
            // b = input;
            // Console.WriteLine("정수를 차례대로 적어주세요. 세번째 정수 : ");
            // input = int.Parse(Console.ReadLine());
            // c = input;
            // if(a > b && a > c)
            // {
            //     Console.WriteLine($"3개의 정수 {a}, {b}, {c}의 가장 큰 값은 : {a}");
            // }
            // else if(b > a && b > c)
            // {
            //     Console.WriteLine($"3개의 정수 {a}, {b}, {c}의 가장 큰 값은 : {b}");
            // }
            // else
            // {
            //     Console.WriteLine($"3개의 정수 {a}, {b}, {c}의 가장 큰 값은 : {c}");
            // }

            // //문제2
            // int score;
            // Console.WriteLine("점수를 입력하세요 : ");
            // score = int.Parse(Console.ReadLine());
            // if(score >= 90)
            // {
            //     Console.WriteLine("A");
            // }
            // else if(score >= 80)
            // {
            //     Console.WriteLine("B");
            // }
            // else if(score >= 70)
            // {
            //     Console.WriteLine("C");
            // }
            // else if(score >= 60)
            // {
            //     Console.WriteLine("D");
            // }
            // else
            // {
            //     Console.WriteLine("F");
            // }







        }
}
}