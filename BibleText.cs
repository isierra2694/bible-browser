using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibleBrowser
{
    /// <summary>
    /// Serves as a template for all Bible text to inherit from.
    /// </summary>
    public class BibleText
    {
        public BibleText(string bookID, int chapterNumber, int verseNumber, string text)
        {
            this.BookID = bookID;
            this.ChapterNumber = chapterNumber;
            this.VerseNumber = verseNumber;
            this.Text = text;
        }

        // Stores the book ID as a string.
        public string BookID { get; private set; }
        // Stores the chapter number (actual).
        public int ChapterNumber { get; private set; }
        // Stores the verse number (actual).
        public int VerseNumber { get; private set; }
        // Stores the verse body in a string.
        public string Text { get; private set; }
    }
}
