using System.Globalization;

namespace DummyDB
{
    class Program
    {
        public static CultureInfo cultureInfo = new CultureInfo("ru-RU");

        public static void Main(string[] args)
        {
            BookData.CheckTheСorrectness();

            ReaderData.CheckTheСorrectness();

            ReadersBooksData.CheckTheСorrectness();

            List<Reader> Readers = new List<Reader>
            {
                new Reader
                {
                    Id = Convert.ToUInt32(ReaderData.reader1[0]),

                    FIO = ReaderData.reader1[1],

                    TicketNumber = Convert.ToUInt32(ReaderData.reader1[2]),

                    CaptureDate = new Dictionary<uint, DateTime>
                    {
                        { 2, new DateTime(2022, 12, 1) }
                    }
                },

                new Reader
                {
                    Id = Convert.ToUInt32(ReaderData.reader2[0]),

                    FIO = ReaderData.reader2[1],

                    TicketNumber = Convert.ToUInt32(ReaderData.reader2[2]),

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
                    Id = Convert.ToUInt32(BookData.book1[0]),

                    Author = BookData.book1[1],

                    Title = BookData.book1[2],

                    PublicationYear = Convert.ToUInt32(BookData.book1[3]),

                    CabinetNumber = Convert.ToUInt16(BookData.book1[4]),

                    ShelfNumber = Convert.ToByte((BookData.book1[5]))
                },

                new Book
                {
                    Id = Convert.ToUInt32(BookData.book2[0]),

                    Author = BookData.book2[1],

                    Title = BookData.book2[2],

                    PublicationYear = Convert.ToUInt32(BookData.book2[3]),

                    CabinetNumber = Convert.ToUInt16(BookData.book2[4]),

                    ShelfNumber = Convert.ToByte((BookData.book2[5]))
                },

                new Book
                {
                    Id = Convert.ToUInt32(BookData.book3[0]),

                    Author = BookData.book3[1],

                    Title = BookData.book3[2],

                    PublicationYear = Convert.ToUInt32(BookData.book3[3]),

                    CabinetNumber = Convert.ToUInt16(BookData.book3[4]),

                    ShelfNumber = Convert.ToByte((BookData.book3[5]))
                },

            };
        }
    }
}