using System;
using System.Text;
using System.Text.Json;

namespace Laba2
{
    class Clock
    {
        public int hour;
        public int min;
        public int sec;

        public int hour1;
        public int min1;
        public int sec1;


        public void Time()
        {
            DateTime date = new DateTime(2022, 4, 6, hour, min, sec);
            Console.WriteLine(date.ToLongTimeString());
        }

        public void Time1()
        {
            DateTime date = new DateTime(2022, 4, 6, hour1, min1, sec1);
            Console.WriteLine(date.ToLongTimeString());
        }
        public void Dif()
        {
            if (hour1 > hour)
            {
                int difhour = hour1 - hour;
                int difmin = min1 - min;
                int difsec = sec1 - sec;
                if (difmin < 0 && difsec < 0)
                {
                    int difmin1 = difmin * (-1);
                    int difsec1 = difsec * (-1);
                    int result = difhour * 3600 + difmin1 * 60 + difsec1;
                    Console.WriteLine(result);
                }
                else if (difsec < 0)
                {
                    int difsec1 = difsec * (-1);
                    int result = difhour * 3600 + difmin * 60 + difsec1;
                    Console.WriteLine(result);
                }
                else if (difmin < 0)
                {
                    int difmin1 = difmin * (-1);
                    int result = difhour * 3600 + difmin1 * 60 + difsec;
                    Console.WriteLine(result);
                }
                else
                {
                    int result = difhour * 3600 + difmin * 60 + difsec;
                    Console.WriteLine(result);
                }
            }
            else
            {
                int difhour = hour - hour1;
                int difmin = min - min1;
                int difsec = sec - sec1;
                if (difmin < 0 && difsec < 0)
                {
                    int difmin1 = difmin * (-1);
                    int difsec1 = difsec * (-1);
                    int result = difhour * 3600 + difmin1 * 60 + difsec1;
                    Console.WriteLine(result);
                }
                else if (difsec < 0)
                {
                    int difsec1 = difsec * (-1);
                    int result = difhour * 3600 + difmin * 60 + difsec1;
                    Console.WriteLine(result);
                }
                else if (difmin < 0)
                {
                    int difmin1 = difmin * (-1);
                    int result = difhour * 3600 + difmin1 * 60 + difsec;
                    Console.WriteLine(result);
                }
                else
                {
                    int result = difhour * 3600 + difmin * 60 + difsec;
                    Console.WriteLine(result);
                }
            }


        }

        public void AddTime(int addmin)
        {
            DateTime date = new DateTime(2022, 4, 6, hour, min, sec);
            Console.WriteLine(date.AddMinutes(addmin));

            DateTime date1 = new DateTime(2022, 4, 6, hour1, min1, sec1);
            Console.WriteLine(date1.AddMinutes(addmin));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream fs = new FileStream("clock.json", FileMode.OpenOrCreate)) { }
            Clock clock = new Clock();
            Console.WriteLine("Введите начальное вермя: ");
            clock.hour = int.Parse(Console.ReadLine());
            clock.min = int.Parse(Console.ReadLine());
            clock.sec = int.Parse(Console.ReadLine());

            Console.WriteLine(new string('-', 30));

            Console.WriteLine("Введите конечное вермя: ");
            clock.hour1 = int.Parse(Console.ReadLine());
            clock.min1 = int.Parse(Console.ReadLine());
            clock.sec1 = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.Write("Начальное время ");
            clock.Time();
            Console.Write("Конечное время ");
            clock.Time1();
            Console.Write("Разница во времени в секундах: ");
            clock.Dif();
            Console.Write("Введите сколько вы хотите добавить минут: ");
            int addmin = int.Parse(Console.ReadLine());
            clock.AddTime(addmin);

            Console.ReadKey();
        }
    }
}