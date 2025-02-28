using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day7
{

    class Game
    {
        public static int mineral;
        public static int gas;
        public static int unitCount;

        public static void ShowInfo()
        {
            Console.WriteLine($"미네랄 {mineral}, 가스 {gas} , 유닛 {unitCount}");
        }
    }
    class Mineral
    {
        int mineral;
        public Mineral()
        {
            this.mineral = 1500;
        }
        public Mineral(int mineral)
        {
            this.mineral = mineral;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"미네랄 갯수 : {mineral}");
        }
    }

    class Unit
    {
        public string name;
        public int mineral;

        public Unit(string name, int mineral)
        {
            this.name = name;
            this.mineral = mineral;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"이름 : {name}, 미네랄 : {mineral}");
        }
    }

    class Struct
    {
        public string name;
        public int mineral;

        public Struct(string name, int mineral)
        {
            this.name = name;
            this.mineral = mineral;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"이름 : {this.name}, 미네랄 : {this.mineral}");
        }
    }


    class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void ShowInfo()
        {
            Console.WriteLine($"이름 : {name}");
        }
    }

    //마린클래스
    //프로퍼티이용해서 이름과 미네랄을 만드시오 이름 마린 미네랄 50
    class Marin
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        //public int Mineral { get; set; } //똑같은 역할인데 내부 변수이름이 개떡같이된다
        private int mineral;
        public int Mineral
        {
            get { return mineral; }
            set { mineral = value; }
        }

        public void ShowInfo()
        {
            Console.WriteLine($"이름 : {name}, 미네랄 {mineral}");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //Person p = new Person("홍길동", 10);
            //Unit marin = new Unit("마린", 50);
            //Unit scv = new Unit("SCV", 75);
            //Struct barrack = new Struct("Barrack", 150);
            //marin.ShowInfo();
            //scv.ShowInfo();
            //barrack.ShowInfo();
            //p.ShowInfo();
            int maxArray = 7;
            Mineral[] mineral = new Mineral[maxArray];
            for(int i = 0; i < maxArray; i++)
            {
                mineral[i] = new Mineral();
                mineral[i].ShowInfo();
            }
            Game.mineral = 150;
            Game.gas = 0;
            Game.unitCount = 8;
            Game.ShowInfo();
            Person person = new Person();
            person.Name = "홍길동";
            Console.WriteLine($"이름 {person.Name}");

            Marin marin = new Marin();
            marin.Name = "마린";
            marin.Mineral = 50;
            marin.ShowInfo();
            Console.WriteLine($"이름 : {marin.Name}, 미네랄 {marin.Mineral}");

        }
    }
}
