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

namespace ListOfBooks
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

        private void HandleShowDetails(object sender, RoutedEventArgs e)
        {
            if (Books.SelectedItem == null)
            {
                MessageBox.Show("Please select any of the book");
            }
            if (Books.SelectedItem==book1)
            {
                titleText.Text = book1.Title.ToString();
                authorText.Text = book1.Author.ToString();
                priceText.Text = "₹" + book1.Price.ToString();
            }
            if (Books.SelectedItem == book2)
            {
                titleText.Text = book2.Title.ToString();
                authorText.Text = book2.Author.ToString();
                priceText.Text = "₹" + book2.Price.ToString();
            }
            if (Books.SelectedItem == book3)
            {
                titleText.Text = book3.Title.ToString();
                authorText.Text = book3.Author.ToString();
                priceText.Text = "₹" + book3.Price.ToString();
            }

        }
    }
}
