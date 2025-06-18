using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
<<<<<<< HEAD
=======
using System.Windows.Forms;

>>>>>>> 636cc60a0e45fddf1ace4a8d21f183a159c1fe24
using System.Threading.Tasks;

namespace Mihaela_11a_14
{
<<<<<<< HEAD
    public class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
=======
    public static class Program
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
    }
}
>>>>>>> 636cc60a0e45fddf1ace4a8d21f183a159c1fe24
