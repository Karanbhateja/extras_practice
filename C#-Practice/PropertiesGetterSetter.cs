using System;

namespace properties{

    class Car{

        private int speed;

        public int Speed{
            get{ return speed; }

            set{
                this.speed = value;
            }
        }
    }

    class Program{
        public static void Main(string[] args){
            Car c = new Car();
            c.Speed = 80;
            Console.WriteLine(c.Speed);
        }
    }
}