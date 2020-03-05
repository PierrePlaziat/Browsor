using Browsor.Motor;
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

namespace Browsor
{
    /// <summary>
    /// Logique d'interaction pour Files.xaml
    /// </summary>
    public partial class Files : Page
    {
        List<FileLister> listers = new List<FileLister>();

        public Files()
        {
            InitializeComponent();
            listers.Add(new FileLister(List0, "C:\\"));
            listers.Add(new FileLister(List1, "C:\\"));
            listers.Add(new FileLister(List2, "C:\\"));
            listers.Add(new FileLister(List3, "C:\\"));
        }

        private void List_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox listbox = (ListBox)sender;
            if (listbox.SelectedIndex == -1) return;
            int number = Int32.Parse(listbox.Name[listbox.Name.Count() - 1] + "");
            listChanges(number + 1, listbox.SelectedItem as string);

        }

        private void listChanges(int listbase, string path)
        {
            Console.WriteLine(listbase + " " + path);
            listers[listbase].Path = path;
        }

    }
}
