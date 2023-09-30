using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NeedForSpeed
{
    public class Game
    {
        private int time;
        private int disctance;
        private int distFuct;
        private bool flag;
        private int position;
        public delegate void MashineIsReady();
        public delegate void FinishCar(string massage);
        public event FinishCar? finish;

        private List<Car> listcar;
        public int Time { get { return time; } set { time = value; } }
        public int Disctance { get { return disctance; } set { disctance = value; } }
        public int DistFuct { get { return distFuct; } set { distFuct = value; } }
        public bool Flag { get { return flag; } set { flag = value; } }
        public int Position { get { return position; } set { position = value; } }
        public List<Car> ListCar { get { return listcar; } set { listcar = value; } }
        public MashineIsReady Mashine { get; set; }
        public Game(List<Car> listcar)
        {
            Time = 0;
            Disctance = 100000;
            DistFuct = 0;
            Flag = false;
            Position = 0;
            ListCar = new List<Car>(listcar);
        }
        public void PrintInfoMember()
        {
            Console.WriteLine("Список участников:");
            foreach (Car car in ListCar)
            {
                car.CarInfo();
            }
        }
        public void MashineReady()
        {
            foreach (Car car in ListCar)
            {
                Mashine = car.CarInfo;
                Mashine += car.EngineCar;
                Mashine();
            }
        }
        public void Races()
        {
            finish += DisplayMessage;
            void DisplayMessage(string message) => Console.WriteLine(message);
            foreach (Car car in ListCar)
            {
                do
                {
                    DistFuct = DistFuct + car.SpeedСhange() * 10;
                    InfoRace(car);
                    if (DistFuct >= Disctance)
                    {
                        flag = true;
                        DistFuct = 0;
                    }
                } while (!flag);
                FinishMassage(time, car);
                time = 0;
                flag = false;
            }
        }
        public void InfoRace(Car car)
        {
                time += 10;
                finish?.Invoke($"Прошло - {time} секунд, машина {car.Name} проехала - {DistFuct} расстояние, текущая скорость - {car.Speed}");   
        }
        public void FinishMassage(int _time ,Car car)
        {
            car.Record=_time;
            finish?.Invoke($"Машина {car.Name} финишировала за {car.Record} время ");   
        }
        public void ResultRace()
        {
            Console.WriteLine("Результаты заезда:");
            foreach(Car car in ListCar)
            {
                Console.WriteLine($"Время - {car.Record}, машина - {car.Name}");
            }
        }
    }
}
