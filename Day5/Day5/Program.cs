using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Day5
{
    internal class Program
    {
        static int a = 5, b = 5, num = 0;
        static int[,] Array = new int[a, b];
        static int bingo = 0;
        static int BingoCheck()
        {
            //빙고 체크(가로)
            int count = 0;
            bingo = 0;
            for (int width = 0; width < a; width++)
            {
                for (int height = 0; height < b; height++)
                {
                    if (Array[width, height] == 0)
                    {
                        count += 1;
                    }
                }
                if (count == 5)
                {
                    bingo += 1;
                }
                count = 0;
            }
            //빙고 체크(세로)
            for (int height = 0; height < a; height++)
            {
                for (int width = 0; width < b; width++)
                {
                    if (Array[width, height] == 0)
                    {
                        count += 1;
                    }
                }
                if (count == 5)
                {
                    bingo += 1;
                }
                count = 0;
            }
            //빙고 체크(왼쪽 -> 오른쪽 대각선)
            for (int width = 0; width < a; width++)
            {
                if (Array[width, width] == 0)
                {
                    count += 1;
                }
                if (count == 5)
                {
                    bingo += 1;
                }
            }
            count = 0;
            //빙고체크 오른쪽->왼쪽
            for (int width = 0; width < 5; width++)
            {
                
                if (Array[width, Array.GetLength(1) - width - 1] == 0)
                {
                    count += 1;
                }
                if (count == 5)
                {
                    bingo += 1;
                }
            }

            return bingo;
        }
        static void Main(string[] args)
        {
            //배열 ( 0부터 시작 )

            //int[] num = new int[3]; //3개 메모리 만들겠다---------------
            //string[] arr = { "사과", "바나나", "포도" };
            //int[] num3 = new int[] {10, 20, 30}; //------------------
            //num[0] = 10; num[1] = 20; num[2] = 30;
            //Console.WriteLine(string.Join("\n", num));
            //for (int i = 0; i <= 2; i++)
            //{
            //    Console.Write(num[i]);
            //    Console.Write(arr[i]);
            //}
            //3명의 국어,영어,수학 점수를 입력받고 총점과 평균을 출력하세요
            //int[,] score = new int[3, 3];
            //int[] sum = { 0, 0, 0 };
            //double[] average = { 0, 0, 0 };
            //bool switch_ = true;
            //string name, subject;
            //int nameNum = 0, subjectNum = 0;
            //Byte input;
            //for(nameNum = 0; nameNum <= 2; nameNum++)
            //{
            //    for(subjectNum = 0; subjectNum <= 2; subjectNum++) {
            //        //현재 이름과 과목을 검사해서 string값으로 변환 (예:if score[0,1] => 철수,영어)
            //        switch (subjectNum)
            //        {
            //            case 0:
            //                subject = "국어"; break;
            //            case 1:
            //                subject = "영어"; break;
            //            case 2:
            //                subject = "수학"; break;
            //            default:
            //                subject = "error"; break;
            //        }
            //        switch (nameNum)
            //        {
            //            case 0:
            //                name = "철수"; break;
            //            case 1:
            //                name = "영희"; break;
            //            case 2:
            //                name = "지우"; break;
            //            default:
            //                name = "error"; break;
            //        }
            //        //입력 받기
            //        Console.WriteLine($"{name}의 {subject} 과목'점수'을 입력해주세요 : ");
            //        try
            //        {
            //            input = Convert.ToByte(Console.ReadLine());
            //        }
            //        catch (Exception)
            //        {
            //            input = 100;
            //        }
            //        //입력받은 값을 score에 넣기
            //        score[nameNum, subjectNum] = input;
            //        sum[nameNum] += score[nameNum, subjectNum];
            //    }
            //    subjectNum = 0;
            //    average[nameNum] = (double)sum[nameNum] / 3;
            //}
            //for (nameNum = 0; nameNum <= 2; nameNum++)
            //{
            //    switch (nameNum)
            //    {
            //        case 0:
            //            name = "철수"; break;
            //        case 1:
            //            name = "영희"; break;
            //        case 2:
            //            name = "지우"; break;
            //        default:
            //            name = "error"; break;
            //    }
            //    Console.WriteLine($"{name}의 총점은 {sum[nameNum]}점이고 평균은 {average[nameNum].ToString("F2")}점입니다");
            //}

            //int[] scores = new int[3];

            //scores[0] = 90;
            //scores[1] = 85;
            //scores[2] = 88;


            //double db = 12312.515563323;
            //for (int i = 0; i < scores.Length; i++)
            //{
            //    Console.WriteLine($"점수 {i + 1}:{scores[i]}");
            //    Console.WriteLine(string.Format("점수 {0}:{1:F2}", i+1, scores[i]));
            //    Console.WriteLine(db.ToString("N2"));
            //}

            //int[,] matrix = new int[2, 3]{ { 1, 2, 3 }, { 4, 5, 6 } };
            //int[][] arr2 = new int[2][];

            //arr2[0] = new int[3];
            //arr2[1] = new int[2];

            //arr2[0][0] = 1;
            //arr2[0][1] = 2;
            //arr2[0][2] = 3;

            //arr2[1][0] = 4;
            //arr2[1][1] = 5;

            //for(int Num = 0; Num < arr2.Length; Num++)
            //{
            //    for(int Num2 = 0; Num2 < arr2[Num].Length; Num2++)
            //    {
            //        Console.Write(arr2[Num][Num2] + " ");
            //    }
            //}


            //스왑
            //int[] iarr = new int[25];
            //int a = 10;
            //int b = 20;
            //int t = 0;
            //t = a;
            //a = b;
            //b = t;
            //Console.Write($"a : {a}, b: {b}, t: {t}");

            ////한 칸 밀기
            //for(int i = 0; i < iarr.Length; i++)
            //{
            //    iarr[i] = i + 1;
            //    Console.Write($"iarr[{i}] = {iarr[i]}\n");
            //}
            //Console.WriteLine($"셔플 {iarr.Length}");
            //int min = iarr[0];
            //for (int i = 0; i < iarr.Length; i++)
            //{
            //    if (i == iarr.Length - 1)
            //    {
            //        iarr[i] = min;
            //        Console.Write($"iarr[{i}] = {iarr[i]}\n");
            //        break;
            //    }
            //    iarr[i] = iarr[i + 1];
            //    Console.Write($"iarr[{i}] = {iarr[i]}\n");
            //}


            //빙고판 만들기 




            Random rand = new Random();
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    num += 1;
                    Array[i, j] = num;
                }
            }

            int iA, iB, iC, iD, iT;
            bool[,] boolArr = new bool[5, 5];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    boolArr[i, j] = false;
                }
            }
            for (int i = 0; i < 5; i++)
            {
                iA = rand.Next(0, 5);
                iB = rand.Next(0, 5);
                iC = rand.Next(0, 5);
                iD = rand.Next(0, 5);

                iT = Array[iA, iB];
                Array[iA, iB] = Array[iC, iD];
                Array[iC, iD] = iT;
                boolArr[iA, iB] = true;
            }
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    if (boolArr[i, j] == false)
                    {
                        iA = rand.Next(0, 5);
                        iB = rand.Next(0, 5);
                        iT = Array[i, j];
                        Array[i, j] = Array[iA, iB];
                        Array[iA, iB] = iT;
                        boolArr[i, j] = true;
                    }

                }
            }

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write($"[{Array[i, j].ToString("D2")}] ");

                }
                Console.Write("\n");
            }
            Console.Clear();
            int input = 0;

            for (int i = 25; i >= 0; i--)
            {
                for (int m = 0; m < a; m++)
                {
                    for (int n = 0; n < b; n++)
                    {
                        if (Array[m, n] == input)
                        {
                            Array[m, n] = 0;
                        }
                        Console.Write($"[{Array[m, n].ToString("D2")}] ");

                    }
                    Console.Write("\n");
                }
                bingo = BingoCheck();
                if(bingo >= 5)
                {
                    Console.WriteLine("5 빙고 완성!!!!!");
                    break;
                }
                Console.WriteLine($"1~25중 하나를 입력하세요(남은 기회 {i}번) (빙고 횟수 : {bingo}) : ");
                input = int.Parse(Console.ReadLine());
                Console.Clear();

            }



        }
    }
}
