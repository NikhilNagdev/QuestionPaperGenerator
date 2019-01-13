using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace QuestionPaperGenerator
{
    class Chapter
    {
        /*---------------------------------------------------------------------------------------------------
                                                CONSTRUCTOR
        ---------------------------------------------------------------------------------------------------*/

        /// <summary>
        /// This constructor simply gets connection to the database and intializes objects.
        /// </summary>
        public Chapter()
        {
            databaseConnection = MyDatabaseConnector.GetDatabaseConnection();
            chapterWeightages = new Dictionary<int, int>();
            random = new Random();
        }

        /*---------------------------------------------------------------------------------------------------
                                                METHODS
        ---------------------------------------------------------------------------------------------------*/


        /// <summary>
        ///     This method fetches a random chapter number from the database table.
        /// </summary>
        /// <returns>
        ///     It returns the random chapter number.
        /// </returns>
        public int GetRandomChapter()
        {
            int no = random.Next(1, 7);
            String query = "SELECT chapterNo FROM javaChapters where chapterId = " + no;
            MySqlCommand command = new MySqlCommand(query, databaseConnection);
            MySqlDataReader reader = command.ExecuteReader();
            int chapter = 0;
            if (reader.HasRows)
            {
                reader.Read();
                chapter = reader.GetInt32(0);
                reader.Close();
            }
            return chapter;
        }

        /// <summary>
        ///     This method fetches all the chapter numbers randomly from the database table.
        /// </summary>
        /// <returns>
        ///     It returns List object in which all the chapter numbers are there which are 
        ///     generated randomly.
        /// </returns>
        public List<int> GetRandomChapters()
        {
            List<int> chapters = new List<int>();
            int chapterNo = -1;
            while (chapters.Count < 6)
            {
                chapterNo = GetRandomChapter();
                while (!chapters.Contains(chapterNo))
                {
                    chapters.Add(chapterNo);
                }
            }
            return chapters;
        }

        /// <summary>
        ///     This method fetches the weightage of the chapter according to the chapter number.
        /// </summary>
        /// <param name="chapterNo">
        ///     Chapter number for which the weightage has to be returned.
        /// </param>
        /// <returns>
        ///     This method returns a int of chapter weightage.
        /// </returns>
        public int GetChapterWeightage(int chapterNo)
        {
            String query = "SELECT weightage FROM javaChapters where chapterNo = " + chapterNo;
            MySqlCommand command = new MySqlCommand(query, databaseConnection);
            MySqlDataReader reader = null;
            reader = command.ExecuteReader();
            int weightage=0;
            if (reader.HasRows)
            {
                reader.Read();
                weightage = reader.GetInt32(0);
                reader.Close();
            }
            return weightage;
        }

        /// <summary>
        ///     This method fetches the weightage of all the chapters from the table in the database.
        /// </summary>
        /// <returns>
        ///     This method returns a Dictionary of all chapter weightages.
        /// </returns>
        public Dictionary<int, int> getAllChapterWeightages()
        {
            String query = "SELECT chapterNo,wightage FROM javaweightage";
            MySqlCommand command = new MySqlCommand(query, databaseConnection);
            MySqlDataReader reader = null;
            
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    chapterWeightages.Add(reader.GetInt32(0), reader.GetInt32(1));
                }
                reader.Close();
            }
            return chapterWeightages;
        }


        //Variable declarations
        private MySqlConnection databaseConnection = null;
        private Dictionary<int, int> chapterWeightages = null;
        private Random random;
        //End of variable declarations
    }
}
