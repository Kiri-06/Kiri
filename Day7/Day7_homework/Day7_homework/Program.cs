using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Day7_homework
{

    class Map
    {
        public static int maxMap = 10;
        public string[] name = new string[maxMap];
        public int[][,] map = new int[maxMap][,];
        public int[] pos_player = new int[2];
        public int playing;
        public string playing_name;
        public void UpdatePlayerPos()
        {
            for (int height = 0; height < map[playing].GetLength(0); height++)
            {
                for (int width = 0; width < map[playing].GetLength(1); width++)
                {
                    if (map[playing][height,width] == 2)//if player
                    {
                        pos_player[0] = height;
                        pos_player[1] = width;
                    }
                }
            }
        }
        public void ReSet()
        {
            name = new string[maxMap];
            map = new int[maxMap][,];
        }
        public void New(int size_width, int size_height, string map_name)
        {
            if (size_width <= 1 || size_width > 50)
            {
                size_width = 10;
            }
            if (size_height <= 1 || size_height > 50)
            {
                size_height = 10;
            }
            for (int i = 0; i < maxMap; i++)
            {
                if (name[i] == null)
                {
                    map[i] = new int[size_height, size_width]; //{ { 형태(0=벽,1=빈공간,2=플레이어,3=도착지점,4=별) },{ } }
                    name[i] = map_name;
                    SlotReset(i);
                    break;
                }
                else if (i + 1 == maxMap) //마지막일때
                {
                    Console.WriteLine("생성가능한 맵 갯수를 초과했습니다");
                }
            }

        }
        public void Set(string map_name, int num_height, int num_width, int changeNum)
        {
            for (int i = 0; i < maxMap; i++)
            {
                if (name[i] == map_name)
                {
                    if (map[i][num_height, num_width] == changeNum)
                    {
                        Console.WriteLine("이미 같은 형태입니다");
                    }
                    else
                    {
                        map[i][num_height, num_width] = changeNum;
                    }
                    break;
                }
                else if (i + 1 == maxMap)
                {
                    Console.WriteLine("ERROR 이름이 다릅니다");
                }
            }
        }
        public void Show(string show_name)
        {
            for(int i = 0; i < maxMap; i++)
            {
                if (name[i] == show_name)
                {
                    Console.WriteLine(name[i]);
                    for (int height = 0; height < map[i].GetLength(0); height++) //세로길이
                    {
                        for (int width = 0; width < map[i].GetLength(1); width++) //가로길이
                        {
                            switch(map[i][height,width])
                            {
                                case 1:
                                    Console.Write("□"); break;
                                case 2:
                                    Console.Write("◎"); break;
                                case 3:
                                    Console.Write("◈"); break;
                                case 4:
                                    Console.Write("★"); break;
                                default:
                                    Console.Write("■"); break;
                            }
                        }
                        Console.Write("\n");
                    }
                    break;
                }
            }
        }
        void SlotReset(int num)
        {
            for (int i = 0; i < map[num].GetLength(0); i++)
            {
                for (int j = 0; j < map[num].GetLength(1); j++)
                {
                    map[num][i, j] = 1;
                }
            }
            map[num][0, 0] = 2;
            map[num][map[num].GetLength(0) - 1, map[num].GetLength(1) - 1] = 3;
        }
    }
    class Player
    {
        [DllImport("msvcrt.dll")]
        static extern int _getch();

        const int key_up = 72;
        const int key_down = 80;
        const int key_left = 75;
        const int key_right = 77;

        int input;

        Map map;
        int height;
        int width;
        int playing_num;
        string playing_name;

        public void ReadKey(string scene_name)
        {
            if (Console.KeyAvailable)
            {
                input = _getch();
                input = _getch();
                switch (scene_name)
                {
                    case "Home":
                        break;
                    case "Playing":
                        Update();
                        map.UpdatePlayerPos();
                        if (input == key_up)
                        {
                            Console.WriteLine("key_up");
                            CrashDetect(height - 1,width);
                        }
                        else if (input == key_left)
                        {
                            Console.WriteLine("key_left");
                            CrashDetect(height, width - 1);
                        }
                        else if (input == key_down)
                        {
                            Console.WriteLine("key_down");
                            CrashDetect(height + 1, width);
                        }
                        else if (input == key_right)
                        {
                            Console.WriteLine("key_right");
                            CrashDetect( height, width + 1);
                        }
                        break;
                    case "Making":
                        break;
                }
            }
        }
        void Update()
        {
            map = Program.map;
            height = map.pos_player[0];
            width = map.pos_player[1];
            playing_num = map.playing;
            playing_name = map.playing_name;
        }
        void CrashDetect(int tile_height, int tile_width)
        {
            map.UpdatePlayerPos();
            Update();
            int direct_height, direct_width;
            int player_height = map.pos_player[0];
            int player_width = map.pos_player[1];

            while (true)
            {
                if (tile_height < 0 || tile_height > map.map[playing_num].GetLength(0) - 1)
                {
                    break;
                }
                else if (tile_width < 0 || tile_width > map.map[playing_num].GetLength(1) - 1)
                {
                    break;
                }
                else if (map.map[playing_num][tile_height, tile_width] == 0)
                {
                    break;//벽일때
                }
                else if (map.map[playing_num][tile_height, tile_width] == 3)
                {
                    Console.Clear();
                    map.Show("StartMap");
                    Program.GameSwitch = false;
                    Console.WriteLine("성공!");
                    break;//도착지점일때 성공
                }
                else
                {
                    map.Set(playing_name, player_height, player_width, 1);
                    map.Set(playing_name, tile_height, tile_width, 2);
                    map.UpdatePlayerPos();
                    Update();
                    //for처럼 += 1 그 다음으로 넘어가기위한 단계, 방향정하기 
                    direct_height = (tile_height - player_height); //-1
                    direct_width = tile_width - player_width;
                    tile_height += direct_height;
                    tile_width += direct_width;
                    player_height = map.pos_player[0];
                    player_width = map.pos_player[1];
                }
                
            }
        }
     
        public void Move(int keyNum) //강제 키 입력
        {
            input = keyNum;
        }

    }


    internal class Program
    {
        static public Player p = new Player();
        static public Map map = new Map();
        static void Scene(string scene_name)
        {
            Console.Clear();
            if (scene_name == "Start")
            {
                map.New(10, 10, "StartMap");
                map.Set("StartMap", 0, 2, 0);
                map.Set("StartMap", 9, 9, 1);
                map.Set("StartMap", 7, 6, 3);
                map.Set("StartMap", 9, 3, 0);
                map.Set("StartMap", 8, 3, 0);
                map.Set("StartMap", 6, 9, 0);
                map.Set("StartMap", 5, 1, 0);
                map.Set("StartMap", 7, 5, 0);
                map.Set("StartMap", 4, 2, 0);
                map.Set("StartMap", 2, 4, 0);
                map.Set("StartMap", 1, 5, 0);
                map.Show("StartMap");
                map.playing_name = "StartMap";
                map.playing = 0;
            }
            else if (scene_name == "Home")
            {

            }
            else if (scene_name == "Playing")
            {
                map.Show("StartMap");
                map.UpdatePlayerPos();
                p.ReadKey("Playing");
            }
            else if (scene_name == "Making")
            {

            }
        }

        static public bool GameSwitch = true;
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            Console.SetWindowSize(101, 53);
            Console.SetBufferSize(101, 53);

            int dwTime = Environment.TickCount;
            Scene("Start");
            while (GameSwitch)
            {
                if (dwTime + 100 < Environment.TickCount)
                {
                    dwTime = Environment.TickCount;
                    Scene("Playing");
                }
            }
        }
    }
}
