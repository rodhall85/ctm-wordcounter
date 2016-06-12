namespace RodHall.CTMWordCounter.App {
    using Logic;
    using System;
    using System.Windows.Forms;

    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(
                new WordCounter(
                    new TextFileStreamReader(), 
                    new CTMWordCleanser()));
        }
    }
}
