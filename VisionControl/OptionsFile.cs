using System;
using System.IO;

namespace VisionControl
{
  /// <summary>
  /// Summary description for OptionsFile.
  /// </summary>
  public class OptionsFile
  {
    public OptionsFile()
    {
      // write options file into current executable directory
      _fname = Utility.GetThisExecutableDirectory() + "options.txt";

      // defaults
      _enableImageDisplay = true;
      _enableIOAtStartup  = true;

      _changed = false;
    }

    #region Public interface
    public string FileName { get { return _fname; } }

    public bool Changed
    {
      get { return _changed; }
      set { _changed = value; } 
    }

    public bool EnableImageDisplay
    {
      get { return _enableImageDisplay; }
      set
      {
        if (_enableImageDisplay != value)
        {
          _enableImageDisplay = value;
          _changed = true;
        }
      }
    }

    public bool EnableIOAtStartup
    {
      get { return _enableIOAtStartup; }
      set
      {
        if (_enableIOAtStartup != value)
        {
          _enableIOAtStartup = value;
          _changed = true;
        }
      }
    }
    public bool Read()
    {
      // return false if file does not exist
      if (!File.Exists(_fname))
        return false;

      // open and read file
      string line;
      try 
      {
        using (StreamReader sr = new StreamReader(_fname))
        {
          while ((line = sr.ReadLine()) != null)
          {
            // ignore blank lines and lines that begin with #
            line = line.Trim();
            if (line.Length == 0 || line[0] == '#')
              continue;

            // parse line into "name = value" - ignore lines that do not fit that format
            string[] parts = line.Split(new char[]{'='}, 2);
            if (parts.Length != 2)
              continue;

            parts[0] = parts[0].Trim();
            parts[1] = parts[1].Trim();

            ParseNameValue(parts[0], parts[1]);
          }
        }
      }
      catch(Exception)
      {
        return false;
      }

      return true;
    }

    public void Write()
    {
      // don't write if nothing has changed
      if (!_changed)
        return;

      string fileContents = "";
      fileContents += "# Application options" + Environment.NewLine;
      fileContents += Environment.NewLine;

      fileContents += "EnableImageDisplay = " + _enableImageDisplay.ToString() + Environment.NewLine;
      fileContents += "EnableIOAtStartup = " + _enableIOAtStartup.ToString() + Environment.NewLine;

      using (StreamWriter sw = new StreamWriter(_fname))
      {
        sw.Write(fileContents);
      }

      _changed = false;
    }
    #endregion

    #region Private
    private void ParseNameValue(string name, string value)
    {
      try 
      {
        switch(name)
        {
          case "EnableImageDisplay":
            EnableImageDisplay = Boolean.Parse(value);
            break;
          case "EnableIOAtStartup":
            EnableIOAtStartup = Boolean.Parse(value);
            break;
        }
      }
      catch
      {
      }
    }

    private string _fname;
    private bool _enableImageDisplay;
    private bool _enableIOAtStartup;
    private bool _changed;
    #endregion
  }
}
