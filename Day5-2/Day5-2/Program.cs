using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_2
{
    internal class Program
    {
        static int Add(int Value1, int Value2)
        {
            int sum = Value1 + Value2;
            
            return sum;
        }

        static int StLength(string Value1)
        {
            int num = 0;
            foreach (char c in Value1)
            {
                num += 1;
            }
            return num;
        }
        static int ThreeIntMax(int Value1, int Value2, int Value3)
        {
            int max = Value1;
            if (Value2 > max)
            {
                max = Value2;
            }
            if (Value3 > max)
            {
                max = Value3;
            }
            return max;
        }
        static void Main(string[] args)
        {
            //배열 관련 문제(3문제)---------------------------------------------------

            //Q1. 배열 요소 출력
            // 문제: 크기가 5인 정수 배열을 만들고,
            //{10, 20, 30, 40, 50} 값을 저장한 후 출력하세요.
            //예상출력 10 20 30 40 50
            Console.WriteLine("Q1-----------------------------------------------");

            int[] quest1 = { 10, 20, 30, 40, 50 };
            Console.Write($"{quest1[0]} {quest1[1]} {quest1[2]} {quest1[3]} {quest1[4]}");
            Console.Write("\n");

            //Q2. 배열 요소 합 구하기
            //문제: 사용자가 5개의 정수를 입력하면 배열에 저장하고,
            //모든 수의 합을 출력하세요.
            //예상 입력/출력/ 숫자 입력: 1 2 3 4 5 /총 합: 15
            Console.WriteLine("\nQ2-----------------------------------------------");

            int[] quest2_input = new int[5]; int quest2_sum = 0;
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("숫자 입력");
                quest2_input[i] = int.Parse(Console.ReadLine());
                quest2_sum += quest2_input[i];
            }
            Console.WriteLine($"총 합: {quest2_sum}");

            //Q3. 최대값 찾기
            //문제: 정수 배열 {3, 8, 15, 6, 2}에서
            //가장 큰 값을 찾아 출력하세요.
            //예상 출력 최대값 : 15
            Console.WriteLine("\nQ3-----------------------------------------------");

            int[] quest3_arr = { 3, 8, 15, 6, 2 };
            int quest3_max = quest3_arr[0];
            for(int i = 0; i < quest3_arr.Length; i++)
            {
                if(quest3_arr[i] > quest3_max)
                {
                    quest3_arr[i] = quest3_max;
                }
            }
            Console.WriteLine($"최대값 : {quest3_max}");

            //반복문 관련 문제 (3문제)---------------------------------------------------

            //Q4. 1부터 10까지 출력 (for문)
            //문제: for문을 사용하여 1부터 10까지 출력하세요.
            //예상 출력/ 1 2 3 4 5 6 7 8 9 10
            Console.WriteLine("\nQ4-----------------------------------------------");

            for (int i = 1; i < 11; i++)
            {
                Console.Write($"{i} ");
            }

            //Q5. 짝수만 출력 (while문)
            //문제: while문을 사용하여 1부터 10까지 중 짝수만 출력하세요.
            //예상 출력 2 4 6 8 10
            Console.WriteLine("\nQ5-----------------------------------------------");

            int quest5 = 1;
            while (true)
            {
                if(quest5 % 2 == 0)
                {
                    Console.Write($"{quest5} ");
                }
                if (quest5 == 10)
                {
                    break;
                }
                quest5 += 1;
               
            }

            //Q6. 배열 요소 출력 (foreach문)
            //문제: foreach문을 사용하여 배열 {1, 2, 3, 4, 5}의
            //요소를 출력하세요
            Console.WriteLine("\nQ6-----------------------------------------------");

            int[] quest6 = { 1, 2, 3, 4, 5 };
            foreach(int i in quest6)
            {
                Console.WriteLine(i);
            }

            //함수 관련 문제 (3문제)---------------------------------------------------

            //Q7. 두 수의 합을 구하는 함수
            //문제: 두 개의 정수를 입력받아 합을 반환하는 함수를 작성하세요.
            //예상출력 3과 5의 합: 8
            Console.WriteLine("\nQ7-----------------------------------------------");

            Console.WriteLine($"3과 5의 합: {Add(3, 5)}");

            //Q8. 문자열 길이 반환 함수
            //문제: 문자열을 입력받아 길이를 반환하는 함수를 작성하세요.
            //예상 출력/ 문자열 입력: Hello / 문자열 길이: 5
            Console.WriteLine("\nQ8-----------------------------------------------");

            Console.WriteLine("문자열 입력 : ");
            string quest8_input = Console.ReadLine();
            Console.WriteLine($"문자열 길이: {StLength(quest8_input)}");

            //Q9. 가장 큰 수 반환 함수
            //문제: 세 개의 정수를 입력받아 가장 큰 값을 반환하는
            //함수를 작성하세요.
            //예상 출력 가장 큰 수: 7
            Console.WriteLine("\nQ9-----------------------------------------------");

            int[] quest9 = new int[3];
            Console.WriteLine("세 개의 정수입력(첫번째): ");
            quest9[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("세 개의 정수입력(두번째): ");
            quest9[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("세 개의 정수입력(세번째): ");
            quest9[2] = int.Parse(Console.ReadLine());
            Console.WriteLine($"가장 큰 수: {ThreeIntMax(quest9[0], quest9[1], quest9[2])}");



        }
    }
}
