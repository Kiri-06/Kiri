using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("asd");

            //string path = Environment.GetEnvironmentVariable("PATH");
            //Console.WriteLine($"PATH: {path}");

            //Environment.Exit(0);

            //Random rand = new Random();
            //int randomNumber = rand.Next(1, 101);
            //Console.WriteLine($"랜덤값(1~100): {randomNumber}");

            ////프로그램 실행시간
            //Stopwatch stopwatch = Stopwatch.StartNew();
            //for(int i = 0; i < 100000000; i++)
            //{

            //}
            //stopwatch.Stop();
            //Console.WriteLine($"포문 시간 : {stopwatch.ElapsedMilliseconds}");

            //string input = "Hello, my phone number is 010-1234-5678.";
            //string patter = @"\d{3}-\d{4}-\d{4}";
            //bool isMatch = Regex.IsMatch(input, patter);
            //Console.WriteLine(isMatch);

            //클래스시그니처 기본구성
            //C#에서 클래스 시그니처는 클래스의 선언부를 의미한다.

            //[접근 지정자] [수정자] class 클래스이름 : 부모클래스, 인터페이스
            //접근 지정자 :
            //public //private //protected //internal
            //수정자 : 
            //abstract //sealed //static //partial
            //부모클래스 :
            //BaseClass
            //인터페이스
            //IComparable

            //int valueType = 10;
            //object referenceType = valueType;
            //valueType = 20;
            //Console.WriteLine($"ValueType : {valueType}");
            //Console.WriteLine($"ReferenceType : {referenceType}");

            //is 연산자 형식 비교하기
            //객체가 특정 형식인지 확인할수 있다.

            //object obj = "Hello";

            //Console.WriteLine(obj is string); //true
            //Console.WriteLine(obj is int); //false

            //string greeting = "Hello";
            //string name = "Alice";

            //string message = greeting + "," + name + "!";
            //Console.WriteLine(message); //Hello,Alice

            //Console.WriteLine($"Length of name: {name.Length}"); //문자열 길이
            //Console.WriteLine($"To Upper: {name.ToUpper()}"); //대문자 변환
            //Console.WriteLine($"Substring: {name.Substring(1)}"); //부분 문자열
            //StringBuilder sb = new StringBuilder("Hello");
            //sb.Append(",");
            //sb.Append("World!");
            //Console.WriteLine(sb.ToString());

            //예외처리하기

            //예외는 프로그램실행 중 발생하는 오류입니다. 예외를 처리하면 프로그램이 중단되지않고
            //실행을 계속할수있습니다.
            //try catch 

            //while (true)
            //{

            //    try
            //    {
            //        int[] numbers = { 1, 2, 3 };
            //        Console.WriteLine(numbers[5]); //오류 발생
            //    }
            //    catch (IndexOutOfRangeException ex)
            //    {
            //        Console.WriteLine($"Error : {ex.Message}");
            //    }
            //}

            //int[] numbers = { 1, 2, 3, 4, 5 };
            //foreach(var num in numbers)
            //{
            //    Console.WriteLine(num);
            //}
            ////배열과 비슷하지만 돈적으로 크기가 변하는 가변길이 컬렉션
            //List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
            //names.Add("Dave");
            //names.
            //foreach(var name in names)
            //{
            //    Console.WriteLine(name);
            //}
            //Queue queue = new Queue();

            //queue.Enqueue("→");
            //queue.Enqueue("↓");
            //queue.Enqueue("↘");
            //queue.Enqueue("→");
            //queue.Enqueue("풍신권");



            //while (queue.Count > 0)
            //{
            //    Console.WriteLine(queue.Dequeue());
            //}


            //Console.WriteLine(queue.Count);

            //ArrayList 생성
            //크기가 동적으로 조정되는 배열, 다양한 형식의 데이터를 저장할수있다.
            ArrayList arrayList = new ArrayList();

            //요소추가
            arrayList.Add(1);  //정수
            arrayList.Add("Hello");  //문자열
            arrayList.Add(3.14);    //실수


            //요소 접근
            //Console.WriteLine("ArrayList 요소: ");
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            ////요소 제거
            //arrayList.Remove(1);

            //Console.WriteLine("\n ArrayList요소 제거 후: ");

            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}
            //Dictionary<string, int> ages = new Dictionary<string, int>();

            //ages["금도끼"] = 10;
            //ages["은도끼"] = 5;
            //ages["돌도끼"] = 1;

            //foreach (var pair in ages)
            //{
            //    Console.WriteLine($"{pair.Key} : {pair.Value}");
            //}

          





        }

    }
}
