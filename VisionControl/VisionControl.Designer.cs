using System.Windows.Forms;

namespace VisionControl
{
  partial class VisionControl
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        if (mJM != null)
          mJM.Shutdown();
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    // cognex.wizard.initializecomponent
    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            this.tabPage_Job0_CogJob1 = new System.Windows.Forms.TabPage();
            this.label_AcquisitionResults_Overruns = new System.Windows.Forms.Label();
            this.textBox_JobN_TotalAcquisitionErrors = new System.Windows.Forms.TextBox();
            this.textBox_JobN_TotalAcquisitionOverruns = new System.Windows.Forms.TextBox();
            this.groupBox_AcquisitionResults = new System.Windows.Forms.GroupBox();
            this.label_AcquisitionResults_Errors = new System.Windows.Forms.Label();
            this.textBox_JobN_TotalAcquisitions = new System.Windows.Forms.TextBox();
            this.label_AcquisitionResults_TotalAcquisitions = new System.Windows.Forms.Label();
            this.label_JobThroughput_persec = new System.Windows.Forms.Label();
            this.groupBox_JobThroughput = new System.Windows.Forms.GroupBox();
            this.textBox_JobN_MaxThroughput = new System.Windows.Forms.TextBox();
            this.textBox_JobN_MinThroughput = new System.Windows.Forms.TextBox();
            this.label_JobThroughput_Max = new System.Windows.Forms.Label();
            this.label_JobThroughput_Min = new System.Windows.Forms.Label();
            this.textBox_JobN_Throughput = new System.Windows.Forms.TextBox();
            this.label_JobThroughput_TotalThroughput = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cogRecordsDisplay1 = new Cognex.VisionPro.CogRecordsDisplay();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tabControl_JobTabs = new System.Windows.Forms.TabControl();
            this.tabPage_JobN_JobStatistics = new System.Windows.Forms.TabPage();
            this.button_ResetStatistics = new System.Windows.Forms.Button();
            this.button_ResetStatisticsForAllJobs = new System.Windows.Forms.Button();
            this.groupBox_JobResults = new System.Windows.Forms.GroupBox();
            this.label_JobResults_Percent = new System.Windows.Forms.Label();
            this.textBox_JobN_TotalAccept_Percent = new System.Windows.Forms.TextBox();
            this.textBox_JobN_TotalWarning = new System.Windows.Forms.TextBox();
            this.textBox_JobN_TotalError = new System.Windows.Forms.TextBox();
            this.label_JobResults_Error = new System.Windows.Forms.Label();
            this.label_JobResults_Warning = new System.Windows.Forms.Label();
            this.textBox_JobN_TotalReject = new System.Windows.Forms.TextBox();
            this.label_JobResults_Reject = new System.Windows.Forms.Label();
            this.textBox_JobN_TotalAccept = new System.Windows.Forms.TextBox();
            this.label_JobResults_Accept = new System.Windows.Forms.Label();
            this.textBox_JobN_TotalIterations = new System.Windows.Forms.TextBox();
            this.label_JobResults_TotalIterations = new System.Windows.Forms.Label();
            this.pictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.label_controlErrorMessage = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label_ResultBar = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRunCont = new System.Windows.Forms.Button();
            this.comboBox_Login = new System.Windows.Forms.ComboBox();
            this.button_SaveSettings = new System.Windows.Forms.Button();
            this.checkBox_LiveDisplay = new System.Windows.Forms.CheckBox();
            this.button_About = new System.Windows.Forms.Button();
            this.groupBox_DividerLine = new System.Windows.Forms.GroupBox();
            this.label_Online = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cogJobResultHistoryCollectionEdit1 = new Cognex.VisionPro.QuickBuild.CogJobResultHistoryCollectionEdit();
            this.label_Login = new System.Windows.Forms.Label();
            this.button_Configuration = new System.Windows.Forms.Button();
            this.applicationErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Chose = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage_Job0_CogJob1.SuspendLayout();
            this.groupBox_AcquisitionResults.SuspendLayout();
            this.groupBox_JobThroughput.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tabControl_JobTabs.SuspendLayout();
            this.tabPage_JobN_JobStatistics.SuspendLayout();
            this.groupBox_JobResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.applicationErrorProvider)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage_Job0_CogJob1
            // 
            this.tabPage_Job0_CogJob1.AutoScroll = true;
            this.tabPage_Job0_CogJob1.Controls.Add(this.dataGridView1);
            this.tabPage_Job0_CogJob1.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Job0_CogJob1.Name = "tabPage_Job0_CogJob1";
            this.tabPage_Job0_CogJob1.Size = new System.Drawing.Size(467, 411);
            this.tabPage_Job0_CogJob1.TabIndex = 0;
            this.tabPage_Job0_CogJob1.Text = "CogJob1";
            // 
            // label_AcquisitionResults_Overruns
            // 
            this.label_AcquisitionResults_Overruns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_AcquisitionResults_Overruns.Location = new System.Drawing.Point(54, 68);
            this.label_AcquisitionResults_Overruns.Name = "label_AcquisitionResults_Overruns";
            this.label_AcquisitionResults_Overruns.Size = new System.Drawing.Size(148, 15);
            this.label_AcquisitionResults_Overruns.TabIndex = 32;
            this.label_AcquisitionResults_Overruns.Text = "Overruns:";
            // 
            // textBox_JobN_TotalAcquisitionErrors
            // 
            this.textBox_JobN_TotalAcquisitionErrors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_JobN_TotalAcquisitionErrors.Location = new System.Drawing.Point(207, 44);
            this.textBox_JobN_TotalAcquisitionErrors.Name = "textBox_JobN_TotalAcquisitionErrors";
            this.textBox_JobN_TotalAcquisitionErrors.ReadOnly = true;
            this.textBox_JobN_TotalAcquisitionErrors.Size = new System.Drawing.Size(100, 21);
            this.textBox_JobN_TotalAcquisitionErrors.TabIndex = 31;
            this.textBox_JobN_TotalAcquisitionErrors.Text = "textBox1";
            this.textBox_JobN_TotalAcquisitionErrors.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_JobN_TotalAcquisitionOverruns
            // 
            this.textBox_JobN_TotalAcquisitionOverruns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_JobN_TotalAcquisitionOverruns.Location = new System.Drawing.Point(207, 66);
            this.textBox_JobN_TotalAcquisitionOverruns.Name = "textBox_JobN_TotalAcquisitionOverruns";
            this.textBox_JobN_TotalAcquisitionOverruns.ReadOnly = true;
            this.textBox_JobN_TotalAcquisitionOverruns.Size = new System.Drawing.Size(100, 21);
            this.textBox_JobN_TotalAcquisitionOverruns.TabIndex = 33;
            this.textBox_JobN_TotalAcquisitionOverruns.Text = "textBox2";
            this.textBox_JobN_TotalAcquisitionOverruns.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox_AcquisitionResults
            // 
            this.groupBox_AcquisitionResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_AcquisitionResults.Controls.Add(this.textBox_JobN_TotalAcquisitionOverruns);
            this.groupBox_AcquisitionResults.Controls.Add(this.label_AcquisitionResults_Overruns);
            this.groupBox_AcquisitionResults.Controls.Add(this.textBox_JobN_TotalAcquisitionErrors);
            this.groupBox_AcquisitionResults.Controls.Add(this.label_AcquisitionResults_Errors);
            this.groupBox_AcquisitionResults.Controls.Add(this.textBox_JobN_TotalAcquisitions);
            this.groupBox_AcquisitionResults.Controls.Add(this.label_AcquisitionResults_TotalAcquisitions);
            this.groupBox_AcquisitionResults.Location = new System.Drawing.Point(22, 148);
            this.groupBox_AcquisitionResults.Name = "groupBox_AcquisitionResults";
            this.groupBox_AcquisitionResults.Size = new System.Drawing.Size(423, 89);
            this.groupBox_AcquisitionResults.TabIndex = 39;
            this.groupBox_AcquisitionResults.TabStop = false;
            this.groupBox_AcquisitionResults.Text = "Acquisition Results";
            // 
            // label_AcquisitionResults_Errors
            // 
            this.label_AcquisitionResults_Errors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_AcquisitionResults_Errors.Location = new System.Drawing.Point(54, 46);
            this.label_AcquisitionResults_Errors.Name = "label_AcquisitionResults_Errors";
            this.label_AcquisitionResults_Errors.Size = new System.Drawing.Size(148, 15);
            this.label_AcquisitionResults_Errors.TabIndex = 30;
            this.label_AcquisitionResults_Errors.Text = "Errors:";
            // 
            // textBox_JobN_TotalAcquisitions
            // 
            this.textBox_JobN_TotalAcquisitions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_JobN_TotalAcquisitions.Location = new System.Drawing.Point(207, 22);
            this.textBox_JobN_TotalAcquisitions.Name = "textBox_JobN_TotalAcquisitions";
            this.textBox_JobN_TotalAcquisitions.ReadOnly = true;
            this.textBox_JobN_TotalAcquisitions.Size = new System.Drawing.Size(100, 21);
            this.textBox_JobN_TotalAcquisitions.TabIndex = 28;
            this.textBox_JobN_TotalAcquisitions.Text = "textBox1";
            this.textBox_JobN_TotalAcquisitions.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_AcquisitionResults_TotalAcquisitions
            // 
            this.label_AcquisitionResults_TotalAcquisitions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_AcquisitionResults_TotalAcquisitions.Location = new System.Drawing.Point(24, 24);
            this.label_AcquisitionResults_TotalAcquisitions.Name = "label_AcquisitionResults_TotalAcquisitions";
            this.label_AcquisitionResults_TotalAcquisitions.Size = new System.Drawing.Size(176, 15);
            this.label_AcquisitionResults_TotalAcquisitions.TabIndex = 27;
            this.label_AcquisitionResults_TotalAcquisitions.Text = "Total Acquisitions:";
            // 
            // label_JobThroughput_persec
            // 
            this.label_JobThroughput_persec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_JobThroughput_persec.Location = new System.Drawing.Point(319, 24);
            this.label_JobThroughput_persec.Name = "label_JobThroughput_persec";
            this.label_JobThroughput_persec.Size = new System.Drawing.Size(96, 15);
            this.label_JobThroughput_persec.TabIndex = 29;
            this.label_JobThroughput_persec.Text = "per sec";
            // 
            // groupBox_JobThroughput
            // 
            this.groupBox_JobThroughput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_JobThroughput.Controls.Add(this.label_JobThroughput_persec);
            this.groupBox_JobThroughput.Controls.Add(this.textBox_JobN_MaxThroughput);
            this.groupBox_JobThroughput.Controls.Add(this.textBox_JobN_MinThroughput);
            this.groupBox_JobThroughput.Controls.Add(this.label_JobThroughput_Max);
            this.groupBox_JobThroughput.Controls.Add(this.label_JobThroughput_Min);
            this.groupBox_JobThroughput.Controls.Add(this.textBox_JobN_Throughput);
            this.groupBox_JobThroughput.Controls.Add(this.label_JobThroughput_TotalThroughput);
            this.groupBox_JobThroughput.Location = new System.Drawing.Point(22, 244);
            this.groupBox_JobThroughput.Name = "groupBox_JobThroughput";
            this.groupBox_JobThroughput.Size = new System.Drawing.Size(423, 89);
            this.groupBox_JobThroughput.TabIndex = 38;
            this.groupBox_JobThroughput.TabStop = false;
            this.groupBox_JobThroughput.Text = "Job Throughput";
            // 
            // textBox_JobN_MaxThroughput
            // 
            this.textBox_JobN_MaxThroughput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_JobN_MaxThroughput.Location = new System.Drawing.Point(207, 66);
            this.textBox_JobN_MaxThroughput.Name = "textBox_JobN_MaxThroughput";
            this.textBox_JobN_MaxThroughput.ReadOnly = true;
            this.textBox_JobN_MaxThroughput.Size = new System.Drawing.Size(100, 21);
            this.textBox_JobN_MaxThroughput.TabIndex = 28;
            this.textBox_JobN_MaxThroughput.Text = "textBox1";
            this.textBox_JobN_MaxThroughput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_JobN_MinThroughput
            // 
            this.textBox_JobN_MinThroughput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_JobN_MinThroughput.Location = new System.Drawing.Point(207, 44);
            this.textBox_JobN_MinThroughput.Name = "textBox_JobN_MinThroughput";
            this.textBox_JobN_MinThroughput.ReadOnly = true;
            this.textBox_JobN_MinThroughput.Size = new System.Drawing.Size(100, 21);
            this.textBox_JobN_MinThroughput.TabIndex = 27;
            this.textBox_JobN_MinThroughput.Text = "textBox1";
            this.textBox_JobN_MinThroughput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_JobThroughput_Max
            // 
            this.label_JobThroughput_Max.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_JobThroughput_Max.Location = new System.Drawing.Point(54, 68);
            this.label_JobThroughput_Max.Name = "label_JobThroughput_Max";
            this.label_JobThroughput_Max.Size = new System.Drawing.Size(148, 15);
            this.label_JobThroughput_Max.TabIndex = 26;
            this.label_JobThroughput_Max.Text = "Max:";
            // 
            // label_JobThroughput_Min
            // 
            this.label_JobThroughput_Min.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_JobThroughput_Min.Location = new System.Drawing.Point(54, 46);
            this.label_JobThroughput_Min.Name = "label_JobThroughput_Min";
            this.label_JobThroughput_Min.Size = new System.Drawing.Size(148, 15);
            this.label_JobThroughput_Min.TabIndex = 25;
            this.label_JobThroughput_Min.Text = "Min:";
            // 
            // textBox_JobN_Throughput
            // 
            this.textBox_JobN_Throughput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_JobN_Throughput.Location = new System.Drawing.Point(207, 22);
            this.textBox_JobN_Throughput.Name = "textBox_JobN_Throughput";
            this.textBox_JobN_Throughput.ReadOnly = true;
            this.textBox_JobN_Throughput.Size = new System.Drawing.Size(100, 21);
            this.textBox_JobN_Throughput.TabIndex = 24;
            this.textBox_JobN_Throughput.Text = "textBox1";
            this.textBox_JobN_Throughput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_JobThroughput_TotalThroughput
            // 
            this.label_JobThroughput_TotalThroughput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_JobThroughput_TotalThroughput.Location = new System.Drawing.Point(24, 24);
            this.label_JobThroughput_TotalThroughput.Name = "label_JobThroughput_TotalThroughput";
            this.label_JobThroughput_TotalThroughput.Size = new System.Drawing.Size(176, 15);
            this.label_JobThroughput_TotalThroughput.TabIndex = 23;
            this.label_JobThroughput_TotalThroughput.Text = "Total Throughput:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cogRecordsDisplay1);
            this.panel5.Controls.Add(this.splitter2);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.label_controlErrorMessage);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 32);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(3);
            this.panel5.Size = new System.Drawing.Size(907, 460);
            this.panel5.TabIndex = 26;
            // 
            // cogRecordsDisplay1
            // 
            this.cogRecordsDisplay1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cogRecordsDisplay1.Location = new System.Drawing.Point(3, 3);
            this.cogRecordsDisplay1.Name = "cogRecordsDisplay1";
            this.cogRecordsDisplay1.SelectedRecordKey = null;
            this.cogRecordsDisplay1.ShowRecordsDropDown = true;
            this.cogRecordsDisplay1.Size = new System.Drawing.Size(420, 454);
            this.cogRecordsDisplay1.Subject = null;
            this.cogRecordsDisplay1.TabIndex = 29;
            // 
            // splitter2
            // 
            this.splitter2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter2.Location = new System.Drawing.Point(423, 3);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(6, 454);
            this.splitter2.TabIndex = 28;
            this.splitter2.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tabControl_JobTabs);
            this.panel6.Controls.Add(this.pictureBox_Logo);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(429, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(475, 454);
            this.panel6.TabIndex = 27;
            // 
            // tabControl_JobTabs
            // 
            this.tabControl_JobTabs.Controls.Add(this.tabPage_JobN_JobStatistics);
            this.tabControl_JobTabs.Controls.Add(this.tabPage_Job0_CogJob1);
            this.tabControl_JobTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_JobTabs.Location = new System.Drawing.Point(0, 0);
            this.tabControl_JobTabs.Name = "tabControl_JobTabs";
            this.tabControl_JobTabs.SelectedIndex = 0;
            this.tabControl_JobTabs.Size = new System.Drawing.Size(475, 437);
            this.tabControl_JobTabs.TabIndex = 28;
            this.tabControl_JobTabs.Tag = "";
            // 
            // tabPage_JobN_JobStatistics
            // 
            this.tabPage_JobN_JobStatistics.AutoScroll = true;
            this.tabPage_JobN_JobStatistics.Controls.Add(this.button_ResetStatistics);
            this.tabPage_JobN_JobStatistics.Controls.Add(this.button_ResetStatisticsForAllJobs);
            this.tabPage_JobN_JobStatistics.Controls.Add(this.groupBox_AcquisitionResults);
            this.tabPage_JobN_JobStatistics.Controls.Add(this.groupBox_JobThroughput);
            this.tabPage_JobN_JobStatistics.Controls.Add(this.groupBox_JobResults);
            this.tabPage_JobN_JobStatistics.Location = new System.Drawing.Point(4, 22);
            this.tabPage_JobN_JobStatistics.Name = "tabPage_JobN_JobStatistics";
            this.tabPage_JobN_JobStatistics.Size = new System.Drawing.Size(467, 411);
            this.tabPage_JobN_JobStatistics.TabIndex = 0;
            this.tabPage_JobN_JobStatistics.Text = "Job Statistics";
            // 
            // button_ResetStatistics
            // 
            this.button_ResetStatistics.Location = new System.Drawing.Point(35, 347);
            this.button_ResetStatistics.Name = "button_ResetStatistics";
            this.button_ResetStatistics.Size = new System.Drawing.Size(133, 21);
            this.button_ResetStatistics.TabIndex = 41;
            this.button_ResetStatistics.Text = "Reset Statistics";
            this.button_ResetStatistics.Click += new System.EventHandler(this.button_ResetStatistics_Click);
            // 
            // button_ResetStatisticsForAllJobs
            // 
            this.button_ResetStatisticsForAllJobs.Location = new System.Drawing.Point(192, 347);
            this.button_ResetStatisticsForAllJobs.Name = "button_ResetStatisticsForAllJobs";
            this.button_ResetStatisticsForAllJobs.Size = new System.Drawing.Size(168, 21);
            this.button_ResetStatisticsForAllJobs.TabIndex = 40;
            this.button_ResetStatisticsForAllJobs.Text = "Reset Statistics For All Jobs";
            this.button_ResetStatisticsForAllJobs.Click += new System.EventHandler(this.button_ResetStatisticsForAllJobs_Click);
            // 
            // groupBox_JobResults
            // 
            this.groupBox_JobResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_JobResults.Controls.Add(this.label_JobResults_Percent);
            this.groupBox_JobResults.Controls.Add(this.textBox_JobN_TotalAccept_Percent);
            this.groupBox_JobResults.Controls.Add(this.textBox_JobN_TotalWarning);
            this.groupBox_JobResults.Controls.Add(this.textBox_JobN_TotalError);
            this.groupBox_JobResults.Controls.Add(this.label_JobResults_Error);
            this.groupBox_JobResults.Controls.Add(this.label_JobResults_Warning);
            this.groupBox_JobResults.Controls.Add(this.textBox_JobN_TotalReject);
            this.groupBox_JobResults.Controls.Add(this.label_JobResults_Reject);
            this.groupBox_JobResults.Controls.Add(this.textBox_JobN_TotalAccept);
            this.groupBox_JobResults.Controls.Add(this.label_JobResults_Accept);
            this.groupBox_JobResults.Controls.Add(this.textBox_JobN_TotalIterations);
            this.groupBox_JobResults.Controls.Add(this.label_JobResults_TotalIterations);
            this.groupBox_JobResults.Location = new System.Drawing.Point(22, 7);
            this.groupBox_JobResults.Name = "groupBox_JobResults";
            this.groupBox_JobResults.Size = new System.Drawing.Size(423, 133);
            this.groupBox_JobResults.TabIndex = 37;
            this.groupBox_JobResults.TabStop = false;
            this.groupBox_JobResults.Text = "Job Results";
            // 
            // label_JobResults_Percent
            // 
            this.label_JobResults_Percent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_JobResults_Percent.Location = new System.Drawing.Point(375, 47);
            this.label_JobResults_Percent.Name = "label_JobResults_Percent";
            this.label_JobResults_Percent.Size = new System.Drawing.Size(34, 15);
            this.label_JobResults_Percent.TabIndex = 40;
            this.label_JobResults_Percent.Text = "%";
            // 
            // textBox_JobN_TotalAccept_Percent
            // 
            this.textBox_JobN_TotalAccept_Percent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_JobN_TotalAccept_Percent.Location = new System.Drawing.Point(323, 44);
            this.textBox_JobN_TotalAccept_Percent.Name = "textBox_JobN_TotalAccept_Percent";
            this.textBox_JobN_TotalAccept_Percent.ReadOnly = true;
            this.textBox_JobN_TotalAccept_Percent.Size = new System.Drawing.Size(52, 21);
            this.textBox_JobN_TotalAccept_Percent.TabIndex = 39;
            this.textBox_JobN_TotalAccept_Percent.Text = "textBox1";
            this.textBox_JobN_TotalAccept_Percent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_JobN_TotalWarning
            // 
            this.textBox_JobN_TotalWarning.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_JobN_TotalWarning.Location = new System.Drawing.Point(207, 89);
            this.textBox_JobN_TotalWarning.Name = "textBox_JobN_TotalWarning";
            this.textBox_JobN_TotalWarning.ReadOnly = true;
            this.textBox_JobN_TotalWarning.Size = new System.Drawing.Size(100, 21);
            this.textBox_JobN_TotalWarning.TabIndex = 38;
            this.textBox_JobN_TotalWarning.Text = "textBox4";
            this.textBox_JobN_TotalWarning.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_JobN_TotalError
            // 
            this.textBox_JobN_TotalError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_JobN_TotalError.Location = new System.Drawing.Point(207, 111);
            this.textBox_JobN_TotalError.Name = "textBox_JobN_TotalError";
            this.textBox_JobN_TotalError.ReadOnly = true;
            this.textBox_JobN_TotalError.Size = new System.Drawing.Size(100, 21);
            this.textBox_JobN_TotalError.TabIndex = 36;
            this.textBox_JobN_TotalError.Text = "textBox3";
            this.textBox_JobN_TotalError.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_JobResults_Error
            // 
            this.label_JobResults_Error.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_JobResults_Error.Location = new System.Drawing.Point(54, 113);
            this.label_JobResults_Error.Name = "label_JobResults_Error";
            this.label_JobResults_Error.Size = new System.Drawing.Size(148, 15);
            this.label_JobResults_Error.TabIndex = 35;
            this.label_JobResults_Error.Text = "Error:";
            // 
            // label_JobResults_Warning
            // 
            this.label_JobResults_Warning.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_JobResults_Warning.Location = new System.Drawing.Point(54, 90);
            this.label_JobResults_Warning.Name = "label_JobResults_Warning";
            this.label_JobResults_Warning.Size = new System.Drawing.Size(148, 15);
            this.label_JobResults_Warning.TabIndex = 34;
            this.label_JobResults_Warning.Text = "Warning:";
            // 
            // textBox_JobN_TotalReject
            // 
            this.textBox_JobN_TotalReject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_JobN_TotalReject.Location = new System.Drawing.Point(207, 66);
            this.textBox_JobN_TotalReject.Name = "textBox_JobN_TotalReject";
            this.textBox_JobN_TotalReject.ReadOnly = true;
            this.textBox_JobN_TotalReject.Size = new System.Drawing.Size(100, 21);
            this.textBox_JobN_TotalReject.TabIndex = 33;
            this.textBox_JobN_TotalReject.Text = "textBox2";
            this.textBox_JobN_TotalReject.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_JobResults_Reject
            // 
            this.label_JobResults_Reject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_JobResults_Reject.Location = new System.Drawing.Point(54, 68);
            this.label_JobResults_Reject.Name = "label_JobResults_Reject";
            this.label_JobResults_Reject.Size = new System.Drawing.Size(148, 15);
            this.label_JobResults_Reject.TabIndex = 31;
            this.label_JobResults_Reject.Text = "Reject:";
            // 
            // textBox_JobN_TotalAccept
            // 
            this.textBox_JobN_TotalAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_JobN_TotalAccept.Location = new System.Drawing.Point(207, 44);
            this.textBox_JobN_TotalAccept.Name = "textBox_JobN_TotalAccept";
            this.textBox_JobN_TotalAccept.ReadOnly = true;
            this.textBox_JobN_TotalAccept.Size = new System.Drawing.Size(100, 21);
            this.textBox_JobN_TotalAccept.TabIndex = 29;
            this.textBox_JobN_TotalAccept.Text = "textBox1";
            this.textBox_JobN_TotalAccept.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_JobResults_Accept
            // 
            this.label_JobResults_Accept.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_JobResults_Accept.Location = new System.Drawing.Point(54, 46);
            this.label_JobResults_Accept.Name = "label_JobResults_Accept";
            this.label_JobResults_Accept.Size = new System.Drawing.Size(148, 15);
            this.label_JobResults_Accept.TabIndex = 28;
            this.label_JobResults_Accept.Text = "Accept:";
            // 
            // textBox_JobN_TotalIterations
            // 
            this.textBox_JobN_TotalIterations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_JobN_TotalIterations.Location = new System.Drawing.Point(207, 22);
            this.textBox_JobN_TotalIterations.Name = "textBox_JobN_TotalIterations";
            this.textBox_JobN_TotalIterations.ReadOnly = true;
            this.textBox_JobN_TotalIterations.Size = new System.Drawing.Size(100, 21);
            this.textBox_JobN_TotalIterations.TabIndex = 26;
            this.textBox_JobN_TotalIterations.Text = "textBox1";
            this.textBox_JobN_TotalIterations.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_JobResults_TotalIterations
            // 
            this.label_JobResults_TotalIterations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_JobResults_TotalIterations.Location = new System.Drawing.Point(24, 24);
            this.label_JobResults_TotalIterations.Name = "label_JobResults_TotalIterations";
            this.label_JobResults_TotalIterations.Size = new System.Drawing.Size(176, 15);
            this.label_JobResults_TotalIterations.TabIndex = 25;
            this.label_JobResults_TotalIterations.Text = "Total Iterations:";
            // 
            // pictureBox_Logo
            // 
            this.pictureBox_Logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Logo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox_Logo.Location = new System.Drawing.Point(0, 437);
            this.pictureBox_Logo.Name = "pictureBox_Logo";
            this.pictureBox_Logo.Size = new System.Drawing.Size(475, 17);
            this.pictureBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_Logo.TabIndex = 27;
            this.pictureBox_Logo.TabStop = false;
            // 
            // label_controlErrorMessage
            // 
            this.label_controlErrorMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_controlErrorMessage.Location = new System.Drawing.Point(3, 3);
            this.label_controlErrorMessage.Name = "label_controlErrorMessage";
            this.label_controlErrorMessage.Size = new System.Drawing.Size(901, 454);
            this.label_controlErrorMessage.TabIndex = 30;
            this.label_controlErrorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.label_ResultBar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.panel4.Size = new System.Drawing.Size(913, 495);
            this.panel4.TabIndex = 0;
            // 
            // label_ResultBar
            // 
            this.label_ResultBar.BackColor = System.Drawing.SystemColors.Control;
            this.label_ResultBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_ResultBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ResultBar.Location = new System.Drawing.Point(3, 5);
            this.label_ResultBar.Name = "label_ResultBar";
            this.label_ResultBar.Size = new System.Drawing.Size(907, 27);
            this.label_ResultBar.TabIndex = 25;
            this.label_ResultBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRun
            // 
            this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.Location = new System.Drawing.Point(773, 57);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(130, 35);
            this.btnRun.TabIndex = 43;
            this.btnRun.Text = "Run Once";
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // splitter1
            // 
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 148);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(913, 5);
            this.splitter1.TabIndex = 38;
            this.splitter1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 148);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(913, 495);
            this.panel3.TabIndex = 37;
            // 
            // btnRunCont
            // 
            this.btnRunCont.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRunCont.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunCont.Location = new System.Drawing.Point(772, 15);
            this.btnRunCont.Name = "btnRunCont";
            this.btnRunCont.Size = new System.Drawing.Size(130, 37);
            this.btnRunCont.TabIndex = 42;
            this.btnRunCont.Text = "Run Continuously";
            this.btnRunCont.Click += new System.EventHandler(this.btnRunCont_Click);
            // 
            // comboBox_Login
            // 
            this.comboBox_Login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_Login.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Login.Location = new System.Drawing.Point(625, 111);
            this.comboBox_Login.Name = "comboBox_Login";
            this.comboBox_Login.Size = new System.Drawing.Size(132, 24);
            this.comboBox_Login.TabIndex = 41;
            this.comboBox_Login.SelectionChangeCommitted += new System.EventHandler(this.comboBox_Login_SelectionChangeCommitted);
            // 
            // button_SaveSettings
            // 
            this.button_SaveSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_SaveSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SaveSettings.Location = new System.Drawing.Point(641, 73);
            this.button_SaveSettings.Name = "button_SaveSettings";
            this.button_SaveSettings.Size = new System.Drawing.Size(104, 28);
            this.button_SaveSettings.TabIndex = 47;
            this.button_SaveSettings.Text = "Save Settings...";
            this.button_SaveSettings.Click += new System.EventHandler(this.button_SaveSettings_Click);
            // 
            // checkBox_LiveDisplay
            // 
            this.checkBox_LiveDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_LiveDisplay.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox_LiveDisplay.Location = new System.Drawing.Point(529, 73);
            this.checkBox_LiveDisplay.Name = "checkBox_LiveDisplay";
            this.checkBox_LiveDisplay.Size = new System.Drawing.Size(104, 28);
            this.checkBox_LiveDisplay.TabIndex = 46;
            this.checkBox_LiveDisplay.Text = "Live Image";
            this.checkBox_LiveDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_LiveDisplay.CheckedChanged += new System.EventHandler(this.checkBox_LiveDisplay_CheckedChanged);
            // 
            // button_About
            // 
            this.button_About.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_About.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_About.Location = new System.Drawing.Point(529, 37);
            this.button_About.Name = "button_About";
            this.button_About.Size = new System.Drawing.Size(104, 28);
            this.button_About.TabIndex = 44;
            this.button_About.Text = "About...";
            this.button_About.Click += new System.EventHandler(this.button_About_Click);
            // 
            // groupBox_DividerLine
            // 
            this.groupBox_DividerLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_DividerLine.Location = new System.Drawing.Point(757, 9);
            this.groupBox_DividerLine.Name = "groupBox_DividerLine";
            this.groupBox_DividerLine.Size = new System.Drawing.Size(3, 88);
            this.groupBox_DividerLine.TabIndex = 48;
            this.groupBox_DividerLine.TabStop = false;
            // 
            // label_Online
            // 
            this.label_Online.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Online.AutoSize = true;
            this.label_Online.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Online.Location = new System.Drawing.Point(785, 114);
            this.label_Online.Name = "label_Online";
            this.label_Online.Size = new System.Drawing.Size(119, 15);
            this.label_Online.TabIndex = 51;
            this.label_Online.Text = "System online status";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.cogJobResultHistoryCollectionEdit1);
            this.panel2.Location = new System.Drawing.Point(9, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(499, 134);
            this.panel2.TabIndex = 50;
            // 
            // cogJobResultHistoryCollectionEdit1
            // 
            this.cogJobResultHistoryCollectionEdit1.AutoScroll = true;
            this.cogJobResultHistoryCollectionEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cogJobResultHistoryCollectionEdit1.Location = new System.Drawing.Point(0, 0);
            this.cogJobResultHistoryCollectionEdit1.Name = "cogJobResultHistoryCollectionEdit1";
            this.cogJobResultHistoryCollectionEdit1.Padding = new System.Windows.Forms.Padding(4);
            this.cogJobResultHistoryCollectionEdit1.SelectedIndex = -1;
            this.cogJobResultHistoryCollectionEdit1.SelectorControlHeight = 29;
            this.cogJobResultHistoryCollectionEdit1.Size = new System.Drawing.Size(495, 130);
            this.cogJobResultHistoryCollectionEdit1.Subject = null;
            this.cogJobResultHistoryCollectionEdit1.TabIndex = 43;
            this.cogJobResultHistoryCollectionEdit1.SelectedIndexChanged += new System.EventHandler(this.cogJobResultHistoryCollectionEdit1_SelectedJobIndexChanged);
            // 
            // label_Login
            // 
            this.label_Login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Login.Location = new System.Drawing.Point(519, 114);
            this.label_Login.Name = "label_Login";
            this.label_Login.Size = new System.Drawing.Size(106, 19);
            this.label_Login.TabIndex = 49;
            this.label_Login.Text = "Current login:";
            // 
            // button_Configuration
            // 
            this.button_Configuration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Configuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Configuration.Location = new System.Drawing.Point(641, 37);
            this.button_Configuration.Name = "button_Configuration";
            this.button_Configuration.Size = new System.Drawing.Size(104, 28);
            this.button_Configuration.TabIndex = 45;
            this.button_Configuration.Text = "Configuration...";
            this.button_Configuration.Click += new System.EventHandler(this.button_Configuration_Click);
            // 
            // applicationErrorProvider
            // 
            this.applicationErrorProvider.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_Chose);
            this.panel1.Controls.Add(this.label_Online);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label_Login);
            this.panel1.Controls.Add(this.comboBox_Login);
            this.panel1.Controls.Add(this.button_SaveSettings);
            this.panel1.Controls.Add(this.checkBox_LiveDisplay);
            this.panel1.Controls.Add(this.button_About);
            this.panel1.Controls.Add(this.groupBox_DividerLine);
            this.panel1.Controls.Add(this.button_Configuration);
            this.panel1.Controls.Add(this.btnRunCont);
            this.panel1.Controls.Add(this.btnRun);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(913, 148);
            this.panel1.TabIndex = 36;
            // 
            // button_Chose
            // 
            this.button_Chose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Chose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Chose.Location = new System.Drawing.Point(529, 2);
            this.button_Chose.Name = "button_Chose";
            this.button_Chose.Size = new System.Drawing.Size(104, 28);
            this.button_Chose.TabIndex = 52;
            this.button_Chose.Text = "Chose Vpp";
            this.button_Chose.Click += new System.EventHandler(this.button_Chose_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(467, 411);
            this.dataGridView1.TabIndex = 0;
            // 
            // VisionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "VisionControl";
            this.Size = new System.Drawing.Size(913, 643);
            this.Load += new System.EventHandler(this.VisionControl_Load);
            this.tabPage_Job0_CogJob1.ResumeLayout(false);
            this.groupBox_AcquisitionResults.ResumeLayout(false);
            this.groupBox_AcquisitionResults.PerformLayout();
            this.groupBox_JobThroughput.ResumeLayout(false);
            this.groupBox_JobThroughput.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.tabControl_JobTabs.ResumeLayout(false);
            this.tabPage_JobN_JobStatistics.ResumeLayout(false);
            this.groupBox_JobResults.ResumeLayout(false);
            this.groupBox_JobResults.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.applicationErrorProvider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    ///////////////////////// START WIZARD GENERATED
    // cognex.wizard.controldeclarations.begin
    private TabPage tabPage_Job0_CogJob1;
    // cognex.wizard.controldeclarations.end
    ///////////////////////// END WIZARD GENERATED

    private System.Windows.Forms.Label label_AcquisitionResults_Overruns;
    private System.Windows.Forms.TextBox textBox_JobN_TotalAcquisitionErrors;
    private System.Windows.Forms.TextBox textBox_JobN_TotalAcquisitionOverruns;
    private System.Windows.Forms.GroupBox groupBox_AcquisitionResults;
    private System.Windows.Forms.Label label_AcquisitionResults_Errors;
    private System.Windows.Forms.TextBox textBox_JobN_TotalAcquisitions;
    private System.Windows.Forms.Label label_AcquisitionResults_TotalAcquisitions;
    private System.Windows.Forms.Label label_JobThroughput_persec;
    private System.Windows.Forms.GroupBox groupBox_JobThroughput;
    private System.Windows.Forms.TextBox textBox_JobN_MaxThroughput;
    private System.Windows.Forms.TextBox textBox_JobN_MinThroughput;
    private System.Windows.Forms.Label label_JobThroughput_Max;
    private System.Windows.Forms.Label label_JobThroughput_Min;
    private System.Windows.Forms.TextBox textBox_JobN_Throughput;
    private System.Windows.Forms.Label label_JobThroughput_TotalThroughput;
    private System.Windows.Forms.Panel panel5;
    private System.Windows.Forms.Splitter splitter2;
    private System.Windows.Forms.Panel panel6;
    private System.Windows.Forms.TabControl tabControl_JobTabs;
    private System.Windows.Forms.TabPage tabPage_JobN_JobStatistics;
    private System.Windows.Forms.Button button_ResetStatistics;
    private System.Windows.Forms.Button button_ResetStatisticsForAllJobs;
    private System.Windows.Forms.GroupBox groupBox_JobResults;
    private System.Windows.Forms.Label label_JobResults_Percent;
    private System.Windows.Forms.TextBox textBox_JobN_TotalAccept_Percent;
    private System.Windows.Forms.TextBox textBox_JobN_TotalWarning;
    private System.Windows.Forms.TextBox textBox_JobN_TotalError;
    private System.Windows.Forms.Label label_JobResults_Error;
    private System.Windows.Forms.Label label_JobResults_Warning;
    private System.Windows.Forms.TextBox textBox_JobN_TotalReject;
    private System.Windows.Forms.Label label_JobResults_Reject;
    private System.Windows.Forms.TextBox textBox_JobN_TotalAccept;
    private System.Windows.Forms.Label label_JobResults_Accept;
    private System.Windows.Forms.TextBox textBox_JobN_TotalIterations;
    private System.Windows.Forms.Label label_JobResults_TotalIterations;

    private System.Windows.Forms.PictureBox pictureBox_Logo;
    private System.Windows.Forms.Panel panel4;
    private System.Windows.Forms.Label label_ResultBar;
    private System.Windows.Forms.Button btnRun;
    private System.Windows.Forms.Splitter splitter1;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.Button btnRunCont;
    private System.Windows.Forms.ComboBox comboBox_Login;
    private System.Windows.Forms.Button button_SaveSettings;
    private System.Windows.Forms.CheckBox checkBox_LiveDisplay;
    private System.Windows.Forms.Button button_About;
    private System.Windows.Forms.GroupBox groupBox_DividerLine;
    private System.Windows.Forms.Label label_Online;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Label label_Login;
    private System.Windows.Forms.Button button_Configuration;
    private System.Windows.Forms.ErrorProvider applicationErrorProvider;
    private System.Windows.Forms.Panel panel1;
    private Cognex.VisionPro.CogRecordsDisplay cogRecordsDisplay1;
    private Cognex.VisionPro.QuickBuild.CogJobResultHistoryCollectionEdit cogJobResultHistoryCollectionEdit1;
    private System.Windows.Forms.Label label_controlErrorMessage;
        private Button button_Chose;
        private DataGridView dataGridView1;
    }
}
