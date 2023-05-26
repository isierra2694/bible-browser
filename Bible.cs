using System;
using System.IO;
using System.Collections;
using System.Windows.Controls;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Windows.Documents;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibleBrowser
{
    internal class Bible
    {
        public Bible()
        {
            currentVerse = new Verse("", 0, 0, "");
        }

        /// <summary>
        /// Loads a new Bible file.
        /// </summary>
        /// <param name="filePath">Bible path</param>
        /// <param name="listBox">ListBox to append verses to</param>
        /// <exception cref="NullReferenceException"></exception>
        public async Task Load(string filePath, ListView documentViewer)
        {
            if (!File.Exists(filePath)) throw new NullReferenceException();

            try
            {
                using (var reader = new StreamReader(filePath))
                {
                    string line;

                    while ((line = await reader.ReadLineAsync()) != null) ParseVerse(line);
                }
                foreach (KeyValuePair<(string, int, int), BibleText> line in lines)
                {
                    documentViewer.Items.Add(line.Value);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
            
        /// <summary>
        /// Returns the list of lines in this Bible.
        /// </summary>
        /// <returns></returns>
        public Dictionary<(string, int, int), BibleText> GetLines()
        {
            return lines;
        }

        /// <summary>
        /// Parse the line read from StreamReader and create a verse.
        /// </summary>
        /// <param name="verse"></param>
        private void ParseVerse(string verse)
        {
            string pattern = @"^(\d*[A-Za-z]+)(\d+):(\d+)\s+(.*)$";
            Match match = Regex.Match(verse, pattern);

            if (match.Success)
            {
                string bookID = match.Groups[1].Value;
                int chapterNumber = Int32.Parse(match.Groups[2].Value);
                int verseNumber = Int32.Parse(match.Groups[3].Value);
                string verseText = match.Groups[4].Value;
                
                Verse newVerse = new Verse(bookID, chapterNumber, verseNumber, verseText);
                
                if (currentVerse.BookID != newVerse.BookID)
                {
                    lines.Add((bookID, chapterNumber - 1, verseNumber - 1), new BookTitle(bookID, chapterNumber, verseNumber, "The Book of " + bibleBooks[match.Groups[1].Value], bookDescriptors[match.Groups[1].Value]));
                }
                if (currentVerse.ChapterNumber != newVerse.ChapterNumber || currentVerse.BookID != newVerse.BookID)
                {
                    lines.Add((bookID, chapterNumber, verseNumber - 1), new ChapterTitle(bookID, chapterNumber, verseNumber));
                }
                currentVerse = newVerse;
                lines.Add((bookID, chapterNumber, verseNumber), newVerse);
            }
        }

        private Verse currentVerse;
        private Dictionary<(string, int, int), BibleText> lines = new Dictionary<(string, int, int), BibleText>();
        private Dictionary<string, string> bibleBooks = new Dictionary<string, string>()
        {
            { "Ge", "Genesis" },
            { "Exo", "Exodus" },
            { "Lev", "Leviticus" },
            { "Num", "Numbers" },
            { "Deu", "Deuteronomy" },
            { "Josh", "Joshua" },
            { "Jdgs", "Judges" },
            { "Ruth", "Ruth" },
            { "1Sm", "1 Samuel" },
            { "2Sm", "2 Samuel" },
            { "1Ki", "1 Kings" },
            { "2Ki", "2 Kings" },
            { "1Chr", "1 Chronicles" },
            { "2Chr", "2 Chronicles" },
            { "Ezra", "Ezra" },
            { "Neh", "Nehemiah" },
            { "Est", "Esther" },
            { "Job", "Job" },
            { "Psa", "Psalms" },
            { "Prv", "Proverbs" },
            { "Eccl", "Ecclesiastes" },
            { "SSol", "Song of Solomon" },
            { "Isa", "Isaiah" },
            { "Jer", "Jeremiah" },
            { "Lam", "Lamentations" },
            { "Eze", "Ezekiel" },
            { "Dan", "Daniel" },
            { "Hos", "Hosea" },
            { "Joel", "Joel" },
            { "Amos", "Amos" },
            { "Obad", "Obadiah" },
            { "Jonah", "Jonah" },
            { "Mic", "Micah" },
            { "Nahum", "Nahum" },
            { "Hab", "Habakkuk" },
            { "Zep", "Zephaniah" },
            { "Hag", "Haggai" },
            { "Zec", "Zechariah" },
            { "Mal", "Malachi" },
            { "Mat", "Matthew" },
            { "Mark", "Mark" },
            { "Luke", "Luke" },
            { "John", "John" },
            { "Acts", "Acts" },
            { "Rom", "Romans" },
            { "1Cor", "1 Corinthians" },
            { "2Cor", "2 Corinthians" },
            { "Gal", "Galatians" },
            { "Eph", "Ephesians" },
            { "Phi", "Philippians" },
            { "Col", "Colossians" },
            { "1Th", "1 Thessalonians" },
            { "2Th", "2 Thessalonians" },
            { "1Tim", "1 Timothy" },
            { "2Tim", "2 Timothy" },
            { "Titus", "Titus" },
            { "Phmn", "Philemon" },
            { "Heb", "Hebrews" },
            { "Jas", "James" },
            { "1Pet", "1 Peter" },
            { "2Pet", "2 Peter" },
            { "1Jn", "1 John" },
            { "2Jn", "2 John" },
            { "3Jn", "3 John" },
            { "Jude", "Jude" },
            { "Rev", "Revelation" }
        };
        private Dictionary<string, string> bookDescriptors = new Dictionary<string, string>()
        {
            { "Ge", "The First Book of Moses" },
            { "Exo", "The Second Book of Moses" },
            { "Lev", "The Third Book of Moses" },
            { "Num", "The Fourth Book of Moses" },
            { "Deu", "The Fifth Book of Moses" },
            { "Josh", "" },
            { "Jdgs", "" },
            { "Ruth", "" },
            { "1Sm", "The First Book of Kings" },
            { "2Sm", "The Second Book of Kings" },
            { "1Ki", "The Third Book of Kings" },
            { "2Ki", "The Fourth Book of Kings" },
            { "1Chr", "1 Chronicles" },
            { "2Chr", "2 Chronicles" },
            { "Ezra", "" },
            { "Neh", "" },
            { "Est", "" },
            { "Job", "" },
            { "Psa", "" },
            { "Prv", "" },
            { "Eccl", "" },
            { "SSol", "" },
            { "Isa", "The Book of the Prophet Isaiah" },
            { "Jer", "The Book of the Prophet Jeremiah" },
            { "Lam", "The Lamentations of Jeremiah" },
            { "Eze", "The Book of the Prophet Ezekiel" },
            { "Dan", "" },
            { "Hos", "" },
            { "Joel", "" },
            { "Amos", "" },
            { "Obad", "" },
            { "Jonah", "" },
            { "Mic", "" },
            { "Nahum", "" },
            { "Hab", "" },
            { "Zep", "" },
            { "Hag", "" },
            { "Zec", "" },
            { "Mal", "" },
            { "Mat", "The Gospel According to Matthew" },
            { "Mark", "The Gospel According to Mark" },
            { "Luke", "The Gospel According to Luke" },
            { "John", "The Gospel According to John" },
            { "Acts", "The Acts of the Apostles" },
            { "Rom", "The Epistle of Paul the Apostle to the Romans" },
            { "1Cor", "The First Epistle of Paul the Apostle to the Corinthians" },
            { "2Cor", "The Second Epistle of Paul the Apostle to the Corinthians" },
            { "Gal", "The Epistle of Paul the Apostle to the Galatians" },
            { "Eph", "The Epistle of Paul the Apostle to the Ephesians" },
            { "Phi", "The Epistle of Paul the Apostle to the Philippians" },
            { "Col", "The Epistle of Paul the Apostle to the Colossians" },
            { "1Th", "The First Epistle of Paul the Apostle to the Thessalonians" },
            { "2Th", "The Second Epistle of Paul the Apostle to the Thessalonians" },
            { "1Tim", "The First Epistle of Paul the Apostle to Timothy" },
            { "2Tim", "The Second Epistle of Paul the Apostle to Timothy" },
            { "Titus", "The Epistle of Paul the Apostle to Titus" },
            { "Phmn", "The Epistle of Paul the Apostle to Philemon" },
            { "Heb", "The Epistle of Paul the Apostle to the Hebrews" },
            { "Jas", "The Epistle of James" },
            { "1Pet", "The First Epistle of Peter" },
            { "2Pet", "The Second Epistle of Peter" },
            { "1Jn", "The First Epistle of John" },
            { "2Jn", "The Second Epistle of John" },
            { "3Jn", "The Third Epistle of John" },
            { "Jude", "The Epistle of Jude" },
            { "Rev", "The Revelation St. John" }
        };
    }
}

