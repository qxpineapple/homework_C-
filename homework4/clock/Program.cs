using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clock
{
    public delegate void ClockEventHandler(object sender, ClockEventArgs args);

    //声明参数类型
    public class ClockEventArgs : EventArgs
    {
        public int hour;
        public int minute;
        public int second;

    }


    //定义事件源
    public class Clock
    {
        //声明事件，初值为null
        public event ClockEventHandler Time;

        public void GetTime(string day, string hour, string minute)
        {
            int clockday = Convert.ToInt32(day);
            int clockHour = Convert.ToInt32(hour);
            int clockminute = Convert.ToInt32(minute);
            DateTime dateTime = new DateTime(2018, 10, clockday, clockHour, clockminute, 0);
            while (DateTime.Now < dateTime)
            {

            }
            ClockEventArgs args = new ClockEventArgs();
            Time(this, args);

        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入闹钟10月几日：");
            string day = Console.ReadLine();
            Console.WriteLine("请输入闹钟时刻");
            string hour = Console.ReadLine();
            Console.WriteLine("请输入闹钟分刻");
            string minute = Console.ReadLine();
            Clock clock = new Clock();
            //注册事件
            clock.Time += ClockTime;
            clock.GetTime(day, hour, minute);


        }

        //事件处理方法
        static void ClockTime(object sender, ClockEventArgs args)
        {
            Console.WriteLine("时间到...\a\a");
        }
    }

}
