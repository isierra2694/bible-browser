using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BibleBrowser
{
    /// <summary>
    /// Interaction logic for BibleBrowserMain.xaml
    /// </summary>
    public partial class BibleBrowserMain : Window
    {
        private List<string> bible = new List<string>();

        public BibleBrowserMain()
        {
            InitializeComponent();

            DisplayBible();
        }

        private void DisplayBible()
        {
            VirtualizingPanel.SetIsVirtualizing(BibleDocument, true);
            LoadBibleFile();
        }

        private async void LoadBibleFile()
        {
            try
            {
                var reader = new StreamReader(@"c:\users\isier\downloads\bible.txt");
                string line;
                while ((line = await reader.ReadLineAsync()) != null)
                {
                    BibleDocument.Items.Add(line);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
