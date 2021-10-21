using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
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

namespace MyBookApp
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
        public  void FirstBook()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                //var data= cnn.Execute("SELECT * FROM Book ORDER BY ROWID ASC LIMIT 1").ToString();
                var output = cnn.Query<Book>("SELECT * FROM Book ORDER BY ROWID ASC LIMIT 1");
                var de = output.ToArray();

                var da = de.AsQueryable().First();
                titleText.Text = da.Title;
                authorText.Text = da.Author;
                priceText.Text = da.Price.ToString();
            }

        }
        public void LastBook()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                //var data= cnn.Execute("SELECT * FROM Book ORDER BY ROWID ASC LIMIT 1").ToString();
                var output = cnn.Query<Book>("SELECT * FROM Book ORDER BY ROWID DESC LIMIT 1");
                var de = output.ToArray();

                var da = de.AsQueryable().First();
                titleText.Text = da.Title;
                authorText.Text = da.Author;
                priceText.Text = da.Price.ToString();
            }

        }


        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
        public void New()
        {

            titleText.Text = "";
            authorText.Text = "";
            priceText.Text = "";

        }
        public void Save()
        {
            Book bk = new Book();
            bk.Title = titleText.Text;
            bk.Author = authorText.Text;
            bk.Price = int.Parse(priceText.Text);

            SqliteDataAccess.SaveBook(bk);

            titleText.Text = "";
            authorText.Text = "";
            priceText.Text = "";

        }
        public void Delete()
        {

            Book bk = new Book();
            bk.Title = titleText.Text;

            SqliteDataAccess.DeleteBook(bk);
            titleText.Text = "";
        }
         public void Next()
        {

            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {

                Book bk = new Book();
                bk.Title = titleText.Text;
                var title = bk.Title;
                var output = cnn.Execute("SELECT Id FROM Book where Title=@Title");
                var de = output + 4;
                var output1 = cnn.Query<Book>("SELECT * FROM Book WHERE Id =" + de);
                var re = output1.ToArray();
                var da = re.AsQueryable().First();
                titleText.Text = da.Title;
                authorText.Text = da.Author;
                priceText.Text = da.Price.ToString();
            }

        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            New();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Save();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Delete();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            FirstBook();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            LastBook();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Next();
        }
    }
}