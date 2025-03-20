namespace ConfigXMLEditor
{
    partial class Form1
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
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog_Input = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog_InputFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog_OutputFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.toolTip_Info = new System.Windows.Forms.ToolTip(this.components);
            this.linkLabel_CurDir = new System.Windows.Forms.LinkLabel();
            this.textBox_Input = new System.Windows.Forms.TextBox();
            this.textBox_Output = new System.Windows.Forms.TextBox();
            this.button_Input = new System.Windows.Forms.Button();
            this.button_Output = new System.Windows.Forms.Button();
            this.comboBox_Config = new System.Windows.Forms.ComboBox();
            this.linkLabel_OpenConfig = new System.Windows.Forms.LinkLabel();
            this.linkLabel_AddConfig = new System.Windows.Forms.LinkLabel();
            this.richTextBox_Result = new System.Windows.Forms.RichTextBox();
            this.button_RepAll = new System.Windows.Forms.Button();
            this.toolTip_Warning = new System.Windows.Forms.ToolTip(this.components);
            this.linkLabel_DeleteConfig = new System.Windows.Forms.LinkLabel();
            this.button_ResetIni = new System.Windows.Forms.Button();
            this.label_cdir = new System.Windows.Forms.Label();
            this.label_input = new System.Windows.Forms.Label();
            this.label_output = new System.Windows.Forms.Label();
            this.label_combo = new System.Windows.Forms.Label();
            this.label_InputVal = new System.Windows.Forms.Label();
            this.label_OutputVal = new System.Windows.Forms.Label();
            this.comboBox_RegEx = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_RexEx = new System.Windows.Forms.Label();
            this.label_resetConfig = new System.Windows.Forms.Label();
            this.button_RichVisibility = new System.Windows.Forms.Button();
            this.label_EditorTrigger = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog_Input
            // 
            this.openFileDialog_Input.DefaultExt = "xml";
            this.openFileDialog_Input.FileName = "*.xml";
            this.openFileDialog_Input.Filter = "XML Document (.xml )| *.xml";
            // 
            // toolTip_Info
            // 
            this.toolTip_Info.BackColor = System.Drawing.SystemColors.MenuText;
            this.toolTip_Info.ForeColor = System.Drawing.Color.Fuchsia;
            this.toolTip_Info.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_Info.ToolTipTitle = "Helpful Info";
            // 
            // linkLabel_CurDir
            // 
            this.linkLabel_CurDir.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.linkLabel_CurDir.AutoSize = true;
            this.linkLabel_CurDir.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.linkLabel_CurDir.Location = new System.Drawing.Point(153, 470);
            this.linkLabel_CurDir.Name = "linkLabel_CurDir";
            this.linkLabel_CurDir.Size = new System.Drawing.Size(106, 16);
            this.linkLabel_CurDir.TabIndex = 10;
            this.linkLabel_CurDir.TabStop = true;
            this.linkLabel_CurDir.Text = "Current Directory";
            this.toolTip_Info.SetToolTip(this.linkLabel_CurDir, "Click to open the config directory");
            this.linkLabel_CurDir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_CurDir_LinkClicked);
            // 
            // textBox_Input
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBox_Input, 6);
            this.textBox_Input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Input.Location = new System.Drawing.Point(153, 18);
            this.textBox_Input.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.textBox_Input.Name = "textBox_Input";
            this.textBox_Input.Size = new System.Drawing.Size(537, 22);
            this.textBox_Input.TabIndex = 1;
            this.toolTip_Info.SetToolTip(this.textBox_Input, "Input file/folder path");
            this.textBox_Input.TextChanged += new System.EventHandler(this.textBox_Input_TextChanged);
            this.textBox_Input.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Input_KeyUp);
            // 
            // textBox_Output
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBox_Output, 6);
            this.textBox_Output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Output.Location = new System.Drawing.Point(153, 78);
            this.textBox_Output.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.textBox_Output.Name = "textBox_Output";
            this.textBox_Output.Size = new System.Drawing.Size(537, 22);
            this.textBox_Output.TabIndex = 2;
            this.toolTip_Info.SetToolTip(this.textBox_Output, "Output directory path");
            this.textBox_Output.TextChanged += new System.EventHandler(this.textBox_Output_TextChanged);
            // 
            // button_Input
            // 
            this.button_Input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Input.Location = new System.Drawing.Point(696, 13);
            this.button_Input.Name = "button_Input";
            this.button_Input.Size = new System.Drawing.Size(132, 34);
            this.button_Input.TabIndex = 5;
            this.button_Input.Text = "•••";
            this.toolTip_Info.SetToolTip(this.button_Input, "Click/Left Click to select a single file\r\nRight Click to select a directory");
            this.button_Input.UseVisualStyleBackColor = true;
            this.button_Input.Click += new System.EventHandler(this.button_Input_Click);
            this.button_Input.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_Input_MouseDown);
            // 
            // button_Output
            // 
            this.button_Output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Output.Location = new System.Drawing.Point(696, 73);
            this.button_Output.Name = "button_Output";
            this.button_Output.Size = new System.Drawing.Size(132, 34);
            this.button_Output.TabIndex = 6;
            this.button_Output.Text = "•••";
            this.toolTip_Info.SetToolTip(this.button_Output, "Click to select output directory");
            this.button_Output.UseVisualStyleBackColor = true;
            this.button_Output.Click += new System.EventHandler(this.button_Output_Click);
            // 
            // comboBox_Config
            // 
            this.comboBox_Config.BackColor = System.Drawing.Color.PaleTurquoise;
            this.comboBox_Config.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_Config.FormattingEnabled = true;
            this.comboBox_Config.Location = new System.Drawing.Point(153, 138);
            this.comboBox_Config.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.comboBox_Config.Name = "comboBox_Config";
            this.comboBox_Config.Size = new System.Drawing.Size(182, 24);
            this.comboBox_Config.TabIndex = 3;
            this.toolTip_Info.SetToolTip(this.comboBox_Config, "Select any one config file");
            // 
            // linkLabel_OpenConfig
            // 
            this.linkLabel_OpenConfig.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.linkLabel_OpenConfig.AutoSize = true;
            this.linkLabel_OpenConfig.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.linkLabel_OpenConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_OpenConfig.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.linkLabel_OpenConfig.Location = new System.Drawing.Point(343, 142);
            this.linkLabel_OpenConfig.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.linkLabel_OpenConfig.Name = "linkLabel_OpenConfig";
            this.linkLabel_OpenConfig.Size = new System.Drawing.Size(40, 16);
            this.linkLabel_OpenConfig.TabIndex = 7;
            this.linkLabel_OpenConfig.TabStop = true;
            this.linkLabel_OpenConfig.Text = "Open";
            this.toolTip_Info.SetToolTip(this.linkLabel_OpenConfig, "Opens the selected config file in editor");
            this.linkLabel_OpenConfig.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_OpenConfig_LinkClicked);
            // 
            // linkLabel_AddConfig
            // 
            this.linkLabel_AddConfig.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.linkLabel_AddConfig.AutoSize = true;
            this.linkLabel_AddConfig.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.linkLabel_AddConfig.ForeColor = System.Drawing.SystemColors.ControlText;
            this.linkLabel_AddConfig.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.linkLabel_AddConfig.Location = new System.Drawing.Point(397, 142);
            this.linkLabel_AddConfig.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.linkLabel_AddConfig.Name = "linkLabel_AddConfig";
            this.linkLabel_AddConfig.Size = new System.Drawing.Size(32, 16);
            this.linkLabel_AddConfig.TabIndex = 8;
            this.linkLabel_AddConfig.TabStop = true;
            this.linkLabel_AddConfig.Text = "Add";
            this.toolTip_Info.SetToolTip(this.linkLabel_AddConfig, "Creates a new config in current typed/available name");
            this.linkLabel_AddConfig.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_AddConfig_LinkClicked);
            // 
            // richTextBox_Result
            // 
            this.richTextBox_Result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel1.SetColumnSpan(this.richTextBox_Result, 8);
            this.richTextBox_Result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_Result.ForeColor = System.Drawing.Color.Black;
            this.richTextBox_Result.Location = new System.Drawing.Point(13, 173);
            this.richTextBox_Result.Name = "richTextBox_Result";
            this.richTextBox_Result.ReadOnly = true;
            this.richTextBox_Result.Size = new System.Drawing.Size(815, 285);
            this.richTextBox_Result.TabIndex = 11;
            this.richTextBox_Result.TabStop = false;
            this.richTextBox_Result.Text = "";
            this.toolTip_Info.SetToolTip(this.richTextBox_Result, "Result will be listed here simultaneos to the process");
            // 
            // button_RepAll
            // 
            this.button_RepAll.BackColor = System.Drawing.Color.HotPink;
            this.button_RepAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_RepAll.Location = new System.Drawing.Point(696, 133);
            this.button_RepAll.Name = "button_RepAll";
            this.button_RepAll.Size = new System.Drawing.Size(132, 34);
            this.button_RepAll.TabIndex = 4;
            this.button_RepAll.Text = "Replace All";
            this.toolTip_Info.SetToolTip(this.button_RepAll, "Click to start batch replacement");
            this.button_RepAll.UseVisualStyleBackColor = false;
            this.button_RepAll.Click += new System.EventHandler(this.button_RepAll_Click);
            this.button_RepAll.MouseEnter += new System.EventHandler(this.button_RepAll_MouseEnter);
            this.button_RepAll.MouseLeave += new System.EventHandler(this.button_RepAll_MouseLeave);
            // 
            // toolTip_Warning
            // 
            this.toolTip_Warning.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.toolTip_Warning.ToolTipTitle = "Warning!";
            // 
            // linkLabel_DeleteConfig
            // 
            this.linkLabel_DeleteConfig.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.linkLabel_DeleteConfig.AutoSize = true;
            this.linkLabel_DeleteConfig.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.linkLabel_DeleteConfig.LinkColor = System.Drawing.Color.Red;
            this.linkLabel_DeleteConfig.Location = new System.Drawing.Point(443, 142);
            this.linkLabel_DeleteConfig.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.linkLabel_DeleteConfig.Name = "linkLabel_DeleteConfig";
            this.linkLabel_DeleteConfig.Size = new System.Drawing.Size(47, 16);
            this.linkLabel_DeleteConfig.TabIndex = 9;
            this.linkLabel_DeleteConfig.TabStop = true;
            this.linkLabel_DeleteConfig.Text = "Delete";
            this.toolTip_Warning.SetToolTip(this.linkLabel_DeleteConfig, "Deletes the selected config file");
            this.linkLabel_DeleteConfig.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_DeleteConfig_LinkClicked);
            // 
            // button_ResetIni
            // 
            this.button_ResetIni.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_ResetIni.BackgroundImage")));
            this.button_ResetIni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_ResetIni.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_ResetIni.Location = new System.Drawing.Point(782, 464);
            this.button_ResetIni.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.button_ResetIni.Name = "button_ResetIni";
            this.button_ResetIni.Size = new System.Drawing.Size(46, 29);
            this.button_ResetIni.TabIndex = 11;
            this.toolTip_Warning.SetToolTip(this.button_ResetIni, "Click to reset the complete configuation to initial stage");
            this.button_ResetIni.UseVisualStyleBackColor = true;
            this.button_ResetIni.Click += new System.EventHandler(this.button_ResetIni_Click);
            // 
            // label_cdir
            // 
            this.label_cdir.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_cdir.AutoSize = true;
            this.label_cdir.Location = new System.Drawing.Point(13, 470);
            this.label_cdir.Name = "label_cdir";
            this.label_cdir.Size = new System.Drawing.Size(117, 16);
            this.label_cdir.TabIndex = 2;
            this.label_cdir.Text = "Working Directory:";
            // 
            // label_input
            // 
            this.label_input.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_input.AutoSize = true;
            this.label_input.Location = new System.Drawing.Point(13, 22);
            this.label_input.Name = "label_input";
            this.label_input.Size = new System.Drawing.Size(105, 16);
            this.label_input.TabIndex = 0;
            this.label_input.Text = "File/Folder Path:";
            // 
            // label_output
            // 
            this.label_output.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_output.AutoSize = true;
            this.label_output.Location = new System.Drawing.Point(13, 82);
            this.label_output.Name = "label_output";
            this.label_output.Size = new System.Drawing.Size(120, 16);
            this.label_output.TabIndex = 1;
            this.label_output.Text = "Output Folder Path:";
            // 
            // label_combo
            // 
            this.label_combo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_combo.AutoSize = true;
            this.label_combo.Location = new System.Drawing.Point(13, 142);
            this.label_combo.Name = "label_combo";
            this.label_combo.Size = new System.Drawing.Size(114, 16);
            this.label_combo.TabIndex = 8;
            this.label_combo.Text = "Select Config File:";
            // 
            // label_InputVal
            // 
            this.label_InputVal.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label_InputVal, 2);
            this.label_InputVal.ForeColor = System.Drawing.Color.Red;
            this.label_InputVal.Location = new System.Drawing.Point(153, 50);
            this.label_InputVal.Name = "label_InputVal";
            this.label_InputVal.Size = new System.Drawing.Size(98, 16);
            this.label_InputVal.TabIndex = 13;
            this.label_InputVal.Text = "Input Validation";
            // 
            // label_OutputVal
            // 
            this.label_OutputVal.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label_OutputVal, 5);
            this.label_OutputVal.ForeColor = System.Drawing.Color.Red;
            this.label_OutputVal.Location = new System.Drawing.Point(153, 110);
            this.label_OutputVal.Name = "label_OutputVal";
            this.label_OutputVal.Size = new System.Drawing.Size(108, 16);
            this.label_OutputVal.TabIndex = 14;
            this.label_OutputVal.Text = "Output Validation";
            // 
            // comboBox_RegEx
            // 
            this.comboBox_RegEx.BackColor = System.Drawing.Color.PaleTurquoise;
            this.comboBox_RegEx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_RegEx.FormattingEnabled = true;
            this.comboBox_RegEx.Items.AddRange(new object[] {
            "UltraEdit",
            "Epsilon",
            "MS Word (Wildcards)",
            "Perl",
            "Visual Studio"});
            this.comboBox_RegEx.Location = new System.Drawing.Point(566, 138);
            this.comboBox_RegEx.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.comboBox_RegEx.Name = "comboBox_RegEx";
            this.comboBox_RegEx.Size = new System.Drawing.Size(124, 24);
            this.comboBox_RegEx.TabIndex = 15;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.18808F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.81192F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 137F));
            this.tableLayoutPanel1.Controls.Add(this.label_input, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_ResetIni, 7, 6);
            this.tableLayoutPanel1.Controls.Add(this.richTextBox_Result, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.linkLabel_CurDir, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.textBox_Input, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_cdir, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label_OutputVal, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label_InputVal, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_Input, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_combo, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_Config, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.linkLabel_OpenConfig, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.linkLabel_AddConfig, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.linkLabel_DeleteConfig, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.label_output, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox_Output, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button_Output, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.button_RepAll, 7, 4);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_RegEx, 6, 4);
            this.tableLayoutPanel1.Controls.Add(this.label_RexEx, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.label_resetConfig, 6, 6);
            this.tableLayoutPanel1.Controls.Add(this.button_RichVisibility, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.label_EditorTrigger, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(841, 506);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // label_RexEx
            // 
            this.label_RexEx.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_RexEx.AutoSize = true;
            this.label_RexEx.Location = new System.Drawing.Point(509, 142);
            this.label_RexEx.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.label_RexEx.Name = "label_RexEx";
            this.label_RexEx.Size = new System.Drawing.Size(51, 16);
            this.label_RexEx.TabIndex = 16;
            this.label_RexEx.Text = "RegEx:";
            // 
            // label_resetConfig
            // 
            this.label_resetConfig.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_resetConfig.AutoSize = true;
            this.label_resetConfig.Location = new System.Drawing.Point(603, 470);
            this.label_resetConfig.Name = "label_resetConfig";
            this.label_resetConfig.Size = new System.Drawing.Size(87, 16);
            this.label_resetConfig.TabIndex = 17;
            this.label_resetConfig.Text = "Reset Config:";
            // 
            // button_RichVisibility
            // 
            this.button_RichVisibility.BackgroundImage = global::ConfigXMLEditor.Properties.Resources.uparrow;
            this.button_RichVisibility.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_RichVisibility.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_RichVisibility.FlatAppearance.BorderSize = 0;
            this.button_RichVisibility.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_RichVisibility.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_RichVisibility.Location = new System.Drawing.Point(395, 464);
            this.button_RichVisibility.Name = "button_RichVisibility";
            this.button_RichVisibility.Size = new System.Drawing.Size(40, 29);
            this.button_RichVisibility.TabIndex = 18;
            this.button_RichVisibility.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_RichVisibility.UseVisualStyleBackColor = true;
            this.button_RichVisibility.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_EditorTrigger
            // 
            this.label_EditorTrigger.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label_EditorTrigger, 5);
            this.label_EditorTrigger.ForeColor = System.Drawing.Color.Yellow;
            this.label_EditorTrigger.Location = new System.Drawing.Point(395, 50);
            this.label_EditorTrigger.Name = "label_EditorTrigger";
            this.label_EditorTrigger.Size = new System.Drawing.Size(365, 16);
            this.label_EditorTrigger.TabIndex = 19;
            this.label_EditorTrigger.Text = "Right Click on input box to open folder/file in Lightening Editor";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(841, 506);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(760, 300);
            this.Name = "Form1";
            this.Text = "Magical Swapper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog_Input;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_InputFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_OutputFolder;
        private System.Windows.Forms.ToolTip toolTip_Info;
        private System.Windows.Forms.ToolTip toolTip_Warning;
        private System.Windows.Forms.Label label_cdir;
        private System.Windows.Forms.LinkLabel linkLabel_CurDir;
        private System.Windows.Forms.Button button_ResetIni;
        private System.Windows.Forms.Label label_input;
        private System.Windows.Forms.Label label_output;
        private System.Windows.Forms.TextBox textBox_Input;
        private System.Windows.Forms.TextBox textBox_Output;
        private System.Windows.Forms.Button button_Input;
        private System.Windows.Forms.Button button_Output;
        private System.Windows.Forms.Label label_combo;
        private System.Windows.Forms.ComboBox comboBox_Config;
        private System.Windows.Forms.LinkLabel linkLabel_OpenConfig;
        private System.Windows.Forms.LinkLabel linkLabel_AddConfig;
        private System.Windows.Forms.Label label_InputVal;
        private System.Windows.Forms.Label label_OutputVal;
        private System.Windows.Forms.LinkLabel linkLabel_DeleteConfig;
        private System.Windows.Forms.ComboBox comboBox_RegEx;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox richTextBox_Result;
        private System.Windows.Forms.Button button_RepAll;
        private System.Windows.Forms.Label label_RexEx;
        private System.Windows.Forms.Label label_resetConfig;
        private System.Windows.Forms.Button button_RichVisibility;
        private System.Windows.Forms.Label label_EditorTrigger;
    }
}

