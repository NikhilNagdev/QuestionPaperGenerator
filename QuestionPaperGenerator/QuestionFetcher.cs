﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;

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
            priorityWithId = new Dictionary<int, int>();
            questions = new List<int>();
            String query = "UPDATE javaquestions SET priority = priority + 1  WHERE priority < 10";
            new MySqlCommand(query, databaseConnection).ExecuteNonQuery();
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
        /*public List<String> GetQuestions(int marks, int chapterNo, int noOfQuestions)
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
        }*/

        //(int) Math.Round(random.NextDouble() * questions.Count-1)])
        public String GetRandomQuestion(int chapterNo, int marks)
        {
            int id = 0;
            //Console.WriteLine(GetFirstQuestionId(chapterNo, marks) + "     " + (GetLastQuestionId(chapterNo, marks) + 1) + "     " + id);
            //id = random.Next(GetFirstQuestionId(chapterNo, marks), GetLastQuestionId(chapterNo, marks)+1);
            //int id1 = GetFirstQuestionId(chapterNo, marks) + (int)Math.Round(random.NextDouble() * (GetLastQuestionId(chapterNo, marks)- GetFirstQuestionId(chapterNo, marks)));
            String query = "SELECT * FROM javaquestions WHERE chapterNo = " + chapterNo + " AND marks = " + marks;
            MySqlDataReader dataReader = new MySqlCommand(query, databaseConnection).ExecuteReader();
            String str = "";
            try
            {
                while (dataReader.Read())
                {
                    Console.WriteLine("QUESTION ID: " + dataReader.GetInt32(0));
                    priorityWithId.Add(dataReader.GetInt32(0), dataReader.GetInt32(4));
                }
            }
            finally
            {
                dataReader.Close();
            }
            /*int i = 1;
            while(i <= 10){
                Console.WriteLine(priorityWithId[i++]);
            }*/
            str = GetQuestion(priorityWithId);
            priorityWithId = new Dictionary<int, int>();
            return str;
        }

        public String GetQuestion(Dictionary<int, int> priorityId)
        {
            List<int> qid = new List<int>();
            foreach (int s in priorityId.Keys)
            {
                qid.Add(s);
                Console.WriteLine("QID: " + s);
            }
            KeyValuePair<int, int> bestMatch = priorityId.OrderBy(e => Math.Abs(e.Value - 10)).FirstOrDefault();
            Console.WriteLine(" best "  + bestMatch);
            int i = 0, id = 0;
            /*while (i < qid.Count)
            {
                if (priorityId[qid[i]] == 10)
                {
                    id = priorityId[qid[i]];
                }
                else if(priorityId[qid[i]] == 9)
                {

                }
                i++;
            }*/
            //int id = qid[random.Next(0, qid.Count)];
            id = bestMatch.Key;
            UpdatePriority(id);
            Console.WriteLine("Id is " + id);
            String query = "SELECT question FROM javaquestions where qid = " + id;
            Console.WriteLine(query);
            MySqlDataReader dataReader = new MySqlCommand(query, databaseConnection).ExecuteReader();
            String str = "";
            if (dataReader.Read())
            {
                str = dataReader.GetString(0);
            }
            dataReader.Close();
            return str;
        }

        /*public int GetFirstQuestionId(int chapterNo, int marks)
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
            String query = "SELECT MAX(qid) FROM javaquestions WHERE chapterNo = " + chapterNo + " AND marks = " + marks;
            //String query = "SELECT MAX(qid) FROM javaquestions WHERE qid = (SELECT MAX(qid) FROM javaquestions WHERE chapterNo = " + chapterNo + " AND marks = " + marks + ")";
            Console.WriteLine(query);
            MySqlDataReader reader = new MySqlCommand(query, databaseConnection).ExecuteReader();
            int id = -1;
            if (reader.Read())
            {
                id = reader.GetInt32(0);
                Console.WriteLine("Id: " + id);
            }
            reader.Close();
            return id;
        }*/

        public void UpdatePriority(int qid)
        {
            String query = "UPDATE javaquestions SET priority = 0 WHERE qid = " + qid ;
            new MySqlCommand(query, databaseConnection).ExecuteNonQuery();
        }
        
        public Dictionary<int, int> GetPriorityWithId(int chapterNo, int marks)
        {
            int priority = 10;
            String query = "SELECT qid FROM javaqestions WHERE priority = " + 10 + "chapterno = " + chapterNo + "marks = " + marks;
            Console.WriteLine(query);
            MySqlDataReader reader = new MySqlCommand(query, databaseConnection).ExecuteReader();
            int id = -1;
            if (reader.Read())
            {
                id = reader.GetInt32(0);
                Console.WriteLine("Id: " + id);
            }
            reader.Close();
            return null;
        }

        static void Main()
        {
            QuestionFetcher qf = new QuestionFetcher();
            qf.GetRandomQuestion(1, 4);
            Console.Read();
        }

        //Variable declarations
        private MySqlConnection databaseConnection = null;
        private Random random;
        private ChapterWeightage chapterWeightage = null;
        private Dictionary<int, int> priorityWithId = null;
        private List<int> questions = null;
        //End of variable declarations
    }
}
