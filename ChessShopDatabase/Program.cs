using System;
using System.Windows.Forms;

using ChessShopDatabase.Forms;

namespace ChessShopDatabase
{

    static class Program
    {
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AuthorizationForm());
        }

    }

}