using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Day7
{
    internal class Program
    {
        //void 공허, 매개변수도 반환값도 없는 함수
        static void PrintMessage(string inputst)
        {
            Console.WriteLine(inputst);
        }

        static int Add(int num, int num2)
        {
            return num + num2;
        }

        //기본값을 가진 매개변수 (디폴트 매개변수)
        static void PrintGreet(string name = "손님")
        {
            Console.WriteLine($"안녕하세요, {name}");
        }

        static int Multiply(int a, int b)
        {
            return a + b;
        }
        static double Multiply(double a, double b)
        {
            return a + b;
        }
        static string Multiply(string a, string b)
        {
            return a + " " + b;
        }

        static void Divide(int a, int b, out int quotient, out int remainder)
        {
            quotient = a / b;
            remainder = a % b;
        }

        static void Increase(ref int num)
        {
            num += 10;
        }

        static int Sum(params int[] num)
        {
            int total = 0;
            foreach(int number in num)
            {
                total += number;
            }
            return total;
        }

        static int j = 0;
        //재귀함수
        static void Print()
        {
            if(j > 0)
            {
                Console.WriteLine("나는 재귀함수다.");
                j -= 1;
                Print();
            }
        }
        static int Factorial(int n)
        {
            if (n <= 1)
                return 1;   //출력겸 탈출

            return n * Factorial(n - 1);
        }

        static int AddArrow(int a, int b) => a + b;

        static void ChooseWeapon(WeaponType weapon)
        {
            if(weapon == WeaponType.Sword)
            {
                Console.WriteLine("검을 선택했습니다");
            }
            else if (weapon == WeaponType.Bow)
            {
                Console.WriteLine("활을 선택했습니다");
            }
            else if (weapon == WeaponType.Staff)
            {
                Console.WriteLine("지팡이를 선택했습니다");
            }

        }

        //열거형 Enumeration enum
        //숫자값에 이름을 부여하는 자료형
        //가독성을 높이고, 의미 있는 값으로 표현가능
        //기본적으로 첫 번째 값은 0부터 시작하며 1씩 증가

        enum DayOfWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
        }
        enum StatusCode
        {
            Success = 200,
            BadRequest = 400,
            Unauthorized = 401,
            NotFound = 404
        }
        enum WeaponType
        {
            Sword,
            Bow,
            Staff
        }

        //
        //C# 구조체
        //클래스와 비슷하지만, 값 타입(Value Type)이며,
        //가볍고 빠름
        //주로 간단한 데이터 묶음을 만들때 사용
        //

        struct Point
        {
            //public : 어디서든 사용가능하게 권한
            //private : 나만 사용할려고 하는 키워드
            public int X;
            public int Y;
            public void Print()
            {
                Console.WriteLine($"좌표 : {X}, {Y}");
            }
        }


        static void Main(string[] args)
        {
            Point p;

            p.X = 10;
            p.Y = 20;
            p.Print();

            //PrintMessage("반갑습니다");
            //Console.WriteLine(Add(3, 6));
            //PrintGreet("boy");
            //Console.WriteLine(Multiply(3, 6));
            //Console.WriteLine(Multiply(3.1, 6));
            //Console.WriteLine(Multiply("Hello", "World"));
            //int q, r;
            //Divide(10, 3, out q, out r);
            //Console.WriteLine($"{q}, {r}");
            //int value = 5;
            //Increase(ref value);
            //Console.WriteLine(value);
            //Console.WriteLine(Sum(1,2,3,4,5,6,7,8,9));
            //j = 5;
            //Print();
            //Console.WriteLine(Factorial(4));
            //Console.WriteLine(AddArrow(1,3));
            //Console.WriteLine($"Pi : {Math.PI}");//PI
            //Console.WriteLine($"Square root of 25: {Math.Sqrt(25)}");//제곱근
            //Console.WriteLine($"Power (2^3): {Math.Pow(2, 3)}");//제곱
            //Console.WriteLine($"Round(3.75): {Math.Round(3.75)}");//반올림

            //DayOfWeek today = DayOfWeek.Wednesday;
            //Console.WriteLine(today);

            //Console.WriteLine(today);
            //Console.WriteLine((int)today);

            //StatusCode status = StatusCode.NotFound;
            //Console.WriteLine(status);
            //Console.WriteLine((int)status);

            //문제
            //열거형과 함수를 이용해서 풀어주세요.
            //Weapontype.Sword 검을 선택했습니다.
            //Weapontype.Bow 활을 선택했습니다.
            //Weapontype.Staff 지팡이를 선택했습니다.

            //ChooseWeapon(WeaponType.Bow); //출력: 활을 선택했습니다

            //ChooseWeapon(WeaponType.Bow);

            
        }
    }
}
