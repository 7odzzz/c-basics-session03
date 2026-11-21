using System.Reflection.Emit;
using System.Text;

namespace C__basics_assigment_lec_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region FirstPoint
            //string title = "clean code"; //immutable
            //string upperTitle = title.ToUpper();
            //Console.WriteLine($"Title: {title}"); //clean code
            //Console.WriteLine($"UpperTitle: {upperTitle}"); // CLEAN CODE
            #endregion

            #region SecondPoint
            //string str01 = "Clean Code";
            //string str02 = "Clean Code"; //string interning both obj has the same values
            //Console.WriteLine(object.ReferenceEquals(str01,str02)); //True

            #endregion

            #region ThirdPoint,FourthPoint
            //StringBuilder sb = new StringBuilder();
            //sb.Append("Book List"); // modify with same obj
            //sb.Append(" -Updated"); // modify
            //Console.WriteLine(sb.ToString()); // Book List -Updated

            //sb.Replace("Book List", "Library"); //changed Book List to Library
            //Console.WriteLine($"Sb: {sb.ToString()}"); // Library-Updated
            #endregion

            #region FifthPoint,SixthPoint,SeventhPoint
            //string title = "Clean Code";
            //int page = 464;
            //Console.WriteLine("Book: " + title + ", " + "Pages: " + page); // Book: Clean Code, Pages: 464
            //Console.WriteLine($"Book: {title}, Pages: {page}"); // Book: Clean Code, Pages: 464
            //Console.WriteLine(string.Format("Book: {0}, Pages: {1}" , title,page)); // Book: Clean Code, Pages: 464
            #endregion

            #region EighthPoint
            //int pages = 464;

            //if(pages > 300)
            //    Console.WriteLine("Long Book");
            //else
            //    Console.WriteLine("Short Book");
            #endregion

            #region NinthPoint
            //int pages = 464;
            //bool isAvailable = true;

            //if (pages > 300 && isAvailable)
            //    Console.WriteLine("You can borrow this book"); // both true so it executes

            #endregion

            #region TenthPoint

            //string title = "Refactoring";
            //switch (title)
            //{
            //    case "Clean Code":
            //        Console.WriteLine("Great Choice");
            //        break;

            //    case "Refactoring":
            //        Console.WriteLine("Nice Pick");
            //        break;

            //    default:
            //        Console.WriteLine("Never heard of it");
            //        break;



            //}
            #endregion

            #region ElevnthPoint
            //int pages = 464;
            //string sizeLabel = pages > 300 ? "Long Book" : "Short Book";
            //Console.WriteLine(sizeLabel);
            #endregion

            #region AllLoopsPoints 
            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring", "7odz" }; // added the last index to test the loops and jumping statments good


            ////----------------------------------------------
            //for (int i = 0; i < books.Length; i++)
            //{
            //    Console.WriteLine($"Book {i + 1}: {books[i]}");
            //}
            //Console.WriteLine("Finished For Loop");

            ////----------------------------------------------
            //Console.WriteLine("------------");

            //int count = 0;
            //while (count < books.Length)
            //{
            //    Console.WriteLine($"Book {count + 1}: {books[count]}");
            //    count++;

            //    if (count >= books.Length)
            //        break;
            //}
            //Console.WriteLine("Finished While Loop");

            ////----------------------------------------------
            //Console.WriteLine("----------");
            //int counter = 0;
            //do
            //{
            //    Console.WriteLine($"Checking Book{counter + 1}....");
            //    counter++;
            //} while (counter < books.Length - 1);

            //Console.WriteLine("finished Do-While Loop");
            ////----------------------------------------------
            //Console.WriteLine("----------");
            //foreach (string book in books)
            //{
            //    Console.WriteLine($"book:{book}");
            //}
            //Console.WriteLine("Finished Foreach Loop");

            ////----------------------------------------------
            //Console.WriteLine("----------");
            //for (int i = 0; i < books.Length; i++)
            //{
            //    Console.WriteLine($"Book {i + 1}: {books[i]} ");

            //    if (books[i] == "Refactoring")
            //        break;
            //}
            ////----------------------------------------------

            //Console.WriteLine("----------");
            //for (int i = 0; i < books.Length; i++)
            //{
            //    if (books[i] == "The Pragmatic Programmer")
            //        continue;

            //    Console.WriteLine($"Book {i + 1}: {books[i]} ");
            //}

            #endregion

            #region LastPoint
            //string[] books01 = new string[0]; // domi data
            //PrintFirstBook(books01); // return nothing - Null

            //string[] books = { "clean code " ,"the pragmatic programmer", "Refactoring" }; // domi data
            //PrintFirstBook(books); // return book 1 : Clean code


            #endregion




        }

        public static void PrintFirstBook(string[] booksMethod)
        {
            if (booksMethod.Length == 0) //hard coded
            {
                Console.WriteLine("Function Returned Null");
                return;
            }
            Console.WriteLine($"Book 1: {booksMethod[0]}");


        }



    }
}

    
