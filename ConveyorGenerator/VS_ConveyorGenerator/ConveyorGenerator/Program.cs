using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConveyorGenerator
{
     static class Program
     {
          /// <summary>
          /// The main entry point for the application.
          /// </summary>
          [STAThread]
          static void Main()
          {
               AssemblyResolver.versionShort = "19.0";
               AssemblyResolver.versionLong = "19.0.0.0";
            
               ////AssemblyResolver.AddResolver();
               Application.EnableVisualStyles();
               Application.SetCompatibleTextRenderingDefault(false);
               Application.Run(new MainForm());
          }
     }
}
