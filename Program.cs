using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Author:          Connor Stanford
 * CLID:            cxs0290
 * Class:           CMPS 358
 * Assignment:      project #1
 * Due Date:        Tuesday, 13 October 2015, 11:55 PM
 * Description:     A calculator program with a GUI that also accepts user input from the keyboard and numberpad. 
 */

namespace p1_cxs0290
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
            Application.Run(new Calculator());
        }
    }
}
