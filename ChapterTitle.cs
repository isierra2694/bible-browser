using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibleBrowser
{
    /// <summary>
    /// ChapterTitle displays a title for each chapter.  ChapterTitles must have zero as the verseNumber.
    /// </summary>
    public class ChapterTitle : BibleText
    {
        public List<Verse> Verses { get; set; }

        public ChapterTitle(string bookID, int chapterNumber, int verseNumber) : base(bookID, chapterNumber, verseNumber, "Chapter " + chapterNumber)
        {
            Verses = new List<Verse>();
        }
    }
}
