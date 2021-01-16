using System;

namespace CommandPattern
{
    public class Light
    {
        public void On()
        {
            Console.WriteLine("Light turned on");
        }

        public void Off()
        {
            Console.WriteLine("Light turned off");
        }
    }
}