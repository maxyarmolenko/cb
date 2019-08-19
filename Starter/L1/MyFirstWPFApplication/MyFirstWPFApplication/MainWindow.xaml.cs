using System.Windows;
using System.Windows.Controls;

namespace MyFirstWPFApplication
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
          
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            private void button_Click(object sender, System.EventArgs e)
            {
                TextBox1 myText = new TextBox2();
                myText.Location = new Point(25, 25);
                this.Controls.Add(myText);
            }
        }
    }
}
