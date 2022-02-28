using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA220228
{
    internal static class Program
    {
        internal static string ConnectionString => @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dolgozat;Integrated Security=True;";

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }
    }
}
