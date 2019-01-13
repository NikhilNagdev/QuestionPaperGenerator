using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace QuestionPaperGenerator
{
    public partial class Demo : Form
    {
        public Demo()
        {
            InitializeComponent();
            InitializeDatabase();
        }
        
        private void InitializeDatabase()
        {
            String connectionString = "datasource=127.0.0.1;username=nikhil;password=Nikhil@1212;database=qpgenerator;SslMode=none";
            databaseConnection = GetDatabaseConnection(connectionString);
            try
            {
                databaseConnection.Open();
                MessageBox.Show("Database is open");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private MySqlConnection GetDatabaseConnection(string connectionString)
        {
            try
            {
                return new MySqlConnection(connectionString);
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception: " + e);
                throw e;
            }
        }
        
        private MySqlConnection databaseConnection = null;
        private MySqlDataReader reader = null;

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Buton clicked");
            String query = "INSERT INTO javaquestions(qId, chapterNo, question, marks, priority) VALUES (@val0,@val1,@val2,@val3,@val4)";
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            try
            {
                commandDatabase.Parameters.AddWithValue("@val0", tbId.Text);
                commandDatabase.Parameters.AddWithValue("@val1", tbChapterNo.Text);
                commandDatabase.Parameters.AddWithValue("@val2", tbQuestion.Text);
                commandDatabase.Parameters.AddWithValue("@val3", tbMarks.Text);
                commandDatabase.Parameters.AddWithValue("@val4", tbPriority.Text);
                commandDatabase.Prepare();
                reader = commandDatabase.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
            finally
            {
                reader.Close();
            }
            int i = 1;
        }
    }
}
