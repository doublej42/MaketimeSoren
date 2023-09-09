using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarms
{
    internal class Alarm
    {
        public Alarm() { }
        public TimeOnly Time { get; set; }
        public int Tone { get; set; }
        public string Message { get; set; }
    }
}
