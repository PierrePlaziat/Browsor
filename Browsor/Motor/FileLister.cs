using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Controls;

namespace Browsor.Motor
{

    class FileLister : ListBox
    {

        private string path;
        public string Path
        {
            get
            {
                return path;
            }
            set
            {
                string previousPath = path;
                path = value;
                try
                {
                    files = Directory.GetFileSystemEntries(Path).ToList<string>();
                    names = new List<string>();
                    foreach (var file in files)
                    {
                        names.Add(file.Split('\\').Last());
                    }
                }
                catch
                {
                    path = previousPath;
                }
                box.ItemsSource = files;
            }
        }

        public List<String> files;
        private List<String> names;

        ListBox box;

        // CTOR
        public FileLister(ListBox box, string path)
        {
            this.box = box;
            Path = path;
        }


    }

    /*internal class FileObject
    {
        public string fileName;
        public int fileSize;
        public string fileType;
        public DateTime dateModified;
        public DateTime dateCreated;
        public List<FileTag> tags;
    }*/

}
