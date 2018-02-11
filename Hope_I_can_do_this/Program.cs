using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hope_I_can_do_this
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
            Application.Run(new Form1());
        }
        /*static string TextChange(string someText, int randomIntOrig, int randomIntNew)
        {
            int charCodeOrig = randomIntOrig + 224;
            int charCodeNew = randomIntNew + 224;
            string workingString = someText.Replace('Ё', 'Е');
            workingString = someText.Replace('ё', 'е');
            string changedText = workingString.Replace(Convert.ToChar(charCodeOrig), Convert.ToChar(charCodeNew));
            charCodeOrig = randomIntOrig + 192;
            charCodeNew = randomIntNew + 192;
            changedText = workingString.Replace(Convert.ToChar(charCodeOrig), Convert.ToChar(charCodeNew));
            return changedText;
        }*/
    }
}
