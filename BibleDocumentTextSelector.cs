using System;
using System.Windows;
using System.Windows.Controls;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibleBrowser
{
    public class BibleDocumentTemplateSelector : DataTemplateSelector
    {
        public DataTemplate VerseTemplate { get; set; }
        public DataTemplate ChapterTitleTemplate { get; set; }
        public DataTemplate BookTitleTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item is Verse)
            {
                return VerseTemplate;
            }
            else if (item is ChapterTitle)
            {
                return ChapterTitleTemplate;
            }
            else if (item is BookTitle)
            {
                return BookTitleTemplate;
            }

            return base.SelectTemplate(item, container);
        }
    }
}
