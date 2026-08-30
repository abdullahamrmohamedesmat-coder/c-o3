namespace assign03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1st answer
            #region first question

            int pages = 464;
            bool isAvailable = true;

            if (pages > 300 && isAvailable == true)
            {

                Console.WriteLine("you can borrow this book");
            }
            #endregion
            //2st question
            #region second question
            string title = "Refactoring";
            switch (title)
            {
                case "Clean Code":
                    Console.WriteLine("Great choice!");
                    break;

                case "Refactoring":
                    Console.WriteLine("Nice Peak!");
                    break;
                default:
                    Console.WriteLine("Never heard of it");
                    break;
            }
            #endregion
            // 3st answer
            #region 3st questioin
            int pages02 = 464;

            string sizeLabel = pages02 > 300 ? "long book" : "short book";
            Console.WriteLine(sizeLabel);
            #endregion
            //4st answer
            #region 4st question
            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{i + 1}:{books[i]}");
            }
            #endregion
            //5st answer
            #region 5st question
            string[] books02 = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            int j = 0;
            while (j < books02.Length)
            {
                Console.WriteLine($"{j + 1}: {books02[j]}");
                j++;

            }
            #endregion
            //6st answer
            #region 6st question
            int x = 0;
            do
            {
                string check = pages02 > 300 ? "checking book" : "short book";
                Console.WriteLine(check);
                x++;
            }
            while (x < 3);
            #endregion

            //7st answer
            #region 7st question
            foreach (string item in books02)
            {
                Console.WriteLine(item);
            }

            #endregion

            //8st answer
            #region 8st question
            for (int y = 0; y < books02.Length; y++)
            {
                if (books02[y] == "Refactoring")
                {
                    break;
                }
                Console.WriteLine(books02[y]);


            }
            #endregion

            //9st answer
            #region 9st question
            string[] book02 = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            foreach (string book in books)
            {
                if (book == "The pragmatic Programmer")
                {
                    continue;
                }
                Console.WriteLine(book);
            }
            #endregion

        }
    }
}
