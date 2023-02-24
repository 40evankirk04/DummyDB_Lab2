using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DummyDB
{
    public class Reader
    {
        public uint Id;

        public string FIO;

        public uint TicketNumber;

        public Dictionary<uint, DateTime> CaptureDate;

        public Dictionary<uint, DateTime> ReturnDate;
    }
}
