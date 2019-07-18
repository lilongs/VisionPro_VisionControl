using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace VisionControl
{
  /// <summary>
  /// Summary description for FormAppOptions.
  /// </summary>
  public class FormAppOptions : System.Windows.Forms.Form
  {
    public bool EnableDisplay;
    public bool EnableIOAtStartup;
    public bool EnableIO;
    private VisionControl mApplicationForm;

    private System.Windows.Forms.Button button_OK;
    private System.Windows.Forms.Button button_Cancel;
    private System.Windows.Forms.CheckBox checkBox_EnableDisplay;
    private System.Windows.Forms.GroupBox groupBox_DisplayOptions;
    private System.Windows.Forms.GroupBox groupBox_QueueOptions;
    private System.Windows.Forms.Button button_ClearQueues;
    private GroupBox groupBox_IOOptions;
    private Label label_CurrentIOState;
    private RadioButton radioButton_Online;
    private CheckBox checkBox_EnableIOAtStartup;
    private RadioButton radioButton_Offline;
    private System.ComponentModel.IContainer components = null;

    public FormAppOptions(VisionControl app)
    {
      mApplicationForm = app;
      InitializeComponent();
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
      this.groupBox_DisplayOptions = new System.Windows.Forms.GroupBox();
      this.checkBox_EnableDisplay = new System.Windows.Forms.CheckBox();
      this.groupBox_QueueOptions = new System.Windows.Forms.GroupBox();
      this.button_ClearQueues = new System.Windows.Forms.Button();
      this.groupBox_IOOptions = new System.Windows.Forms.GroupBox();
      this.label_CurrentIOState = new System.Windows.Forms.Label();
      this.radioButton_Online = new System.Windows.Forms.RadioButton();
      this.radioButton_Offline = new System.Windows.Forms.RadioButton();
      this.checkBox_EnableIOAtStartup = new System.Windows.Forms.CheckBox();
      this.groupBox_DisplayOptions.SuspendLayout();
      this.groupBox_QueueOptions.SuspendLayout();
      this.groupBox_IOOptions.SuspendLayout();
      this.SuspendLayout();
      // 
      // button_OK
      // 
      this.button_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.button_OK.Location = new System.Drawing.Point(86, 365);
      this.button_OK.Name = "button_OK";
      this.button_OK.Size = new System.Drawing.Size(75, 23);
      this.button_OK.TabIndex = 1;
      this.button_OK.Text = "Ok";
      // 
      // button_Cancel
      // 
      this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.button_Cancel.Location = new System.Drawing.Point(215, 365);
      this.button_Cancel.Name = "button_Cancel";
      this.button_Cancel.Size = new System.Drawing.Size(75, 23);
      this.button_Cancel.TabIndex = 2;
      this.button_Cancel.Text = "Cancel";
      // 
      // groupBox_DisplayOptions
      // 
      this.groupBox_DisplayOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox_DisplayOptions.Controls.Add(this.checkBox_EnableDisplay);
      this.groupBox_DisplayOptions.Location = new System.Drawing.Point(24, 16);
      this.groupBox_DisplayOptions.Name = "groupBox_DisplayOptions";
      this.groupBox_DisplayOptions.Size = new System.Drawing.Size(328, 80);
      this.groupBox_DisplayOptions.TabIndex = 3;
      this.groupBox_DisplayOptions.TabStop = false;
      this.groupBox_DisplayOptions.Text = "groupBox_DisplayOptions";
      // 
      // checkBox_EnableDisplay
      // 
      this.checkBox_EnableDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.checkBox_EnableDisplay.Location = new System.Drawing.Point(40, 32);
      this.checkBox_EnableDisplay.Name = "checkBox_EnableDisplay";
      this.checkBox_EnableDisplay.Size = new System.Drawing.Size(272, 24);
      this.checkBox_EnableDisplay.TabIndex = 0;
      this.checkBox_EnableDisplay.Text = "checkBox_enableDisplay";
      // 
      // groupBox_QueueOptions
      // 
      this.groupBox_QueueOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox_QueueOptions.Controls.Add(this.button_ClearQueues);
      this.groupBox_QueueOptions.Location = new System.Drawing.Point(25, 112);
      this.groupBox_QueueOptions.Name = "groupBox_QueueOptions";
      this.groupBox_QueueOptions.Size = new System.Drawing.Size(328, 80);
      this.groupBox_QueueOptions.TabIndex = 4;
      this.groupBox_QueueOptions.TabStop = false;
      this.groupBox_QueueOptions.Text = "groupBox_QueueOptions";
      // 
      // button_ClearQueues
      // 
      this.button_ClearQueues.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.button_ClearQueues.Location = new System.Drawing.Point(88, 32);
      this.button_ClearQueues.Name = "button_ClearQueues";
      this.button_ClearQueues.Size = new System.Drawing.Size(144, 23);
      this.button_ClearQueues.TabIndex = 0;
      this.button_ClearQueues.Text = "Clear History Queues";
      this.button_ClearQueues.Click += new System.EventHandler(this.button_ClearQueues_Click);
      // 
      // groupBox_IOOptions
      // 
      this.groupBox_IOOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox_IOOptions.Controls.Add(this.checkBox_EnableIOAtStartup);
      this.groupBox_IOOptions.Controls.Add(this.radioButton_Offline);
      this.groupBox_IOOptions.Controls.Add(this.radioButton_Online);
      this.groupBox_IOOptions.Controls.Add(this.label_CurrentIOState);
      this.groupBox_IOOptions.Location = new System.Drawing.Point(25, 205);
      this.groupBox_IOOptions.Name = "groupBox_IOOptions";
      this.groupBox_IOOptions.Size = new System.Drawing.Size(328, 140);
      this.groupBox_IOOptions.TabIndex = 5;
      this.groupBox_IOOptions.TabStop = false;
      this.groupBox_IOOptions.Text = "groupBox_IOOptions";
      // 
      // label_CurrentIOState
      // 
      this.label_CurrentIOState.AutoSize = true;
      this.label_CurrentIOState.Location = new System.Drawing.Point(36, 32);
      this.label_CurrentIOState.Name = "label_CurrentIOState";
      this.label_CurrentIOState.Size = new System.Drawing.Size(105, 13);
      this.label_CurrentIOState.TabIndex = 0;
      this.label_CurrentIOState.Text = "label_CurrentIOState";
      // 
      // radioButton_Online
      // 
      this.radioButton_Online.AutoSize = true;
      this.radioButton_Online.Location = new System.Drawing.Point(54, 50);
      this.radioButton_Online.Name = "radioButton_Online";
      this.radioButton_Online.Size = new System.Drawing.Size(115, 17);
      this.radioButton_Online.TabIndex = 1;
      this.radioButton_Online.TabStop = true;
      this.radioButton_Online.Text = "radioButton_Online";
      this.radioButton_Online.UseVisualStyleBackColor = true;
      // 
      // radioButton_Offline
      // 
      this.radioButton_Offline.AutoSize = true;
      this.radioButton_Offline.Location = new System.Drawing.Point(54, 73);
      this.radioButton_Offline.Name = "radioButton_Offline";
      this.radioButton_Offline.Size = new System.Drawing.Size(115, 17);
      this.radioButton_Offline.TabIndex = 2;
      this.radioButton_Offline.TabStop = true;
      this.radioButton_Offline.Text = "radioButton_Offline";
      this.radioButton_Offline.UseVisualStyleBackColor = true;
      // 
      // checkBox_EnableIOAtStartup
      // 
      this.checkBox_EnableIOAtStartup.AutoSize = true;
      this.checkBox_EnableIOAtStartup.Location = new System.Drawing.Point(39, 110);
      this.checkBox_EnableIOAtStartup.Name = "checkBox_EnableIOAtStartup";
      this.checkBox_EnableIOAtStartup.Size = new System.Drawing.Size(168, 17);
      this.checkBox_EnableIOAtStartup.TabIndex = 3;
      this.checkBox_EnableIOAtStartup.Text = "checkBox_EnableIOAtStartup";
      this.checkBox_EnableIOAtStartup.UseVisualStyleBackColor = true;
      // 
      // FormAppOptions
      // 
      this.AcceptButton = this.button_OK;
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.CancelButton = this.button_Cancel;
      this.ClientSize = new System.Drawing.Size(378, 409);
      this.Controls.Add(this.groupBox_IOOptions);
      this.Controls.Add(this.groupBox_QueueOptions);
      this.Controls.Add(this.groupBox_DisplayOptions);
      this.Controls.Add(this.button_Cancel);
      this.Controls.Add(this.button_OK);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "FormAppOptions";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "FormAppOptions";
      this.Closing += new System.ComponentModel.CancelEventHandler(this.FormAppOptions_Closing);
      this.Load += new System.EventHandler(this.FormAppOptions_Load);
      this.groupBox_DisplayOptions.ResumeLayout(false);
      this.groupBox_QueueOptions.ResumeLayout(false);
      this.groupBox_IOOptions.ResumeLayout(false);
      this.groupBox_IOOptions.PerformLayout();
      this.ResumeLayout(false);

    }
    #endregion

    private void FormAppOptions_Closing(object sender, System.ComponentModel.CancelEventArgs e)
    {
      EnableDisplay = checkBox_EnableDisplay.Checked;
      EnableIOAtStartup = checkBox_EnableIOAtStartup.Checked;
      EnableIO = radioButton_Online.Checked;
    }

    private void FormAppOptions_Load(object sender, System.EventArgs e)
    {
      checkBox_EnableDisplay.Checked = EnableDisplay;
      checkBox_EnableIOAtStartup.Checked = EnableIOAtStartup;
      radioButton_Online.Checked = EnableIO;
      radioButton_Offline.Checked = !EnableIO;

      this.Text = ResourceUtility.GetString("RtAppOptionsTitle");
      this.groupBox_DisplayOptions.Text = ResourceUtility.GetString("RtGroupDisplayOptions");
      this.groupBox_QueueOptions.Text = ResourceUtility.GetString("RtGroupQueueOptions");
      this.groupBox_IOOptions.Text = ResourceUtility.GetString("RtGroupIOOptions");
      this.checkBox_EnableDisplay.Text = ResourceUtility.GetString("RtEnableDisplay");
      this.button_ClearQueues.Text = ResourceUtility.GetString("RtClearQueues");
      this.label_CurrentIOState.Text = ResourceUtility.GetString("RtCurrentIOState");
      this.radioButton_Online.Text = ResourceUtility.GetString("RtOnline");
      this.radioButton_Offline.Text = ResourceUtility.GetString("RtOffline");
      this.checkBox_EnableIOAtStartup.Text = ResourceUtility.GetString("RtEnableIOAtStartup");
      this.button_Cancel.Text = ResourceUtility.GetString("RtCancel");
      this.button_OK.Text = ResourceUtility.GetString("RtOK");
    }

    private void button_ClearQueues_Click(object sender, System.EventArgs e)
    {
      mApplicationForm.ClearHistoryQueues(sender, e);
    }
  }
}
