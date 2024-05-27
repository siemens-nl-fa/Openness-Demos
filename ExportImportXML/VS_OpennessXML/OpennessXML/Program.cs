using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpennessLibrary;

namespace OpennessXML
{
     static class Program
     {
          /// <summary>
          /// The main entry point for the application.
          /// </summary>
          [STAThread]
          static void Main()
          {
               /*
               // V15.1
               AssemblyResolver.versionShort = "15.1";
               AssemblyResolver.versionLong = "15.1.0.0";
               //*/

               ///*
               // V18
               AssemblyResolver.versionShort = "19.0";
               AssemblyResolver.versionLong = "19.0.0.0";
               //*/

               AssemblyResolver.AddResolver();

               Application.EnableVisualStyles();
               Application.SetCompatibleTextRenderingDefault(false);
               Application.Run(new MainForm());
          }
     }
}
