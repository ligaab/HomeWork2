using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    public class Car
    {
        public string Brand { get; set; }
        public string Nummber { get; set; }
        public double Speed { get; set; }
        public void StartToDrive()
        {
            Speed = 10;
            Console.WriteLine("Start driving");
        }
        public double GoFaster()
        {
            Speed += 10;
            Console.WriteLine("Speed-" + Speed);
            return Speed;
        }
        public void Beep()
        {
            Console.WriteLine("BEEP beeep");
        }
        public double SlowDown()
        {
            Speed -= 10;
            Console.WriteLine("Speed-" + Speed);
            return Speed;
        }
        public void Stop()
        {
            Speed = 0;
            Console.WriteLine("Stop");
        }
     
    }
}
