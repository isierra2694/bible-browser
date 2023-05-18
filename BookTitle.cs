using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibleBrowser
{
    public class BookTitle : BibleText
    {
        /// <summary>
        /// The text that goes before "The Book Of", stuff like "The First Book of Moses"
        /// </summary>
        public string Descriptor { get; set; }

        public BookTitle(string bookID, int chapterNumber, int verseNumber, string text, string descriptor = "") : base(bookID, chapterNumber, verseNumber, text)
        {
            this.Descriptor = descriptor;
        }
    }
}
