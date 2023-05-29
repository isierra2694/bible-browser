using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Collections;
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
        Bible bible;

        public BibleBrowserMain()
        {
            InitializeComponent();

            bible = new Bible();

            InitializeBible();
        }

        private async void InitializeBible()
        {
            VirtualizingPanel.SetIsVirtualizing(BibleDocumentViewer, true);

            await bible.Load(@"c:\users\isier\downloads\bible.txt", BibleDocumentViewer);
            LoadLinesIntoSelector();
        }

        private void LoadLinesIntoSelector()
        {
            BibleVersesViewer.ItemsSource = bible.Books;
        }

        private void onLocationClicked(object sender, MouseButtonEventArgs e)
        {
            TreeViewItem item = sender as TreeViewItem;
            BibleDocumentViewer.ScrollIntoView(item.Header);
        }
    }
}
