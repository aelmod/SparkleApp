﻿using System;
using System.Windows.Forms;
using SparkleApp;

namespace p2p_client
{
    internal static class Program
    {
        /// <summary>
        ///     Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
            Application.EnableVisualStyles();
        }
    }
}