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

namespace PaintWPS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public object tool { get; private set; }
        public Point startpoint { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
            tool = Tool.Pencil;
        }
            enum Tool
        {
            Pencil,
            Eraser,
            Fill,
            Text
        }

        private void btnPencil_Click(object sender, RoutedEventArgs e)
        {
            // Set the tool to pencil
            tool = Tool.Pencil;
        }

        private void btnEraser_Click(object sender, RoutedEventArgs e)
        {
            // Set the tool to eraser
            tool = Tool.Eraser;
        }

        private void btnFill_Click(object sender, RoutedEventArgs e)
        {
            // Set the tool to fill
            tool = Tool.Fill;
        }

        private void btnText_Click(object sender, RoutedEventArgs e)
        {
            // Set the tool to text
            tool = Tool.Text;
        }

        private void canvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // Store the current mouse position
            startpoint = e.GetPosition(canvas);
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {




        }

    }
