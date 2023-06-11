using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibleBrowser
{
    public class Verse : BibleText
    {
        public string FormattedVerse { get; set; }

        public string VerseText { get; set; }

        public Verse(string bookID, int chapterNumber, int verseNumber, string text, string fullTitle) : base(bookID, chapterNumber, verseNumber, verseNumber + "  " + text)
        {
            this.FormattedVerse = fullTitle + " " + chapterNumber + ":" + verseNumber;
            this.VerseText = text;
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
