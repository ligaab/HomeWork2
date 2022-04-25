using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    public class Phone
    {
        public string Size { get; set; }
        public string Brand { get; set; }
        public string Mark { get; set; }
        public void Call()
        {
            Console.WriteLine("Calling");
        }
        public void SendSms()
        {
            Console.WriteLine("SMS sent");
        }
    }
}
