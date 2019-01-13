using System;
using System.Collections.Generic;

namespace QuestionPaperGenerator
{
    class GenerateQuestions
    {
        /*---------------------------------------------------------------------------------------------------
                                                CONSTRUCTOR
        ---------------------------------------------------------------------------------------------------*/
        GenerateQuestions()
        {
            chapter = new Chapter();
            chapters = new List<int>();
            questionFetcher = new QuestionFetcher();
            questions = new List<string>();
            random = new Random();
        }


        static void Main()
        {
            GenerateQuestions gq = new GenerateQuestions();
            //gq.GenerateEightMarksQuestions();
            //gq.GenerateSixMarksQuestions();
            //gq.GenerateFourMarksQuestions();
            Console.WriteLine("----------------------------------------------");
            gq.GenerateRandomQuestions(8, 4);
            Console.WriteLine("----------------------------------------------");
            gq.GenerateRandomQuestions(6, 2);
            Console.WriteLine("----------------------------------------------");
            gq.GenerateRandomQuestions(4, 14);
            Console.Read();
        }

        /*---------------------------------------------------------------------------------------------------
                                                METHODS
        ---------------------------------------------------------------------------------------------------*/
        public void GenerateEightMarksQuestions()
        {
            chapters = chapter.GetRandomChapters();
            List<String> questions = new List<String>();
            int i = 0;
            while (i < 6)
            {
                chapterNo = chapters[i++];
                questions.Add(questionFetcher.GetRandomQuestion(chapterNo, 8));
            }

            i = 0;
            while (i < questions.Count)
            {
                //Console.WriteLine(questions[(int)Math.Round(random.NextDouble() * questions.Count-1)]);
                Console.WriteLine(questions[i]);
                i++;
            }
        }

        public void GenerateSixMarksQuestions()
        {
            chapters = chapter.GetRandomChapters();
            List<String> questions = new List<string>();
            int i = 0;
            while (i < 6)
            {
                chapterNo = chapters[i++];
                //questions.AddRange(questionFetcher.GetQuestions(6, chapterNo));
            }

            i = 0;
            while (i < 2)
            {
                Console.WriteLine(questions[random.Next(0, questions.Count)]);
                i++;
            }
        }

        public void GenerateFourMarksQuestions()
        {
            chapters = chapter.GetRandomChapters();
            List<String> questions = new List<string>();
            int i = 0;
            while (i < 6)
            {
                chapterNo = chapters[i++];
                //questions.AddRange(questionFetcher.GetQuestions(4, chapterNo));
            }

            i = 0;
            while (i < 14)
            {
                Console.WriteLine(questions[random.Next(0, questions.Count)]);
                i++;
            }
        }

        public void GenerateRandomQuestions(int marks, int noOfQuestions)
        {
            chapters = chapter.GetRandomChapters();
            List<String> questions = new List<string>();
            int i = 0;
            while (noOfQuestions!=0)
            {
                chapterNo = chapters[i++];
                Console.WriteLine("Chapter no: " + chapterNo);
                questions.Add(questionFetcher.GetRandomQuestion(chapterNo, marks));
                noOfQuestions--;
                if (i==6)
                {
                    i = 0;
                }
            }

            i = 0;
            while (i < questions.Count)
            {
                //Console.WriteLine(questions[random.Next(0,questions.Count+1)]);
                Console.WriteLine(questions[i]);
                i++;
            }
        }

        //Variable declarations
        private int chapterNo=0;
        private int chapterWeightage;
        private Chapter chapter;
        private List<int> chapters;
        private QuestionFetcher questionFetcher;
        private List<String> questions;
        private Random random;
        //End of variable declarations
    }
}
