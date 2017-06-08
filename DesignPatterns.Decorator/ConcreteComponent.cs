using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    class Book : LibraryItem
    {
        private string _author;
        private string _title;

        public Book(string author, string title, int numCopies)
        {
            this._author = author;
            this._title = title;
            this.NumCopies = numCopies;
        }

        public override void Display()
        {
            Console.WriteLine("\nBook ------");
            Console.WriteLine("\tAuthor:\t{0}", _author);
            Console.WriteLine("\tTitle:\t{0}", _title);
            Console.WriteLine("\t# Copies:\t{0}", NumCopies);
        }
    }

    class Video : LibraryItem
    {
        private string _director;
        private string _title;
        private int _playTime;

        public Video(string director, string title, int numCopies, int playTime)
        {
            this._director = director;
            this._title = title;
            this.NumCopies = numCopies;
            this._playTime = playTime;
        }

        public override void Display()
        {
            Console.WriteLine("\nVideo ----- ");
            Console.WriteLine("\tDirector:\t{0}", _director);
            Console.WriteLine("\tTitle:\t{0}", _title);
            Console.WriteLine("\t# Copies:\t{0}", NumCopies);
            Console.WriteLine("\tPlaytime:\t{0}\n", _playTime);
        }
    }
}
