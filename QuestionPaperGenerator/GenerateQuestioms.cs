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
            chapterWeightage = new Dictionary<int, int>();
        }


        static void Main()
        {
            GenerateQuestions gq = new GenerateQuestions();
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
            for (int k = 0; k < chapters.Count; k++)
            {
                Console.WriteLine(chapters[k]);
            }
            chapterWeightage = weightage.getAllChapterWeightages(chapters);
            for (int k = 1; k < chapters.Count + 1; k++)
            {
                Console.WriteLine(chapterWeightage[k]);
            }
            List<String> questions = new List<string>();
            int chapterNo = chapters[0], i = 0;
            while (totalMarks != 0)
            {
                Console.WriteLine("Chapter no: " + chapterNo + "Chapter weightage: " + chapterWeightage[chapterNo]);
                while (chapterWeightage[chapterNo] != 0)
                {
                    if (chapterWeightage[chapterNo] % 8 != 0 && chapterWeightage[chapterNo] % 4 != 0)
                    {
                        marks = 6;
                    }
                    else if (chapterWeightage[chapterNo] >= 8)
                    {
                        marks = values[random.Next(values.Length)];
                    }
                    else
                    {
                        marks = 4;
                    }
                    questions.Add(questionFetcher.GetRandomQuestion(chapterNo, marks));
                    totalMarks -= marks;
                    Console.WriteLine("Marks remaining: " + totalMarks);
                    Console.WriteLine("Chapter weightage: " + chapterWeightage[chapterNo]);
                    chapterWeightage[chapterNo] -= marks;
                    if (chapterWeightage[chapterNo] < 0)
                        break;
                }
                if (i >= 6)
                {
                    chapterNo = chapters[i = 0];
                }
                chapterNo = chapters[i++];
                if (totalMarks < 0)
                {
                    break;
                }
            }


            /*while(k++ < 10)
            {
                if (i >= 6)
                {
                    i = chapters[0];
                }
                Console.WriteLine("i" + i);
                Console.WriteLine(chapterWeightage[i]);
                if (chapterWeightage[i] != 0)
                {
                    if (chapterWeightage[i] % 8 != 0 && chapterWeightage[i] % 4 != 0)
                    {
                        marks = 6;
                        Console.WriteLine("HELLOOOO" + chapterWeightage[i]);
                        //Console.WriteLine(questionFetcher.GetRandomQuestion(chapters[i], marks));
                        questions.Add(questionFetcher.GetRandomQuestion(chapters[i], marks));
                        chapterWeightage[i] -= marks;
                    }
                    else
                    {
                        marks = values[random.Next(values.Length)];
                        questions.Add(questionFetcher.GetRandomQuestion(chapters[i], marks));
                        chapterWeightage[i] -= marks;
                    }
                    totalMarks -= marks;
                    i++;
                }
            }*/
            //while (noOfQuestions!=0)
            //{
            //    chapterNo = chapters[i++];
            //    Console.WriteLine("Chapter no: " + chapterNo);
            //    chapterWeightage[chapterNo] -= marks;
            //    /*foreach (KeyValuePair<int, int> kvp in chapterWeightage)
            //    {
            //        Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            //    }*/
            //    if (chapterWeightage[chapterNo] <= 2)
            //    {
            //        chapters.Remove(i);
            //        Console.WriteLine("BREAK: "  + chapterWeightage[chapterNo]);
            //        //break;
            //    }

            //    Console.WriteLine("Chapter no: " + chapterNo);
            //    questions.Add(questionFetcher.GetRandomQuestion(chapterNo, marks)); 
            //    noOfQuestions--;
            //    if (i==6)
            //    {
            //        i = 0;
            //    }
            //}
            i = 0;
            while (i < questions.Count)
            {
                Console.WriteLine(questions[i]);
                i++;
            }
        }

        //Variable declarations
        private int chapterNo = 0;
        private Chapter chapter;
        private List<int> chapters;
        private QuestionFetcher questionFetcher;
        private List<String> questions;
        private Random random;
        private Dictionary<int, int> chapterWeightage = null;
        private ChapterWeightage weightage = new ChapterWeightage();
        int totalMarks = 100;
        int[] values = { 4, 8 };
        //End of variable declarations
    }
}