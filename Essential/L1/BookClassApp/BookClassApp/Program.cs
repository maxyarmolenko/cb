using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace BookClassApp
{
    class Book
    {
        public Title title = new Title ("Harry Potter and the Philosopher's Stone");
        Author name = new Author("J.K. Rowling");
        Content subject = new Content("\n1 The Boy Who Lived   p. 1 \n2 The Vanishing Glass   p. 18 \n3 The Letters from No One   p. 31 \n4 The Keeper of the Keys   p. 46 \n5 Diagon Alley   p. 61 \n6 The Journey from Platform Nine and Three-quarters   p. 88 \n7 The Sorting Hat   p. 113 \n8 The Potions Master   p. 131 \n9 The Midnight Duel   p. 143 \n10 Halloween   p. 163 \n11 Quidditch   p. 180 \nThe Mirror of Erised   p. 194 \n13 Nicolas Flamel   p. 215 \n14 Norbert The Norwegian Ridgeback   p. 228 \n15 The Forbidden Forest   p. 242 \n16 Through the Trapdoor   p. 262 \n17 The Man with Two Faces   p. 288 ");
    }

   class Title
    {
        private string title = null;

        public Title(string title)
        {
            this.title = title;
            Show();
        }

        public string TitleProperty
        {
            set { title = value; }
            get { return title; }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\n\a Title of the book: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(title);
            Console.WriteLine();
        }

    }

   class Author
    {
        private string name = null;

        public Author (string name)
        {
            this.name = name;
            Show();
        }

        public string NameProperty
        {
            set { name = value; }
            get { return name; }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\a Author of the book: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(name);
            Console.WriteLine();
        }

    }

    class Content
    {
        private string subject = null;

        public Content(string subject)
        {
            this.subject = subject;
            Show();
        }

        public string SubjectProperty
        {
            set { subject = value; }
            get { return subject; }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("\a Content of the book: ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(subject);
            Console.WriteLine();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
           Book instance = new Book();

           Console.ReadKey();
        }

    }

}
