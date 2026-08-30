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
        }
    }
}
