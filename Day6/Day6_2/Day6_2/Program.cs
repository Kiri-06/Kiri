using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_2
{


    internal class Program
    {

        static void TextClear()
        {
            Console.Clear();
        }
        struct Rectangle
        {
            public int Width;
            public int Height;

            public int GetArea() => Width * Height;
        }

        struct Point
        {
            public int x;
            public int y;
        }

        struct Record
        {
            public string Name;
            public int Korean;
            public int English;
            public int Math;

            public void Print()
            {
                Console.WriteLine($"이름 : {Name}");
                Console.WriteLine($"국어 : {Korean}, 영어 : {English}, 수학 : {Math}\n");
            }

        }

        //아이템 제거 함수
        struct Item
        {
            public int inventorySlot_max;
            public string[] name/* = new string[inventorySlot_max]*/;
            public int[] count/* = new int[inventorySlot_max]*/;
            public void Setting(int value)
            {
                if(value <= 0)
                {
                    value = 10;
                }
                inventorySlot_max = value;
                name = new string[inventorySlot_max];
                count = new int[inventorySlot_max];
                Console.WriteLine($"설정 인벤토리 슬롯 : {value}");
            }
            public void Setting()
            {
                inventorySlot_max = 10;
                name = new string[inventorySlot_max];
                count = new int[inventorySlot_max];
                Console.WriteLine("설정 인벤토리 슬롯 : 10");
            }
            public void Add(string add_name, int add_count)
            {
                bool maxItem = true;
                for (int i = 0; i < inventorySlot_max; i++)
                {
                    if (name[i] == null)
                    { 
                        name[i] = add_name;
                        count[i] = add_count;
                        maxItem = false;
                        break;
                    }
                    else if (name[i] == add_name)
                    {
                        count[i] += add_count;
                        maxItem = false;
                        break;
                    }
                    
                }
                if (maxItem == true)
                {
                    Console.WriteLine($"인벤토리가 가득차 추가할 수 없습니다<{add_name}>");
                }
                else
                {
                    Console.WriteLine($"아이템 추가({add_name}x{add_count})");
                }    
            }

            public void Remove(string remove_name, int remove_count)
            {
                bool complete = false;
                for (int i = 0; i < inventorySlot_max; i++)
                {
                    if (name[i] == remove_name)
                    {
                        complete = true;
                        if (count[i] <= remove_count)
                        {
                            name[i] = null;
                            count[i] = 0;
                        }
                        else
                        {
                            count[i] -= remove_count;
                        }
                    }
                }
                if (complete == false)
                {
                    Console.WriteLine($"제거할 아이템이 없습니다<{remove_name}>");
                }
                else
                {
                    Console.WriteLine($"아이템 제거({remove_name}x{remove_count})");
                }

            }
            public void ShowInventory()
            {
                Console.WriteLine("\n현재 인벤토리------------------------------- \n");
                bool isEmpty = true;
                for (int i = 0; i < inventorySlot_max; i++)
                {
                    if (name[i] != null)
                    {
                        Console.WriteLine($"{name[i]} x{count[i]}");
                        isEmpty = false;
                    }
                }
                if (isEmpty == true)
                {
                    Console.WriteLine("인벤토리가 비어 있습니다.");
                }
                Console.WriteLine("\n---------------------------------------------");
            }

        }

        

        static void Main(string[] args)
        {
            //Rectangle rect;
            //rect.Width = 100;
            //rect.Height = 20;
            //Console.WriteLine(rect.GetArea());

            //Point[] points = new Point[2];

            //points[0].x = 10;
            //points[0].y = 10;
            //points[1].x = 20;
            //points[1].y = 20;
            //foreach(var point in points)
            //{
            //    Console.WriteLine($"{point.x}, {point.y}");
            //}
            //구조체를 이용해서
            //학생3명의 이름 성적을 받고 국어, 영어, 수학
            //출력하시오
            //이름 국어 영어 수학
            //홍길동 100 80 70
            //홍길란 90 10 20
            //홍길순 20 55 70
            //Record[] record = new Record[3];
            //record[0].Name = "홍길동";
            //record[0].Korean = 100;
            //record[0].English = 80;
            //record[0].Math = 70;

            //record[1].Name = "홍길란";
            //record[1].Korean = 90;
            //record[1].English = 10;
            //record[1].Math = 20;

            //record[2].Name = "홍길순";
            //record[2].Korean = 20;
            //record[2].English = 55;
            //record[2].Math = 70;

            //foreach(Record rec in record)
            //{
            //    rec.Print();
            //}

            Item item = new Item();
            item.Setting();
            item.ShowInventory();
            for (int i = 0; i <= 5; i++)
            {
                item.Add("하급 물약", 5);
            }
            item.Add("중급 물약", 1);
            item.Add("상급 물약", 1);
            item.Add("최상급 물약", 1);
            item.Add("수상한 물약", 1);
            item.Add("화염내성 물약", 1);
            item.Add("피로회복 물약", 1);
            item.Add("전설 물약", 1);
            item.Add("정화 물약", 1);
            item.Add("암흑 물약", 1);
            item.Add("빛 물약", 1);
            item.ShowInventory();
            item.Remove("하급 물약", 3);
            item.Remove("중급 물약", 2);
            item.Remove("상급 물약", 1);
            item.Remove("최상급 물약", 0);
            item.Remove("수상하지않은 물약", 1);
            //TextClear();
            item.ShowInventory();
            





        }
    }
}
