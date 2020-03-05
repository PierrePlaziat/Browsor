using Browsor.Motor;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Browsor.Pages
{

    public partial class FileBrowsor : Page
    {
        Grid grid;
        List<FileLister> fileListers = new List<FileLister>();

        public FileBrowsor()
        {
            GenerateGrid();
            InitializeComponent();
            this.AddVisualChild(grid);
        }

        void InitializeGrid()
        {
            grid = new Grid();
            grid.Width = 800;
            grid.Height = 800;
            grid.Margin = new Thickness(5);
            grid.HorizontalAlignment = HorizontalAlignment.Left;
            grid.VerticalAlignment = VerticalAlignment.Top;
            grid.ShowGridLines = true;
            grid.Background = new SolidColorBrush(Colors.Red);// Create Columns
            // columns
            ColumnDefinition gridCol1 = new ColumnDefinition();
            ColumnDefinition gridCol2 = new ColumnDefinition();
            grid.ColumnDefinitions.Add(gridCol1);
            grid.ColumnDefinitions.Add(gridCol2);
            // rows
            RowDefinition gridRow1 = new RowDefinition();
            gridRow1.Height = new GridLength(800);
            grid.RowDefinitions.Add(gridRow1);
            //// Add
            //fileListers.Add(new FileLister(@"c:\"));
            //fileListers.Add(new FileLister(@"c:\Windows"));
        }

        void GenerateGrid()
        {
            InitializeGrid();
            foreach (var fileLister in fileListers)
            {
                Grid.SetRow(fileLister, 0);
                Grid.SetColumn(fileLister, 1);
                grid.Children.Add(fileLister);
            }
        }



    }

}
