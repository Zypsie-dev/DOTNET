using System;
namespace Dotnet
{
    public partial class Books
    {
        private string Author_name;
        private int Total_articles;

        public Books(string a, int t)
        {
            this.Author_name = a;
            this.Total_articles = t;
        }
    }
    class Program
    {
        static void Maina(string[] args)
        {
            Books books = new Books("nabin", 12);
            books.Display();
        }
    }
}

