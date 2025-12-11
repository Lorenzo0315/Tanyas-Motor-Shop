using System;
using System.Windows.Forms;
using Tanyas_Motor_Shop.Forms;

namespace Tanyas_Motor_Shop
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new LogInForm());
        }
    }
}