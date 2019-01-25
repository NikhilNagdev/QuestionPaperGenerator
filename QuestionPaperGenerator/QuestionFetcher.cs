using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace QuestionPaperGenerator
{
    class QuestionFetcher
    {
        /*---------------------------------------------------------------------------------------------------
                                                CONSTRUCTOR
        ---------------------------------------------------------------------------------------------------*/
        /// <summary>
        /// This constructor simply gets connection to the database and intializes objects.
        /// </summary>
        public QuestionFetcher()
        {
            databaseConnection = MyDatabaseConnector.GetDatabaseConnection();
            random = new Random();
            chapterWeightage = new ChapterWeightage();
        }

        /*---------------------------------------------------------------------------------------------------
                                                METHODS
        ---------------------------------------------------------------------------------------------------*/

        /// <summary>
        /// This method is used to fetch the questions according to the marks
        /// and chapter number from table in the database.
        /// </summary>
        /// 
        /// <param name="marks">
        ///     marks for the questions for which data has to be fetched from the database.
        /// </param>
        /// 
        /// <param name="chapterNo">
        ///     chapter number for which the question has to be fetched from the database.
        /// </param>
        /// <returns>
        ///     This method returns a List object in which questions are there according to the 
        ///     marks and chapter number.
        /// </returns>
        //SELECT qid FROM javaquestions WHERE qId = (SELECT MAX(qId) FROM javaquestions WHERE chapterNo = 2
        public List<String> GetQuestions(int marks, int chapterNo, int noOfQuestions)
        {
            int i = 0;
            HashSet<String> hashSet = new HashSet<String>();
            List<String> list = new List<string>();
            MySqlCommand command;
            while (i<noOfQuestions)
            {
                i++;
                int id = random.Next(GetFirstQuestionId(chapterNo, marks), GetLastQuestionId(chapterNo, marks));
                Console.WriteLine(GetFirstQuestionId(chapterNo,marks) + "     " + GetLastQuestionId(chapterNo, marks));
                Console.WriteLine(id);
                //SELECT `question` FROM `javaquestions` WHERE chapterNo = 2 AND qId = 18 AND marks = 4
                String query = "SELECT `question` FROM `javaquestions` WHERE chapterNo = " + chapterNo + " AND qId = " + id + " AND marks = " + marks;
                Console.WriteLine(query);
                command = new MySqlCommand(query, databaseConnection);
                MySqlDataReader dataReader = command.ExecuteReader();
                Console.WriteLine(dataReader.HasRows);
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        hashSet.Add(dataReader.GetString(0));
                    }
                    list = new List<string>(hashSet);
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
                dataReader.Close();
                foreach(String s in list){
                    Console.WriteLine(s);
                }
            }
            return list;
        }

        //(int) Math.Round(random.NextDouble() * questions.Count-1)])
        public String GetRandomQuestion(int chapterNo, int marks)
        {
            int id = random.Next(GetFirstQuestionId(chapterNo, marks), GetLastQuestionId(chapterNo, marks)+1);
            int id1 = GetFirstQuestionId(chapterNo, marks) + (int)Math.Round(random.NextDouble() * (GetLastQuestionId(chapterNo, marks)- GetFirstQuestionId(chapterNo, marks)));
            Console.WriteLine(GetFirstQuestionId(chapterNo, marks) + "     " + (GetLastQuestionId(chapterNo, marks)+1) + "     " + id);
            String query = "SELECT `question` FROM `javaquestions` WHERE chapterNo = " + chapterNo + " AND qId = " + id + " AND marks = " + marks;
            MySqlDataReader dataReader = new MySqlCommand(query, databaseConnection).ExecuteReader();
            try
            {
                String str = "";
                if (dataReader.Read())
                {
                    str =  dataReader.GetString(0);
                }
                return str;
            }
            finally
            {
                dataReader.Close();
            }
        }

        public int GetFirstQuestionId(int chapterNo, int marks)
        {
            String query = "SELECT qId FROM javaquestions WHERE chapterNo = "+  chapterNo + " AND marks = " + marks + " LIMIT 1";
            Console.WriteLine(query);
            MySqlDataReader reader = new MySqlCommand(query, databaseConnection).ExecuteReader();
            int id = -1;
            if (reader.Read())
            {
                id = reader.GetInt32(0);
            }
            reader.Close();
            return id;
        }

        public int GetLastQuestionId(int chapterNo, int marks)
        {
            String query = "SELECT qid FROM javaquestions WHERE chapterNo = " + chapterNo + " AND marks = " + marks ;
            Console.WriteLine(query);
            MySqlDataReader reader = new MySqlCommand(query, databaseConnection).ExecuteReader();
            reader.Read();
            int id = -1;
            if (reader.Read())
            {
                id = reader.GetInt32(0);
            }
            reader.Close();
            return id;
        }

        static void Main()
        {
            Console.WriteLine(new QuestionFetcher().GetRandomQuestion(2, 6));
            Console.Read();
        }

        //Variable declarations
        private MySqlConnection databaseConnection = null;
        private Random random;
        private ChapterWeightage chapterWeightage = null;
        //End of variable declarations
    }
}
