using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Day8_2
{

    class Warrior
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public double Strength { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*실습 문제(쉬운 난이도)
              클래스와 상속
              Warrior 클래스를 만들고 Name과 Score 속성을 추가하세요.
              Warrior Strength 속성을 추가하세요.
              Main 메서드에서 Warrior 객체를 생성하고, Name, Score, Strength 값을 설정한 후 출력하세요.

              예외 처리
              사용자에게 정수를 입력받고, 이를 int로 변환하는 프로그램을 작성하세요.
              숫자로 변환할 수 없는 경우 FormatException을 처리하여 "올바른 숫자를 입력하세요!"라는 메시지를 출력하세요.
              변환이 성공하면 입력한 숫자를 출력하세요.

              컬렉션(List, Queue, Stack) 활용
              List<string> 을 생성하고 "사과", "바나나", "포도"를 추가하세요.
              Queue<string> 을 생성하고 "첫 번째 작업", "두 번째 작업", "세 번째 작업"을 추가하세요.
              Stack<int> 을 생성하고 10, 20, 30을 추가한 뒤 하나씩 출력하세요.

              문자열 처리
              사용자로부터 "Hello, C# World!" 같은 문자열을 입력받아, 다음을 수행하세요.
              전체 문자열을 대문자로 변환
              "C#"을 "CSharp"으로 변경
              문자열의 길이 출력

              LINQ 활용
              int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; 배열이 주어질 때,
              LINQ를 사용하여 짝수만 필터링하고 출력하세요.
              LINQ를 사용하여 모든 숫자의 합을 구하고 출력하세요.*/
            int quest1=0, quest2 = 0, quest3 = 0, quest4 = 0, quest5 = 1;
            if (quest1==1) {
                Warrior war = new Warrior();
                war.Name = "벤쿠버";
                war.Score = 100;
                war.Strength = 5.521;
                Console.WriteLine($"Name: {war.Name}");
                Console.WriteLine($"Score: {war.Score}");
                Console.WriteLine($"Strength: {war.Strength:f2}");
            }
            if (quest2 == 1)
            {
                int input;
                while (true)
                {
                    try
                    {
                        input = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("올바른 숫자를 입력하시오!");
                    }
                }
                Console.WriteLine($"입력값:{input}");
            }
            if (quest3 == 1)
            {
                List<string> fruits = new List<string>();
                fruits.Add("사과"); fruits.Add("바나나"); fruits.Add("포도");
                foreach (string fruit in fruits)
                {
                    Console.WriteLine($"{fruit}");
                }
                Queue<string> queue = new Queue<string>();
                queue.Enqueue("첫 번째 작업");
                queue.Enqueue("두 번째 작업");
                queue.Enqueue("세 번째 작업");
                foreach (string q in queue)
                {
                    Console.WriteLine($"{q}");
                }
                Stack<int> stack = new Stack<int>();
                stack.Push(10);
                stack.Push(20);
                stack.Push(30);
                foreach (int s in stack)
                {
                    Console.WriteLine($"{s}");
                }
            }
            if (quest4 == 1)
            {
                string input2 = Console.ReadLine();
                StringBuilder an = new StringBuilder();
                an.Append(input2.ToUpper());
                an.Replace("C#", "Csharp");
                Console.WriteLine(an.Length);
            }
            if (quest5 == 1)
            {
                int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                IEnumerable<int> evennumbers = numbers.Where(n => n % 2 == 0);
                foreach (int n in evennumbers)
                {
                    Console.WriteLine(n);
                }
            }




        }
    }
}
