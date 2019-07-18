using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace VisionControl
{
  /// <summary>
  /// Summary description for FormPasswordPrompt.
  /// </summary>
  public class FormPasswordPrompt : System.Windows.Forms.Form
  {
    private System.Windows.Forms.TextBox textBox_Password;
    private System.Windows.Forms.Button button_OK;
    private System.Windows.Forms.Button button_Cancel;
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.Container components = null;
    private System.Windows.Forms.Label label_Password;

    private string mPassword;

    public string Password
    {
      get { return mPassword; }
    }

    public FormPasswordPrompt()
    {
      //
      // Required for Windows Form Designer support
      //
      InitializeComponent();

      mPassword = "";
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
      this.label_Password = new System.Windows.Forms.Label();
      this.textBox_Password = new System.Windows.Forms.TextBox();
      this.button_OK = new System.Windows.Forms.Button();
      this.button_Cancel = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label_Password
      // 
      this.label_Password.Location = new System.Drawing.Point(32, 24);
      this.label_Password.Name = "label_Password";
      this.label_Password.Size = new System.Drawing.Size(96, 16);
      this.label_Password.TabIndex = 0;
      this.label_Password.Text = "Password:";
      // 
      // textBox_Password
      // 
      this.textBox_Password.Location = new System.Drawing.Point(136, 22);
      this.textBox_Password.Name = "textBox_Password";
      this.textBox_Password.PasswordChar = '*';
      this.textBox_Password.Size = new System.Drawing.Size(168, 20);
      this.textBox_Password.TabIndex = 0;
      this.textBox_Password.Text = "";
      // 
      // button_OK
      // 
      this.button_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.button_OK.Location = new System.Drawing.Point(63, 64);
      this.button_OK.Name = "button_OK";
      this.button_OK.Size = new System.Drawing.Size(84, 23);
      this.button_OK.TabIndex = 1;
      this.button_OK.Text = "Ok";
      this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
      // 
      // button_Cancel
      // 
      this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.button_Cancel.Location = new System.Drawing.Point(200, 64);
      this.button_Cancel.Name = "button_Cancel";
      this.button_Cancel.Size = new System.Drawing.Size(84, 23);
      this.button_Cancel.TabIndex = 2;
      this.button_Cancel.Text = "Cancel";
      // 
      // FormPasswordPrompt
      // 
      this.AcceptButton = this.button_OK;
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.CancelButton = this.button_Cancel;
      this.ClientSize = new System.Drawing.Size(352, 110);
      this.Controls.Add(this.button_Cancel);
      this.Controls.Add(this.button_OK);
      this.Controls.Add(this.textBox_Password);
      this.Controls.Add(this.label_Password);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "FormPasswordPrompt";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Enter Password";
      this.Load += new System.EventHandler(this.FormPasswordPrompt_Load);
      this.ResumeLayout(false);

    }
    #endregion

    private void button_OK_Click(object sender, System.EventArgs e)
    {
      mPassword = textBox_Password.Text;
    }

    private void FormPasswordPrompt_Load(object sender, System.EventArgs e)
    {
      this.label_Password.Text = ResourceUtility.GetString("RtPassword");
      this.button_OK.Text = ResourceUtility.GetString("RtOK");
      this.button_Cancel.Text = ResourceUtility.GetString("RtCancel");
    }
  }
}
