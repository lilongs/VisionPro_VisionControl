using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;

namespace VisionControl
{
  /// <summary>
  /// Summary description for FormAbout.
  /// </summary>
  public class FormAbout : System.Windows.Forms.Form
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.Container components = null;
    private System.Windows.Forms.TextBox textBox_aboutText;
    private System.Windows.Forms.Button button_OK;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox textBox_VppFilename;
    private System.Windows.Forms.TextBox textBox_PasswordFile;
    private System.Windows.Forms.TextBox textBox_AppInfo;
    private System.Windows.Forms.TextBox textBox_AboutFile;
    private System.Windows.Forms.Label label_About;
    private System.Windows.Forms.Label label_Password;
    private System.Windows.Forms.Label label_Vpp;

    private string mAboutFilename;
    private VisionControl mVisionControl;

    public FormAbout(string fname, VisionControl ctl)
    {
      //
      // Required for Windows Form Designer support
      //
      InitializeComponent();

      mAboutFilename = fname;
      mVisionControl = ctl;
    }

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    protected override void Dispose( bool disposing )
    {
      if( disposing )
      {
        if(components != null)
        {
          components.Dispose();
        }
      }
      base.Dispose( disposing );
    }

    #region Windows Form Designer generated code
    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.textBox_aboutText = new System.Windows.Forms.TextBox();
      this.button_OK = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.textBox_AboutFile = new System.Windows.Forms.TextBox();
      this.label_About = new System.Windows.Forms.Label();
      this.textBox_AppInfo = new System.Windows.Forms.TextBox();
      this.textBox_PasswordFile = new System.Windows.Forms.TextBox();
      this.label_Password = new System.Windows.Forms.Label();
      this.textBox_VppFilename = new System.Windows.Forms.TextBox();
      this.label_Vpp = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // textBox_aboutText
      // 
      this.textBox_aboutText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
        | System.Windows.Forms.AnchorStyles.Left) 
        | System.Windows.Forms.AnchorStyles.Right)));
      this.textBox_aboutText.Location = new System.Drawing.Point(16, 200);
      this.textBox_aboutText.Multiline = true;
      this.textBox_aboutText.Name = "textBox_aboutText";
      this.textBox_aboutText.ReadOnly = true;
      this.textBox_aboutText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.textBox_aboutText.Size = new System.Drawing.Size(536, 152);
      this.textBox_aboutText.TabIndex = 2;
      this.textBox_aboutText.Text = "textBox1";
      // 
      // button_OK
      // 
      this.button_OK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
      this.button_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.button_OK.Location = new System.Drawing.Point(224, 360);
      this.button_OK.Name = "button_OK";
      this.button_OK.Size = new System.Drawing.Size(104, 24);
      this.button_OK.TabIndex = 0;
      this.button_OK.Text = "OK";
      // 
      // groupBox1
      // 
      this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
        | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox1.Controls.Add(this.textBox_AboutFile);
      this.groupBox1.Controls.Add(this.label_About);
      this.groupBox1.Controls.Add(this.textBox_AppInfo);
      this.groupBox1.Controls.Add(this.textBox_PasswordFile);
      this.groupBox1.Controls.Add(this.label_Password);
      this.groupBox1.Controls.Add(this.textBox_VppFilename);
      this.groupBox1.Controls.Add(this.label_Vpp);
      this.groupBox1.Location = new System.Drawing.Point(16, 16);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(536, 168);
      this.groupBox1.TabIndex = 1;
      this.groupBox1.TabStop = false;
      // 
      // textBox_AboutFile
      // 
      this.textBox_AboutFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
        | System.Windows.Forms.AnchorStyles.Right)));
      this.textBox_AboutFile.Location = new System.Drawing.Point(152, 128);
      this.textBox_AboutFile.Name = "textBox_AboutFile";
      this.textBox_AboutFile.ReadOnly = true;
      this.textBox_AboutFile.Size = new System.Drawing.Size(360, 20);
      this.textBox_AboutFile.TabIndex = 3;
      this.textBox_AboutFile.Text = "textBox1";
      // 
      // label_About
      // 
      this.label_About.Location = new System.Drawing.Point(24, 128);
      this.label_About.Name = "label_About";
      this.label_About.Size = new System.Drawing.Size(128, 16);
      this.label_About.TabIndex = 5;
      this.label_About.Text = "Using about.txt file:";
      // 
      // textBox_AppInfo
      // 
      this.textBox_AppInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
        | System.Windows.Forms.AnchorStyles.Right)));
      this.textBox_AppInfo.Location = new System.Drawing.Point(24, 24);
      this.textBox_AppInfo.Multiline = true;
      this.textBox_AppInfo.Name = "textBox_AppInfo";
      this.textBox_AppInfo.ReadOnly = true;
      this.textBox_AppInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.textBox_AppInfo.Size = new System.Drawing.Size(488, 40);
      this.textBox_AppInfo.TabIndex = 0;
      this.textBox_AppInfo.Text = "textBox";
      // 
      // textBox_PasswordFile
      // 
      this.textBox_PasswordFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
        | System.Windows.Forms.AnchorStyles.Right)));
      this.textBox_PasswordFile.Location = new System.Drawing.Point(152, 104);
      this.textBox_PasswordFile.Name = "textBox_PasswordFile";
      this.textBox_PasswordFile.ReadOnly = true;
      this.textBox_PasswordFile.Size = new System.Drawing.Size(360, 20);
      this.textBox_PasswordFile.TabIndex = 2;
      this.textBox_PasswordFile.Text = "textBox1";
      // 
      // label_Password
      // 
      this.label_Password.Location = new System.Drawing.Point(24, 104);
      this.label_Password.Name = "label_Password";
      this.label_Password.Size = new System.Drawing.Size(128, 16);
      this.label_Password.TabIndex = 2;
      this.label_Password.Text = "Using password file:";
      // 
      // textBox_VppFilename
      // 
      this.textBox_VppFilename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
        | System.Windows.Forms.AnchorStyles.Right)));
      this.textBox_VppFilename.Location = new System.Drawing.Point(152, 80);
      this.textBox_VppFilename.Name = "textBox_VppFilename";
      this.textBox_VppFilename.ReadOnly = true;
      this.textBox_VppFilename.Size = new System.Drawing.Size(360, 20);
      this.textBox_VppFilename.TabIndex = 1;
      this.textBox_VppFilename.Text = "textBox1";
      // 
      // label_Vpp
      // 
      this.label_Vpp.Location = new System.Drawing.Point(24, 80);
      this.label_Vpp.Name = "label_Vpp";
      this.label_Vpp.Size = new System.Drawing.Size(128, 16);
      this.label_Vpp.TabIndex = 0;
      this.label_Vpp.Text = "Using .vpp file:";
      // 
      // FormAbout
      // 
      this.AcceptButton = this.button_OK;
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.CancelButton = this.button_OK;
      this.ClientSize = new System.Drawing.Size(568, 398);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.button_OK);
      this.Controls.Add(this.textBox_aboutText);
      this.Name = "FormAbout";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "FormAbout";
      this.Load += new System.EventHandler(this.FormAbout_Load);
      this.groupBox1.ResumeLayout(false);
      this.ResumeLayout(false);

    }
    #endregion

    private void FormAbout_Load(object sender, System.EventArgs e)
    {
      this.label_About.Text = ResourceUtility.GetString("RtUsingAbout");
      this.label_Password.Text = ResourceUtility.GetString("RtUsingPasswords");
      this.label_Vpp.Text = ResourceUtility.GetString("RtUsingVpp");
      this.button_OK.Text = ResourceUtility.GetString("RtOK");

      // general info
      this.textBox_AppInfo.Text = ResourceUtility.FormatString("RtAppGeneratedInfo", VisionControl.GenerationDateTime.ToString("r"),
        VisionControl.GeneratedByVersion);

      // vpp filename
      textBox_VppFilename.Text = mVisionControl.LoadedVppFilename;
      if (textBox_VppFilename.Text == "")
        textBox_VppFilename.Text = ResourceUtility.GetString("RtNoFile");

      // password info
      if (mVisionControl.UsingPasswords)
      {
        if (mVisionControl.CurrentPasswordFile != null &&
            mVisionControl.CurrentPasswordFile.PasswordFileValid)
          textBox_PasswordFile.Text = mVisionControl.CurrentPasswordFile.PasswordFilename;
        else
          textBox_PasswordFile.Text = ResourceUtility.GetString("RtDefaultPasswords");
      }
      else
        textBox_PasswordFile.Text = ResourceUtility.GetString("RtNoFile");

      string aboutText = "";

      if (!File.Exists(mAboutFilename))
      {
        aboutText = ResourceUtility.GetString("RtNoDetails");
        textBox_AboutFile.Text = ResourceUtility.GetString("RtNoFile");
      }
      else
      {
        // open and read file
        textBox_AboutFile.Text = mAboutFilename;
        try
        {
          if (mAboutFilename != null)
          {
            StreamReader sr = new StreamReader(mAboutFilename);
            aboutText = sr.ReadToEnd();
            sr.Close();
          }
        }
        catch (Exception exc)
        {
          aboutText = ResourceUtility.FormatString("RtOpenFileError", mAboutFilename) + System.Environment.NewLine + System.Environment.NewLine;
          aboutText += exc.ToString();
        }
      }

      // display contents
      textBox_aboutText.Text = aboutText;                
    }
  }
}
