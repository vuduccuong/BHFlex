﻿using IT_Management.UI;
using System;
using System.Windows.Forms;
using IT_Management.UI.ADD_DATA;
using IT_Management.UI.FormTypeDevices;

namespace IT_Management
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new fmStart());
        }
    }
}