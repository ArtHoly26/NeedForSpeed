using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    class SportCar : Car
    {
        private int speed;
        private string? color;
        private string? name;
        private string? type;
        private int record;
        public delegate void MashineInfo(string massage);
        public event MashineInfo? race;


        public override int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        public override string? Color
        {
            get { return color; }
            set { color = value; }
        }
        public override string? Name
        {
            get { return name; }
            set { name = value; }
        }
        public override string? Type
        {
            get { return type; }
            set { type = value; }
        }
        public override int Record { get { return record; } set { record = value; } }
        public SportCar(string name ,string color)
        {
            Speed = 0;
            Name=name;
            Color= color;
            Record = 0;
            Type = "Спортивный автомобиль";
        }
        public override void CarInfo()
        {
            Console.WriteLine($"Марка машины - {Name} Цвет - {Color} Тип автомобиля {Type} ");
        }
        public override void EngineCar()
        {
            Console.WriteLine($"Вжжжж!!! Машина {Name} завела двигатель и готова к старту!");
        }
        public override int SpeedСhange()
        {
            Span<byte> RndSpeed = new Span<byte>();
            RandomNumberGenerator.Fill(RndSpeed);
            Speed = RandomNumberGenerator.GetInt32(50, 300);
            return Speed;
        }
        public override void Finish()
        {
            Console.WriteLine("");
        }



    }
}
