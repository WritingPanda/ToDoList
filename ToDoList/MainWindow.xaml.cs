using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
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

namespace ToDoList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        void Button_Click(object sender, RoutedEventArgs e)
        {
            if (this.typeName.Text == "")
            {
                this.result.Text = "Nothing was added. Please enter your name above.";
            }
            else if (this.typeName.Text == "Thomas")
            {
                this.result.Text = "Enjoy Austin, " + this.typeName.Text + "... Whatever.";
            }
            else
            {
                this.result.Text = "Hello, " + this.typeName.Text + "! Hope you are having a wonderful day!";
            }

            try
            {
                File.OpenRead("NonExistentFile");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.WriteLine("Finally has been reached.");
            }
        }

        void OpenFilesMenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        void OpenDirMenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        void ClearInputMenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.typeName.Text = "";
        }

        void ExitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        void CopyMenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        void PasteMenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.typeName.Text = Clipboard.GetText();
        }

        private static readonly Random rnd = new Random();

        void SurpriseClick(object sender, RoutedEventArgs e)
        {
            string[] names = new string[6] { "Paul", "Omar", "David", "Casey", "Kevin", "Thomas" };
            int arrayNum = rnd.Next(names.Length);
            this.typeName.Text = names[arrayNum];
            this.Button_Click(sender, e);
        }

    }
}
