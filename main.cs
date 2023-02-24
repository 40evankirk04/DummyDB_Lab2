using System.Globalization;

namespace DummyDB
{
    class Program
    {
        CultureInfo cultureInfo = new CultureInfo("ru-RU", false);

        public static void Main(string[] args)
        {

            List<Reader> Readers = new List<Reader>
            {
                new Reader
                {
                    Id = 1,

                    FIO = "Николаев Иван Евгеньевич",

                    TicketNumber = 1,

                    CaptureDate = new Dictionary<uint, DateTime>
                    {
                        { 2, new DateTime(2022, 12, 1) }
                    }
                },

                new Reader
                {
                    Id = 2,

                    FIO = "Александр Олегович Костылев",

                    TicketNumber = 2,

                    CaptureDate = new Dictionary<uint, DateTime>
                    {
                        { 3, new DateTime(2022, 10, 5) }
                    },

                    ReturnDate = new Dictionary<uint, DateTime>
                    {
                        {3, new DateTime(2022, 11, 5) }
                    }
                }
            };

            List<Book> books = new List<Book>
            {
                new Book 
                {
                    Id = 1,

                    Author = "Толстой Л. Н.",

                    Title = "Война и Мир",

                    PublicationYear = 1867,

                    CabinetNumber = 1,

                    ShelfNumber = 1
                },

                new Book
                {
                    Id = 2,

                    Author = "Толстой Л. Н.",

                    Title = "Анна Каренина",

                    PublicationYear = 1878,

                    CabinetNumber = 1,

                    ShelfNumber = 1
                },

                new Book
                {
                    Id = 3,

                    Author = "Толстой Л. Н.",

                    Title = "Казаки",

                    PublicationYear = 1863,

                    CabinetNumber = 1,

                    ShelfNumber = 2
                },

            };
        }
    }
}