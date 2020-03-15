using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ClockEvent
{
    class ClockEvent
    {
        public delegate void AlarmEvent();
        public delegate void TickEvent();
        public event AlarmEvent alarmEvent;
        public event TickEvent tickEvent;
        public int AHour, AMinute, ASecond = 0;
        public void SetAlarm(int h, int m, int s)
        {
            AHour = h;
            AMinute = m;
            ASecond = s;
        }
        public void Tick()
        {
            tickEvent();
        }
        public void Alarm()
        {
            alarmEvent();
        }
    }
    class ClockStart
    {
        public ClockEvent myClock = new ClockEvent();

        public void StartWork()
        {

            while (true)
            {
                myClock.Tick();
                int hour = DateTime.Now.Hour;
                int minute = DateTime.Now.Minute;
                int second = DateTime.Now.Second;
                if (myClock.AHour == hour && myClock.AMinute == minute && myClock.ASecond == second)
                {
                    myClock.Alarm();
                }
                Thread.Sleep(1000);
            }

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            ClockStart clockstart = new ClockStart();
            clockstart.myClock.alarmEvent += Alarming;
            clockstart.myClock.tickEvent += Ticking;
            clockstart.myClock.SetAlarm(3, 7, 37);
            clockstart.StartWork();
        }
        public static void Alarming()
        {
            Console.WriteLine("Alarm!!!");
        }
        public static void Ticking()
        {
            Console.WriteLine("Tick");
        }
    }
}

