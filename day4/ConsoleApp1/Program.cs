using System;
using System.Text;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Net;
using System.Diagnostics.CodeAnalysis;

namespace day4{
    class Program{
        static void Main(string[] args){
            // // switch 만들기
            // int day = 1;
            // switch(day){
            //     case 1:
            //         Console.WriteLine("월요일");
            //         break;
            //     case 2:
            //         Console.WriteLine("화요일");
            //         break;
            //     case 3:
            //         Console.WriteLine("수요일");
            //         break;
            //     case 4:
            //         Console.WriteLine("목요일");
            //         break;
            //     case 5:
            //         Console.WriteLine("금요일");
            //         break;
            //     default:
            //         Console.WriteLine("주말입니다");
            //         break;
            // }

            // //3수중 최대값 설정
            // int a = 3, b = 5, c = 6; int max = a; //초기값 a를 max로
            // if(b > max) {
            //     max = b;
            // }
            // if(c > max) {
            //     max = c;
            // }
            // Console.WriteLine($"최대값은 {max}입니다");

            //캐릭터를 선택하세요 (1.검사 2.마법사 3.도적) :
            //스위치 문 사용,
            //1.검사,공격력 100, 방어력 90
            //2.마법사 공격력 110, 방어력 80
            //3.도적 공격력 115, 방어력 70
            Console.OutputEncoding = Encoding.UTF8; // 출력 인코딩 UTF-8
            Console.InputEncoding = Encoding.UTF8;
            // int statAttack = 30, statDefense = 30;
            // string job;
            // Console.Write("캐릭터를 선택하세요 (검사, 마법사, 도적) : ");
            // job = Console.ReadLine();
            // Console.WriteLine(job);

            // switch (job){
            //     case "검사":
            //         statAttack = 100;
            //         statDefense = 90;
            //         break;
            //     case "마법사":
            //         statAttack = 110;
            //         statDefense = 80;
            //         break;
            //     case "도적":
            //         statAttack = 115;
            //         statDefense = 70;
            //         break;
            //     default:
            //         Console.WriteLine("잘못된 캐릭터");
            //         break;
            // }
            // Console.WriteLine($"| 직업 : {job}\n\n| 공격력 : {statAttack}\n| 방어력 : {statDefense}");

            //반복문 중요도 ★★★★★

            //0~9까지 출력
            // for(int i = 0; i <= 9; i++) {
            //     if(i != 9) {
            //         Console.Write(i + ", ");
            //     }
            //     else {
            //         Console.WriteLine(i);
            //     }

            // }
            // int sum = 0;
            // for (int i = 1; i <= 10; i++) {
            //     sum += i;
            //     if (i <= 9) {
            //         Console.Write(i + " + ");
            //     }
            //     else if(i == 10) {
            //         Console.Write(i + " = " + sum + "\n");
            //     }
            // }

            // int count = 1;
            // while(count <= 5)
            // {
            //     Console.WriteLine("Count : " + count);
            //     count++;
            //     if (count == 3) {
            //         break;
            //     }
            // }

            //랜덤 중요도 ☆★★★★(Random rand을 안쓸수도있음 다른 rand)

            //0이상 10 미만의 랜덤 정수 생성
            // Random rand = new Random();
            // double randNum;

            // for(int i = 0; i < 30; i++) {
            //     randNum = rand.Next(0, 10);
            //     Console.WriteLine("0~10사이의 번호 : " + randNum);
            // }

            //대장장이 키우기 도끼등급 SSS=10%,SS=40%,S=50%
            // Random rand = new Random();
            // string Rank; int S = 0, SS = 0, SSS = 0;
            // for(int i = 0; i < 30; i++) { //30연뽑
            //     int randNum = rand.Next(1, 11);
            //     if(randNum <= 5) { //S등급 50%
            //         Rank = "S";
            //         S += 1;
            //     }
            //     else if(randNum <= 9) { //SS등급 40%
            //         Rank = "SS";
            //         SS += 1;
            //     }
            //     else {
            //         Rank = "SSS";
            //         SSS += 1;
            //     }
            //     Console.WriteLine($"{i}회차 : 도끼의 Rank는 {Rank}등급 입니다");
            //     Thread.Sleep(250);
            // }
            // Console.WriteLine($"\n전체 결과 -------------------------------------\n\nS등급 도끼 : {S}개\nSS등급 도끼 : {SS}개\nSSS등급 도끼 : {SSS}개\n");

            //do while 중요도 ☆☆☆★★
            //1회 무조건 실행하고 while문과 같이 조건진행

            // int x = 5;
            // int dab;
            // do
            // {
            //     Console.Write($"\n1+1은?\n정답을 입력해주세요(남은횟수 {x}) : ");
            //     dab = Convert.ToByte(Console.ReadLine());
            //     if(dab == 2) {
            //         Console.WriteLine("정답!");
            //         break;
            //     }
            //     else {
            //         Console.WriteLine("오답.");
            //         x--;
            //     }
            //     if(x == -1) {
            //         Console.WriteLine("실패");
            //         break;
            //     }
            // } while(x >= 0);
            // Console.WriteLine("");

            // //continue에 대해 중요도 ★★★★★(break도 마찬가지)
            // for(int i = 0; i < 30; i++)
            // {
            //     if(i % 2 == 0)
            //     {
            //         continue; //짝수
            //     }
            //     Console.WriteLine($"홀수 {i}");
            // }

            // //goto에 대해 중요도 ☆☆☆☆☆
            // int n = 1;
            // start:
            // if(n <= 5)
            // {
            //     Console.WriteLine($"n : {n}");
            //     n++;
            //     goto start;
            // }






















        }
    }}




