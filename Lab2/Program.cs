using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab2.Ex2;
using Lab2.Ex3;

namespace Lab2
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

            //Bai 1
            //Application.Run(new Form_student_details());

            //Bai 2
            //Application.Run(new Login());

            //Bai 3
            Application.Run(new FlightReservationDetailscs());
        }
    }
}
