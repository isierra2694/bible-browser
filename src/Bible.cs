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

        }

        /// <summary>
        /// Loads a new Bible file.
        /// </summary>
        /// <param name="filePath">Bible path</param>
        /// <param name="listBox">ListBox to append verses to</param>
        /// <exception cref="NullReferenceException"></exception>
        public async void Load(string filePath, FlowDocumentScrollViewer documentViewer)
        {
            if (!File.Exists(filePath)) throw new NullReferenceException();

            try
            {
                var reader = new StreamReader(filePath);
                string line;
                FlowDocument bibleDocument = new FlowDocument();

                while ((line = await reader.ReadLineAsync()) != null)
                {
                    string verse = FormatVerseString(line);
                    Paragraph paragraph = new Paragraph();
                    paragraph.Inlines.Add(verse);

                    bibleDocument.Blocks.Add(paragraph);
                }

                documentViewer.Document = bibleDocument;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        private string FormatVerseString(string verse)
        {
            string pattern = @"^(\d*[A-Za-z]+)(\d+):(\d+)\s+(.*)$";
            Match match = Regex.Match(verse, pattern);
            if (match.Success)
            {
                return bibleBooks[match.Groups[1].Value] + " " + match.Groups[2].Value + ":" + match.Groups[3].Value + " " + match.Groups[4].Value;
            }
            else return "Holy Bible, King James Version.";
        }

        private ArrayList verses = new ArrayList();
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
    }
}

