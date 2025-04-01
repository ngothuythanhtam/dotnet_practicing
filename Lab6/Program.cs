using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab6.prjCanBo;
using Lab6.prjDVD;
using Lab6.ThanhToan;

namespace Lab6
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

            //Application.Run(new frmDVDCatalog());
            //Application.Run(new frmThongTinCanBo());
            Application.Run(new frmThanhToan());

        }
    }
}
