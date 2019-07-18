using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Cognex.VisionPro;

namespace VisionApplication
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
      Application.Run(new Form1());

      CogFrameGrabbers frameGrabbers = new CogFrameGrabbers();
      for (int i = 0; i < frameGrabbers.Count; i++)
      {
        frameGrabbers[i].Disconnect(false);
      }
    }
  }
}