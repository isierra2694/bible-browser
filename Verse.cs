using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibleBrowser
{
    public class Verse : BibleText
    {
        public Verse(string bookID, int chapterNumber, int verseNumber, string text) : base(bookID, chapterNumber, verseNumber, text)
        {

        }

        /// <summary>
        /// Returns the verse text as a string.
        /// </summary>
        /// <returns></returns>
        public string ToVerseString()
        {
            return this.Text;
        }

        /// <summary>
        /// Checks if another verse is equal to this one.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(Verse other)
        {
            if (other.BookID != this.BookID) return false;
            else if (other.ChapterNumber != this.ChapterNumber) return false;
            else if (other.VerseNumber != this.VerseNumber) return false;
            return true;
        }
    }
}
