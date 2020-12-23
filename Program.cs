using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    
    public static class MyFunction
    {
        public delegate void InactAdd();
        public static InactAdd InactHandler;

        public delegate void ActAdd();
        public static ActAdd ActHandler;

        public delegate void AddBookHandler(string author, string name, string year);
        public static AddBookHandler AddBookHandl;
    }

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
            Application.Run(new form1());
        }
    }
}
