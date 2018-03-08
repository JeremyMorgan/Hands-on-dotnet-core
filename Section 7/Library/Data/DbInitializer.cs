using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Data
{
    public class DbInitializer
    {
        public static void Initialize(LibraryContext context)
        {
            context.Database.EnsureCreated();

            // Look for any books
            if (context.Books.Any())
            {
                return;
            }

            var books = new Book[]
            {
                new Book{Title="How To Win Friends and Influence People", Description="Dale Carnegie’s rock-solid time-tested advice has carried countless people up the ladder of success", Author="Dale Carnegie", CheckedOut=false},
                new Book{Title="East of Eden", Description="A masterpiece of Biblical scope and the magnum opus of one of America’s most enduring authors in a commemorative hardcover edition", Author="John Steinbeck", CheckedOut=false},
                new Book{Title="Snow Crash: A Novel", Description="In reality Hiro Protagonist delivers pizza for Uncle Enzo’s CosoNostra Pizza Inc.but in the Metaverse he’s a warrior prince.", Author = "Neal Stephenson", CheckedOut = false},
                new Book{Title="Neuromancer", Description="Case was the sharpest data-thief in the matrix—until he crossed the wrong people and they crippled his", Author="William Gibson", CheckedOut=false }
            };

            foreach (Book b in books)
            {
                context.Books.Add(b);
            }
            context.SaveChanges();


        }
    }
}
