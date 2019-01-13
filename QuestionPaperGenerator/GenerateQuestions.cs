using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionPaperGenerator
{
    class GenerateQuestions
    {
        GenerateQuestions()
        {
            chapter = new Chapter();
        }

        static void Main()
        {
            Console.WriteLine("NO: " + chapterNo + "   " + chapterWeightage);
            chapterNo = chapter.GetRandomChapter();
            chapterWeightage = chapter.GetChapterWeightage(chapterNo);
            Console.WriteLine("NO: " + chapterNo + "   " + chapterWeightage);
            Console.Read();
        }
        
        //Variable declarations
        private int chapterNo;
        private int chapterWeightage;
        private Chapter chapter;
        //End of variable declarations
    }

}
