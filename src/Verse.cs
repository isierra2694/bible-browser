using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibleBrowser
{
    /// <summary>
    /// Verse class.  Stores verse info and has some handy methods.
    /// </summary>
    public class Verse
    {
        public Verse(string bookID, int chapterNumber, int verseNumber, string verseText)
        {
            this.bookID = bookID;
            this.chapterNumber = chapterNumber;
            this.verseNumber = verseNumber;
            this.verseText = verseText;
        }

        /// <summary>
        /// Returns the verse text as a string.
        /// </summary>
        /// <returns></returns>
        public string ToString()
        {
            return verseText;
        }

        /// <summary>
        /// Checks if another verse is equal to this one.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(Verse other)
        {
            if (other.bookID != this.bookID) return false;
            else if (other.chapterNumber != this.chapterNumber) return false;
            else if (other.verseNumber != this.verseNumber) return false;
            return true;
        }

        // Stores the book ID as a string.
        public string bookID { get; private set; }
        // Stores the chapter number (actual).
        public int chapterNumber { get; private set; }
        // Stores the verse number (actual).
        public int verseNumber { get; private set; }
        // Stores the verse body in a string.
        public string verseText { get; private set; }
    }
}
