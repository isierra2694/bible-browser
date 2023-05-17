using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibleBrowser
{
    public class BookTitle : BibleText
    {
        public BookTitle(string bookID, int chapterNumber, int verseNumber, string text) : base(bookID, chapterNumber, verseNumber, text)
        {

        }
    }
}
