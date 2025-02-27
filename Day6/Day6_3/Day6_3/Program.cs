using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Day6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25); // 콘솔 창 크기 설정 (가로 80, 세로 25)
            Console.SetBufferSize(80, 25); // 버퍼 크기도 동일하게 설정 (스크롤 방지)


            string[] player = new string[]
            {
                "->",
                ">>>",
                "->",
            }; //배열 문자열로 그리기

            int playerX = 0;
            int playerY = 12;
            int[,] bullet = new int[99, 2] ;
            for (int i = 0; i < 99; i++)
            {
                bullet[i,0] = 0;
                bullet[i,1] = 0;
            }
            int bullet_num = 0;

            ConsoleKeyInfo keyInfo;

            Console.CursorVisible = false;


            //시간 1초루프
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            long prevSecond = stopwatch.ElapsedMilliseconds; // 1 /1000    1000일때 1초




            while (true)
            {



                long currentSecond = stopwatch.ElapsedMilliseconds; //현재시간 가져오기

                if (currentSecond - prevSecond >= 10)
                {
                    // Console.WriteLine("1초루프");
                    


                    keyInfo = Console.ReadKey(true); //키 입력 받기 (화면 출력 X)
                    Console.Clear();

                    //방향키 입력에 따른 좌표 변경
                    switch (keyInfo.Key)
                    {
                        case ConsoleKey.UpArrow: if (playerY > 0) playerY--; break;
                        case ConsoleKey.DownArrow: if (playerY < Console.WindowHeight - 1) playerY++; break;
                        case ConsoleKey.LeftArrow: if (playerX > 0) playerX--; break;
                        case ConsoleKey.RightArrow: if (playerX < Console.WindowWidth - 1) playerX++; break;
                        case ConsoleKey.Spacebar:
                            bullet[bullet_num,0] = playerX;
                            bullet[bullet_num,1] = playerY+1;
                            bullet_num += 1;
                            break;
                        case ConsoleKey.Escape: return; //ESC키로 종료 

                    }
                    for(int bullet_num_ = 0; bullet_num_ < bullet.GetLength(0); bullet_num_++)
                    {
                        if(bullet[bullet_num_,0] != 0)
                        {
                            if (bullet[bullet_num_, 0] >= 50)
                            {
                                bullet[bullet_num_, 0] = 0;
                            }
                            else
                            {
                                bullet[bullet_num_, 0] += 1;
                            }
                        }
                        
                        
                    }
                    

                    for (int i = 0; i < player.Length; i++)
                    {
                        //콘솔좌표 설정 플레이어X 플레이어Y
                        Console.SetCursorPosition(playerX, playerY + i);
                        //문자열배열 출력
                        Console.WriteLine(player[i]);
                    }
                    for (int bullet_num_ = 0; bullet_num_ < bullet.GetLength(0); bullet_num_++)
                    {
                        if (bullet[bullet_num_,0] != 0)
                        {
                            Console.SetCursorPosition(bullet[bullet_num_, 0], bullet[bullet_num_, 1]);
                            Console.WriteLine("●");
                        }
                        
                    }


                    prevSecond = currentSecond;//이전 시간 업데이트


                }
            }
        }
    }
}
