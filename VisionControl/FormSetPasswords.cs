using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace VisionControl
{
  /// <summary>
  /// Summary description for FormSetPasswords.
  /// </summary>
  public class FormSetPasswords : System.Windows.Forms.Form
  {
    private System.Windows.Forms.Button button_Cancel;
    private System.Windows.Forms.TextBox textBox_SupervisorPassword;
    private System.Windows.Forms.TextBox textBox_SupervisorConfirm;
    private System.Windows.Forms.TextBox textBox_AdministratorConfirm;
    private System.Windows.Forms.TextBox textBox_AdministratorPassword;
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.Container components = null;
    private System.Windows.Forms.Button button_OK;
    private System.Windows.Forms.GroupBox groupBox_Supervisor;
    private System.Windows.Forms.Label label_ConfirmPassword1;
    private System.Windows.Forms.Label label_Password1;
    private System.Windows.Forms.GroupBox groupBox_Administrator;
    private System.Windows.Forms.Label label_ConfirmPassword2;
    private System.Windows.Forms.Label label_Password2;

    private PasswordFile mPasswordFile;

    public FormSetPasswords(PasswordFile file)
    {
      //
      // Required for Windows Form Designer support
      //
      InitializeComponent();

      mPasswordFile = file;
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
      this.button_OK = new System.Windows.Forms.Button();
      this.button_Cancel = new System.Windows.Forms.Button();
      this.groupBox_Supervisor = new System.Windows.Forms.GroupBox();
      this.textBox_SupervisorConfirm = new System.Windows.Forms.TextBox();
      this.textBox_SupervisorPassword = new System.Windows.Forms.TextBox();
      this.label_ConfirmPassword1 = new System.Windows.Forms.Label();
      this.label_Password1 = new System.Windows.Forms.Label();
      this.groupBox_Administrator = new System.Windows.Forms.GroupBox();
      this.textBox_AdministratorConfirm = new System.Windows.Forms.TextBox();
      this.textBox_AdministratorPassword = new System.Windows.Forms.TextBox();
      this.label_ConfirmPassword2 = new System.Windows.Forms.Label();
      this.label_Password2 = new System.Windows.Forms.Label();
      this.groupBox_Supervisor.SuspendLayout();
      this.groupBox_Administrator.SuspendLayout();
      this.SuspendLayout();
      // 
      // button_OK
      // 
      this.button_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.button_OK.Location = new System.Drawing.Point(96, 264);
      this.button_OK.Name = "button_OK";
      this.button_OK.Size = new System.Drawing.Size(88, 23);
      this.button_OK.TabIndex = 2;
      this.button_OK.Text = "Ok";
      this.button_OK.Click += new System.EventHandler(this.button_Ok_Click);
      // 
      // button_Cancel
      // 
      this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.button_Cancel.Location = new System.Drawing.Point(240, 264);
      this.button_Cancel.Name = "button_Cancel";
      this.button_Cancel.Size = new System.Drawing.Size(88, 23);
      this.button_Cancel.TabIndex = 3;
      this.button_Cancel.Text = "Cancel";
      // 
      // groupBox_Supervisor
      // 
      this.groupBox_Supervisor.Controls.Add(this.textBox_SupervisorConfirm);
      this.groupBox_Supervisor.Controls.Add(this.textBox_SupervisorPassword);
      this.groupBox_Supervisor.Controls.Add(this.label_ConfirmPassword1);
      this.groupBox_Supervisor.Controls.Add(this.label_Password1);
      this.groupBox_Supervisor.Location = new System.Drawing.Point(16, 24);
      this.groupBox_Supervisor.Name = "groupBox_Supervisor";
      this.groupBox_Supervisor.Size = new System.Drawing.Size(400, 104);
      this.groupBox_Supervisor.TabIndex = 0;
      this.groupBox_Supervisor.TabStop = false;
      this.groupBox_Supervisor.Text = "Supervisor";
      // 
      // textBox_SupervisorConfirm
      // 
      this.textBox_SupervisorConfirm.Location = new System.Drawing.Point(152, 64);
      this.textBox_SupervisorConfirm.Name = "textBox_SupervisorConfirm";
      this.textBox_SupervisorConfirm.PasswordChar = '*';
      this.textBox_SupervisorConfirm.Size = new System.Drawing.Size(224, 20);
      this.textBox_SupervisorConfirm.TabIndex = 1;
      this.textBox_SupervisorConfirm.Text = "textBox2";
      this.textBox_SupervisorConfirm.TextChanged += new System.EventHandler(this.textBox_Password_TextChanged);
      // 
      // textBox_SupervisorPassword
      // 
      this.textBox_SupervisorPassword.Location = new System.Drawing.Point(152, 32);
      this.textBox_SupervisorPassword.Name = "textBox_SupervisorPassword";
      this.textBox_SupervisorPassword.PasswordChar = '*';
      this.textBox_SupervisorPassword.Size = new System.Drawing.Size(224, 20);
      this.textBox_SupervisorPassword.TabIndex = 0;
      this.textBox_SupervisorPassword.Text = "textBox1";
      this.textBox_SupervisorPassword.TextChanged += new System.EventHandler(this.textBox_Password_TextChanged);
      // 
      // label_ConfirmPassword1
      // 
      this.label_ConfirmPassword1.Location = new System.Drawing.Point(24, 64);
      this.label_ConfirmPassword1.Name = "label_ConfirmPassword1";
      this.label_ConfirmPassword1.Size = new System.Drawing.Size(128, 16);
      this.label_ConfirmPassword1.TabIndex = 1;
      this.label_ConfirmPassword1.Text = "Confirm password:";
      // 
      // label_Password1
      // 
      this.label_Password1.Location = new System.Drawing.Point(24, 32);
      this.label_Password1.Name = "label_Password1";
      this.label_Password1.Size = new System.Drawing.Size(128, 16);
      this.label_Password1.TabIndex = 0;
      this.label_Password1.Text = "Password:";
      // 
      // groupBox_Administrator
      // 
      this.groupBox_Administrator.Controls.Add(this.textBox_AdministratorConfirm);
      this.groupBox_Administrator.Controls.Add(this.textBox_AdministratorPassword);
      this.groupBox_Administrator.Controls.Add(this.label_ConfirmPassword2);
      this.groupBox_Administrator.Controls.Add(this.label_Password2);
      this.groupBox_Administrator.Location = new System.Drawing.Point(16, 144);
      this.groupBox_Administrator.Name = "groupBox_Administrator";
      this.groupBox_Administrator.Size = new System.Drawing.Size(400, 104);
      this.groupBox_Administrator.TabIndex = 1;
      this.groupBox_Administrator.TabStop = false;
      this.groupBox_Administrator.Text = "Administrator";
      // 
      // textBox_AdministratorConfirm
      // 
      this.textBox_AdministratorConfirm.Location = new System.Drawing.Point(152, 64);
      this.textBox_AdministratorConfirm.Name = "textBox_AdministratorConfirm";
      this.textBox_AdministratorConfirm.PasswordChar = '*';
      this.textBox_AdministratorConfirm.Size = new System.Drawing.Size(224, 20);
      this.textBox_AdministratorConfirm.TabIndex = 1;
      this.textBox_AdministratorConfirm.Text = "textbox2";
      this.textBox_AdministratorConfirm.TextChanged += new System.EventHandler(this.textBox_Password_TextChanged);
      // 
      // textBox_AdministratorPassword
      // 
      this.textBox_AdministratorPassword.Location = new System.Drawing.Point(152, 32);
      this.textBox_AdministratorPassword.Name = "textBox_AdministratorPassword";
      this.textBox_AdministratorPassword.PasswordChar = '*';
      this.textBox_AdministratorPassword.Size = new System.Drawing.Size(224, 20);
      this.textBox_AdministratorPassword.TabIndex = 0;
      this.textBox_AdministratorPassword.Text = "textBox1";
      this.textBox_AdministratorPassword.TextChanged += new System.EventHandler(this.textBox_Password_TextChanged);
      // 
      // label_ConfirmPassword2
      // 
      this.label_ConfirmPassword2.Location = new System.Drawing.Point(24, 64);
      this.label_ConfirmPassword2.Name = "label_ConfirmPassword2";
      this.label_ConfirmPassword2.Size = new System.Drawing.Size(128, 16);
      this.label_ConfirmPassword2.TabIndex = 1;
      this.label_ConfirmPassword2.Text = "Confirm password:";
      // 
      // label_Password2
      // 
      this.label_Password2.Location = new System.Drawing.Point(24, 32);
      this.label_Password2.Name = "label_Password2";
      this.label_Password2.Size = new System.Drawing.Size(128, 16);
      this.label_Password2.TabIndex = 0;
      this.label_Password2.Text = "Password:";
      // 
      // FormSetPasswords
      // 
      this.AcceptButton = this.button_OK;
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.CancelButton = this.button_Cancel;
      this.ClientSize = new System.Drawing.Size(432, 304);
      this.Controls.Add(this.groupBox_Supervisor);
      this.Controls.Add(this.button_Cancel);
      this.Controls.Add(this.button_OK);
      this.Controls.Add(this.groupBox_Administrator);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "FormSetPasswords";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Set Passwords";
      this.Load += new System.EventHandler(this.FormSetPasswords_Load);
      this.groupBox_Supervisor.ResumeLayout(false);
      this.groupBox_Administrator.ResumeLayout(false);
      this.ResumeLayout(false);

    }
    #endregion

    private void FormSetPasswords_Load(object sender, System.EventArgs e)
    {
      this.Text = ResourceUtility.GetString("RtSetPasswordsTitle");
      this.groupBox_Administrator.Text = ResourceUtility.GetString("RtAdministrator");
      this.groupBox_Supervisor.Text = ResourceUtility.GetString("RtSupervisor");
      this.label_ConfirmPassword1.Text = ResourceUtility.GetString("RtConfirmPassword");
      this.label_ConfirmPassword2.Text = this.label_ConfirmPassword1.Text;
      this.label_Password1.Text = ResourceUtility.GetString("RtPassword");
      this.label_Password2.Text = this.label_Password1.Text;
      this.button_Cancel.Text = ResourceUtility.GetString("RtCancel");
      this.button_OK.Text = ResourceUtility.GetString("RtOK");

      this.textBox_SupervisorPassword.Text = mPasswordFile.GetPasswordForAccessLevel(AccessLevel.Supervisor);
      this.textBox_SupervisorConfirm.Text = this.textBox_SupervisorPassword.Text;

      this.textBox_AdministratorPassword.Text = mPasswordFile.GetPasswordForAccessLevel(AccessLevel.Administrator);
      this.textBox_AdministratorConfirm.Text = this.textBox_AdministratorPassword.Text;

      EnableOk();
    }

    private void EnableOk()
    {
      // enable ok button based on dialog contents
      bool en = false;

      // confirms must match and passwords must not be empty
      if (this.textBox_AdministratorConfirm.Text == this.textBox_AdministratorPassword.Text &&
        this.textBox_SupervisorConfirm.Text == this.textBox_SupervisorPassword.Text &&
        this.textBox_AdministratorPassword.Text != "" &&
        this.textBox_SupervisorPassword.Text != "")
      {
        // password must have changed
        if (this.textBox_AdministratorPassword.Text != mPasswordFile.GetPasswordForAccessLevel(AccessLevel.Administrator) ||
          this.textBox_SupervisorPassword.Text != mPasswordFile.GetPasswordForAccessLevel(AccessLevel.Supervisor))
          en = true;
      }

      button_OK.Enabled = en;
    }

    private void textBox_Password_TextChanged(object sender, System.EventArgs e)
    {
      EnableOk();
    }

    private void button_Ok_Click(object sender, System.EventArgs e)
    {
      mPasswordFile.SetPasswordForAccessLevel(AccessLevel.Supervisor, this.textBox_SupervisorPassword.Text);
      mPasswordFile.SetPasswordForAccessLevel(AccessLevel.Administrator, this.textBox_AdministratorPassword.Text);

      // writes a password file only if needed
      mPasswordFile.WritePasswordFile();
    }
  }
}
