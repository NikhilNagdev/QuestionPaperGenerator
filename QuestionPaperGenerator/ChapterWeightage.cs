using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuestionPaperGenerator
{
    public class ChapterWeightage
    {
        //Constructor
        public ChapterWeightage()
        {
            databaseConnection = MyDatabaseConnector.GetDatabaseConnection();
            chapterWeightages = new List<int>();
        }

        //Methods
        public int getChapterWeightage(int chapterNo)
        {
            String query = "SELECT weightage FROM javachapters where chapterNo = " + chapterNo;
            MySqlCommand command = new MySqlCommand(query, databaseConnection);
            MySqlDataReader reader = null;
            try
            {
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        return (reader.GetInt32(0));
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception: " + e);
            }
            return 0;
        }

        //public List<int> getAllChapterWeightages()
        //{
        //    String query = "SELECT weightage FROM javachapters";
        //    MySqlCommand command = new MySqlCommand(query, databaseConnection);
        //    MySqlDataReader reader = null;
        //    try
        //    {
        //        reader = command.ExecuteReader();
        //        if (reader.HasRows)
        //        {
        //            while (reader.Read())
        //            {
        //                chapterWeightages.Add(reader.GetInt32(0));
        //            }
        //        }
        //        return chapterWeightages;
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show("Exception: " + e);
        //    }
        //    return null;
        //}

        public Dictionary<int, int> getAllChapterWeightages(List<int> chapters)
        {
            Dictionary<int, int> chapterWeightages = new Dictionary<int, int>();
            MySqlDataReader reader = null;
            for (int i = 0; i < chapters.Count; i++)
            {
                String query = "SELECT * FROM javachapters where chapterNo = " + chapters[i];
                MySqlCommand command = new MySqlCommand(query, databaseConnection);
                try
                {
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            chapterWeightages.Add(reader.GetInt32(1), reader.GetInt32(2));
                            //Console.WriteLine(i + "      " +reader.GetInt32(1) + "     "  +  reader.GetInt32(2));
                        }
                    }
                    reader.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Exception: " + e);
                }
            }

            return chapterWeightages;
        }


        //Variable declarations
        private MySqlConnection databaseConnection = null;
        private List<int> chapterWeightages = null;
        //End of variable declarations

    }
}
