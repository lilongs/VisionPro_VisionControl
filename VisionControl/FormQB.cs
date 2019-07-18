using System;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;

using Cognex.VisionPro;
using Cognex.VisionPro.QuickBuild;

namespace VisionControl
{
  /// <summary>
  /// Summary description for FormQB.
  /// </summary>
  public class FormQB : System.Windows.Forms.Form
  {
    private CogJobManager mJM = null;

    private CogJobManagerEdit cogJobManagerEdit1;
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.Container components = null;

    public FormQB(CogJobManager jm)
    {
      //
      // Required for Windows Form Designer support
      //
      InitializeComponent();

      mJM = jm;
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
      this.cogJobManagerEdit1 = new Cognex.VisionPro.QuickBuild.CogJobManagerEdit();
      this.SuspendLayout();
      // 
      // cogJobManagerEdit1
      // 
      this.cogJobManagerEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.cogJobManagerEdit1.Location = new System.Drawing.Point(0, 0);
      this.cogJobManagerEdit1.Name = "cogJobManagerEdit1";
      this.cogJobManagerEdit1.Size = new System.Drawing.Size(728, 454);
      this.cogJobManagerEdit1.Subject = null;
      this.cogJobManagerEdit1.TabIndex = 0;
      // 
      // FormQB
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.ClientSize = new System.Drawing.Size(728, 454);
      this.Controls.Add(this.cogJobManagerEdit1);
      this.Name = "FormQB";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Configuration";
      this.Closing += new System.ComponentModel.CancelEventHandler(this.FormQB_Closing);
      this.Load += new System.EventHandler(this.FormQB_Load);
      this.ResumeLayout(false);

    }
    #endregion

    private void FormQB_Load(object sender, System.EventArgs e)
    {
      this.Text = ResourceUtility.GetString("RtQuickBuildTitle");
      cogJobManagerEdit1.Subject = mJM;   
    }

    private void FormQB_Closing(object sender, System.ComponentModel.CancelEventArgs e)
    {
      cogJobManagerEdit1.Subject = null;
    }
  }
}
