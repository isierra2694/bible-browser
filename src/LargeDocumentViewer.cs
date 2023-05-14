using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibleBrowser
{
    public class LargeDocumentViewer : VirtualizingPanel
    {
        private string[] data;
        
        public LargeDocumentViewer(string[] lines)
        {
            this.data = lines;
        }
    }
}
