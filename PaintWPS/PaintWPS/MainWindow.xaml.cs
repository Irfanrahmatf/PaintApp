using System.Windows;

namespace PaintWPS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

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
    }
}