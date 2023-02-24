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

    public struct ReaderData
    {
        public ReaderData()
        {

        }

        static StreamReader data = new StreamReader(@"Readers.csv");

        public static string[] header = data.ReadLine().Split(';');

        public static string[] reader1 = data.ReadLine().Split(';');

        public static string[] reader2 = data.ReadLine().Split(';');

        public static void CheckTheСorrectness()
        {
            for (int i = 0; i <= reader1.Length; i+=2)
            {
                if (Int32.TryParse(reader1[i], out int elem) == false)
                {
                    Console.WriteLine($"Тип данных {reader1[i]} не совпал с типом {i+1}-го столбца таблицы Readers!");
                }
            }

            for (int i = 0; i <= reader2.Length; i += 2)
            {
                if (Int32.TryParse(reader2[i], out int elem) == false)
                {
                    Console.WriteLine($"Тип данных {reader1[i]} не совпал с типом {i+1}-го столбца таблицы Readers!");
                }
            }
        }
    }
}
