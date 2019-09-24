using System;
using System.Collections.Generic;
using System.Data.OleDb;
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

namespace AccessDb
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public OleDbConnection cn;
        public MainWindow()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\vinomano\\Desktop\\Database11.accdb";
            InitializeComponent();
            cn = new OleDbConnection( connectionString );
        }

        private void See_Assets_Click(object sender, RoutedEventArgs e)
        {
            string query = "select * from Assets";

            OleDbCommand cmd = new OleDbCommand(query, cn);

            cn.Open();

            OleDbDataReader read = cmd.ExecuteReader();

            string data = "";

            while (read.Read())
            {
                data += read[2].ToString() + "\n";

                TextArea.Text = data;
            }

            cn.Close();
        }

        private void TextArea_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void See_Employees_Click(object sender, RoutedEventArgs e)
        {

            string query = "select * from Employees";

            OleDbCommand cmd = new OleDbCommand(query, cn);

            cn.Open();

            OleDbDataReader read = cmd.ExecuteReader();

            string data = "";

            while (read.Read())
            {
                data += read[1].ToString() + "\n";

                Employees.Text = data;
            }

            cn.Close();
        }

        private void Employees_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void AddEmployee_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void FirstName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void LastName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
