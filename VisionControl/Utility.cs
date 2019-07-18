using System;
using System.Windows.Forms;
using System.Resources;

using Cognex.VisionPro;
using Cognex.VisionPro.Implementation.Internal;
using Cognex.VisionPro.QuickBuild;

namespace VisionControl
{

  public class Utility
  {
    static public ICogRecord TraverseSubRecords(ICogRecord r, string[] subs)
    {
      // Utility function to walk down to a specific subrecord
      if (r == null)
        return r;

      foreach (string s in subs)
      {
        if (r.SubRecords.ContainsKey(s))
          r = r.SubRecords[s];
        else
          return null;
      }

      return r;
    }

    static public void FlushAllQueues(CogJobManager jm)
    {
      // Flush all queues
      if (jm == null)
        return;

      jm.UserQueueFlush();
      jm.FailureQueueFlush();
      for (int i = 0; i < jm.JobCount; i++) 
      {
        jm.Job(i).OwnedIndependent.RealTimeQueueFlush();
        jm.Job(i).ImageQueueFlush();
      }
    }

    static public int GetJobIndexFromName(CogJobManager mgr, string name)
    {
      if (mgr != null)
      {
        for (int i = 0; i < mgr.JobCount; ++i)
          if (mgr.Job(i).Name == name)
            return i;
      }
      return -1;
    }

    static public bool AddRecordToDisplay(CogRecordsDisplay disp, ICogRecord r, string[] subs,
      bool pickBestImage)
    {
      // Utility function to put a specific subrecord into a display
      ICogRecord addrec = Utility.TraverseSubRecords(r, subs);
      if (addrec != null)
      {
        // if this is the first record in, then always select an image
        if (disp.Subject == null)
          pickBestImage = true;

        disp.Subject = addrec;

        if (pickBestImage)
        {
          // select first non-empty image record, to workaround the fact that the input image tool
          // adds an empty subrecord to the LastRun record when it is disabled (when an image file
          // tool is used, for example)
          for (int i=0; i<addrec.SubRecords.Count; ++i)
          {
            ICogImage img = addrec.SubRecords[i].Content as ICogImage;
            if (img != null && img.Height != 0 && img.Width != 0)
            {
              disp.SelectedRecordKey = addrec.RecordKey + "." + addrec.SubRecords[i].RecordKey;
              break;
            }
          }
        }

        return true;
      }

      return false;
    }

    private static bool TypeIsNumeric(Type t)
    {
      if (t == null)
        return false;

      if (t == typeof(double) ||
        t == typeof(long) ||
        t == typeof(sbyte) || t == typeof(byte) ||
        t == typeof(short) || t == typeof(ushort) ||
        t == typeof(int) || t == typeof(uint) ||
        t == typeof(ulong))
        return true;

      return false;
    }

    private static Type GetPropertyType(object obj, string path)
    {
      if (obj == null || path == "")
        return null;

      System.Reflection.MemberInfo[] infos = CogToolTerminals.
        ConvertPathToMemberInfos(obj, obj.GetType(), path);

      if (infos.Length == 0)
        return null;

      // Return the type of the last path element.
      return CogToolTerminals.GetReturnType(infos[infos.Length - 1]);
    }

    public static void FillUserResultData(Control ctrl, ICogRecord result, string path)
    {
      FillUserResultData(ctrl, result, path, false);
    }

    public static void FillUserResultData(Control ctrl, ICogRecord result, string path, bool convertRadiansToDegrees)
    {
      // Extract the data identified by the path (if available) from the given result record.
      // Use a format string for doubles.
      string rtn;
      HorizontalAlignment align = HorizontalAlignment.Left;
      if (result == null)
        rtn = ResourceUtility.GetString("RtResultNotAvailable");
      else
      {
        object obj = null;

        try 
        {
          obj = result.SubRecords[path].Content;
        }
        catch
        {
        }

        // check if data is available
        if (obj != null && obj.GetType().FullName != "System.Object")
        {
          if (obj.GetType() == typeof(double))
          {
            double d = (double)obj;
            if (convertRadiansToDegrees)
              d = CogMisc.RadToDeg(d);
            rtn = d.ToString("0.000");
          }
          else
            rtn = obj.ToString();

          if (TypeIsNumeric(obj.GetType()))
            align = HorizontalAlignment.Right;
        }
        else
          rtn = ResourceUtility.GetString("RtResultNotAvailable");
      }

      ctrl.Text = rtn;
      TextBox box = ctrl as TextBox;
      if (box != null)
        box.TextAlign = align;
    }

    public static void SetupPropertyProvider(CogToolPropertyProvider p, Control gui, object tool, string path)
    {
      p.SetPath(gui, path);

      TextBox box = gui as TextBox;
      if (box != null)
      {
        Type t = GetPropertyType(tool, path);
        if (TypeIsNumeric(t))
          box.TextAlign = HorizontalAlignment.Right;
      }
    }

    public static string GetThisExecutableDirectory()
    {
      string loc = Application.ExecutablePath;
      loc = System.IO.Path.GetDirectoryName(loc) + "\\";
      return loc;
    }

    public static bool AccessAllowed(string stringLevelRequired, AccessLevel currentLogin)
    {
      // return true if the currentLogin is equal to or greater than the given access
      // level (expressed as a string)
      AccessLevel needed = AccessLevel.Administrator;

      try 
      {
        object obj = Enum.Parse(typeof(AccessLevel), stringLevelRequired, true);
        needed = (AccessLevel) obj;
      }
      catch (ArgumentException)
      {
      }

      return currentLogin >= needed;
    }

    /// <summary>
    /// Take a filename (generally a relative path) and determine the full path to the file to
    /// use.  First the directory containing the current .vpp file is checked for the given filename,
    /// then the directory containing this code's assembly is checked.
    /// </summary>
    public static string ResolveAssociatedFilename(string vppfname, string fname)
    {
      // check for the given file in the same directory as the developer vpp file path
      string trydev = System.IO.Path.GetDirectoryName(vppfname) + "\\" + fname;
      if (System.IO.File.Exists(trydev))
      {
        fname = trydev;
      }
      else
      {
        // otherwise use same directory as this executable
        fname = GetThisExecutableDirectory() + fname;
      }

      return fname;
    }


  }

  public class ResourceUtility
  {
    // helper class to wrap string resources for this application

    private static ResourceManager mResources;

    static ResourceUtility()
    {
      mResources = new ResourceManager("VisionControl.strings",
        System.Reflection.Assembly.GetExecutingAssembly());
    }

    public static string GetString(string resname)
    {
      string str = mResources.GetString(resname);
      if (str == null)
        str = "ERROR(" + resname + ")";
      return str;
    }

    public static string FormatString(string resname, string arg0)
    {
      try 
      {
        return string.Format(GetString(resname), arg0);
      } 
      catch (Exception)
      {
      }

      return "ERROR(" + resname + ")";
    }

    public static string FormatString(string resname, string arg0, string arg1)
    {
      try 
      {
        return string.Format(GetString(resname), arg0, arg1);
      }
      catch (Exception)
      {
      }

      return "ERROR(" + resname + ")";
    }

  }
}
