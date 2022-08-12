using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ExtensionFixer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool? searchChildFolders = true;

        public MainWindow()
        {
            InitializeComponent();

            PathTextBox.Text = String.Empty;
            SearchChildFolderCheckbox.IsChecked = true;
        }

        private void OpenExplorerDialog_Click(object sender, RoutedEventArgs e)
        {
            using (var dialog = new System.Windows.Forms.FolderBrowserDialog())
            {
                System.Windows.Forms.DialogResult result = dialog.ShowDialog();

                PathTextBox.Text = dialog.SelectedPath;
            }
        }

        private void FixExtensionButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ScanFolderButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SearchChildFolderCheckbox_Changed(object sender, RoutedEventArgs e)
        {
            searchChildFolders = ((CheckBox)sender).IsChecked;
        }
    }
}
