﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WinForm1());
        }
    }
}

namespace NS_Bonjour
{
    class CL_Bonjour
    {
         public string m_bonjour()
         {
             return "Bonjour !!";
         }
    }
}