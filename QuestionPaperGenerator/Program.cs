using System;
using System.Windows.Forms;

namespace QuestionPaperGenerator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.Run(new Demo());
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception in main: " + e);
            }
            
        }
    }
}
