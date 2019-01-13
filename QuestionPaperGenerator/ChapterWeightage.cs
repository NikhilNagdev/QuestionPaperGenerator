using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuestionPaperGenerator
{
    class ChapterWeightage
    {
        //Constructor
        ChapterWeightage()
        {
            databaseConnection = MyDatabaseConnector.GetDatabaseConnection();
            chapterWeightages = new List<int>();
        }

        public int getChapterWeightage(int chapterNo)
        {
            String query = "SELECT wightage FROM javaweightage where chapterNo = " + chapterNo;
            MySqlCommand command = new MySqlCommand(query, databaseConnection);
            MySqlDataReader reader = null;
            try
            {
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        return(reader.GetInt32(0));
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception: " + e);
            }
            return 0;
        }

        public List<int> getAllChapterWeightages()
        {
            String query = "SELECT wightage FROM javaweightage";
            MySqlCommand command = new MySqlCommand(query, databaseConnection);
            MySqlDataReader reader = null;
            try
            {
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        chapterWeightages.Add(reader.GetInt32(0));
                    }
                }
                return chapterWeightages;
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception: " + e);
            }
            return null;
        }

        //Variable declarations
        private MySqlConnection databaseConnection = null;
        private List<int> chapterWeightages = null;
        //End of variable declarations
    }
}
