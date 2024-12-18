
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace Advpart2
{

    //public delegate T fPtr<T, T1>(T1 x);
    public delegate string fPtr(Book x);

    public class Book
    {
        public Book() { }

        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }

        public Book(string _ISBN, string _Title, string[] _Authors, DateTime _PublicationDate, decimal _Price)
        {
            this.ISBN = _ISBN;
            this.Title = _Title;
            this.Authors = _Authors;
            this.PublicationDate = _PublicationDate;
            this.Price = _Price;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder($"{ISBN}-{Title}-{PublicationDate}  {Price.ToString()}$\t");
            foreach (var item in Authors)
            {
                stringBuilder.Append(item.ToString() + "\t");
            }

            return stringBuilder.ToString();
        }
        public  string ToString(Book B)
        {
            StringBuilder stringBuilder = new StringBuilder($"{B.ISBN}-{B.Title}-{B.PublicationDate}  {B.Price.ToString()}$\t");
            foreach (var item in B.Authors)
            {
                stringBuilder.Append(item.ToString() + "\t");
            }

            return stringBuilder.ToString();
        }
    }

    public class BookFunctions
    {
        public static string GetTitle(Book B)
        {
            return B.Title;
        }
        public static string GetISBN(Book B)
        {
            return B.ISBN;
        }
        public static string GetDate(Book B)
        {
            return B.PublicationDate.ToShortDateString();
        }
       

        public static string GetAuthors(Book B)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < B.Authors.Length;i++) 
                sb.Append(B.Authors[i].ToString());                
            return sb.ToString();
        }

        public static string GetPrice(Book B)
        {
            return B.Price.ToString()+"$";
        }
    }

    public class LibraryEngine
    {
        public static void ProcessBooks(List<Book> bList, fPtr Ptr)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(Ptr(B));
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            List<Book> B = new List<Book>()
            {
                new Book("1", "Book1", new string[] {"Author1"}, DateTime.Now, 500),
                new Book("2", "Book2", new string[] {"Author2"}, DateTime.Now, 600),
                new Book("3", "Book3", new string[] {"Author3"}, DateTime.Now, 700),
                new Book("4", "Book4", new string[] {"Author4"}, DateTime.Now, 800)
            };
            //List<Book> LB = new List<Book>() {

            //LB.Add( new Book () );

            //LB.Add(ISBN1),
            //LB.Add(ISBN2),
            //LB.Add(ISBN3),




            //};
            //foreach (Book B in LB)
            //{

            //    Console.WriteLine("Enter Book ISBN");
            //    string ISBN = Console.ReadLine();

            //    Console.WriteLine("Enter Book ISBN");
            //    string ISBN1 = Console.ReadLine();


            //    Console.WriteLine("Enter Book ISBN");
            //    string ISBN2 = Console.ReadLine();


            //    Console.WriteLine("Enter Book ISBN");
            //    string ISBN3 = Console.ReadLine();


            //}

            Book M = new Book();
            fPtr RfPtr = M.ToString;
            LibraryEngine.ProcessBooks(B, RfPtr);
            Console.WriteLine("-----------------------------------------------");
            Func<Book, string> S = BookFunctions.GetISBN;
            LibraryEngine.ProcessBooks(B, S.Invoke);
            Console.WriteLine("-------");
            Func<Book, string> d = delegate (Book y) { return y.Title; };
            LibraryEngine.ProcessBooks(B, d.Invoke);
            Console.WriteLine("-------");
            Func<Book, string> F = delegate (Book B1) { return BookFunctions.GetAuthors(B1); };
            LibraryEngine.ProcessBooks(B, F.Invoke);
            Console.WriteLine("-------");
            fPtr RfPtr2 = BookFunctions.GetDate;
            LibraryEngine.ProcessBooks(B, RfPtr2);
            Console.WriteLine("-------");
            Func<Book, string> W = B2 => (BookFunctions.GetPrice(B2));
            LibraryEngine.ProcessBooks(B, W.Invoke);
            



            //RfPtr.Invoke(B);
            //  Func<Book, string> W = X => X.ISBN;
            //  Func <List<Book>, fPtr> W= B1.ProcessBooks;
            //fPtr<string, Book> RfPtr = BookFunctions.GetTitle;
            //LibraryEngine.ProcessBooks(B, W);
            //Func<Book, string> d = delegate (Book y) { return y.ISBN; };
            //LibraryEngine.ProcessBooks(B, d);

        }
    }
}
