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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox_Result = new System.Windows.Forms.RichTextBox();
            this.linkLabel_DeleteConfig = new System.Windows.Forms.LinkLabel();
            this.label_OutputVal = new System.Windows.Forms.Label();
            this.label_InputVal = new System.Windows.Forms.Label();
            this.linkLabel_AddConfig = new System.Windows.Forms.LinkLabel();
            this.linkLabel_OpenConfig = new System.Windows.Forms.LinkLabel();
            this.comboBox_Config = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_RepAll = new System.Windows.Forms.Button();
            this.button_Output = new System.Windows.Forms.Button();
            this.button_Input = new System.Windows.Forms.Button();
            this.textBox_Output = new System.Windows.Forms.TextBox();
            this.textBox_Input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog_Input = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog_InputFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.label_CurDir = new System.Windows.Forms.LinkLabel();
            this.button_ResetIni = new System.Windows.Forms.Button();
            this.folderBrowserDialog_OutputFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.toolTip_Info = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_Warning = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox_Result);
            this.groupBox1.Controls.Add(this.linkLabel_DeleteConfig);
            this.groupBox1.Controls.Add(this.label_OutputVal);
            this.groupBox1.Controls.Add(this.label_InputVal);
            this.groupBox1.Controls.Add(this.linkLabel_AddConfig);
            this.groupBox1.Controls.Add(this.linkLabel_OpenConfig);
            this.groupBox1.Controls.Add(this.comboBox_Config);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button_RepAll);
            this.groupBox1.Controls.Add(this.button_Output);
            this.groupBox1.Controls.Add(this.button_Input);
            this.groupBox1.Controls.Add(this.textBox_Output);
            this.groupBox1.Controls.Add(this.textBox_Input);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(785, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // richTextBox_Result
            // 
            this.richTextBox_Result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.richTextBox_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_Result.ForeColor = System.Drawing.Color.Black;
            this.richTextBox_Result.Location = new System.Drawing.Point(9, 164);
            this.richTextBox_Result.Name = "richTextBox_Result";
            this.richTextBox_Result.ReadOnly = true;
            this.richTextBox_Result.Size = new System.Drawing.Size(770, 256);
            this.richTextBox_Result.TabIndex = 11;
            this.richTextBox_Result.TabStop = false;
            this.richTextBox_Result.Text = "";
            this.toolTip_Info.SetToolTip(this.richTextBox_Result, "Result will be listed here simultaneos to the process");
            // 
            // linkLabel_DeleteConfig
            // 
            this.linkLabel_DeleteConfig.AutoSize = true;
            this.linkLabel_DeleteConfig.LinkColor = System.Drawing.Color.Red;
            this.linkLabel_DeleteConfig.Location = new System.Drawing.Point(491, 128);
            this.linkLabel_DeleteConfig.Name = "linkLabel_DeleteConfig";
            this.linkLabel_DeleteConfig.Size = new System.Drawing.Size(47, 16);
            this.linkLabel_DeleteConfig.TabIndex = 9;
            this.linkLabel_DeleteConfig.TabStop = true;
            this.linkLabel_DeleteConfig.Text = "Delete";
            this.toolTip_Warning.SetToolTip(this.linkLabel_DeleteConfig, "Deletes the selected config file");
            this.linkLabel_DeleteConfig.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_DeleteConfig_LinkClicked);
            // 
            // label_OutputVal
            // 
            this.label_OutputVal.AutoSize = true;
            this.label_OutputVal.ForeColor = System.Drawing.Color.Red;
            this.label_OutputVal.Location = new System.Drawing.Point(159, 99);
            this.label_OutputVal.Name = "label_OutputVal";
            this.label_OutputVal.Size = new System.Drawing.Size(108, 16);
            this.label_OutputVal.TabIndex = 14;
            this.label_OutputVal.Text = "Output Validation";
            // 
            // label_InputVal
            // 
            this.label_InputVal.AutoSize = true;
            this.label_InputVal.ForeColor = System.Drawing.Color.Red;
            this.label_InputVal.Location = new System.Drawing.Point(159, 53);
            this.label_InputVal.Name = "label_InputVal";
            this.label_InputVal.Size = new System.Drawing.Size(98, 16);
            this.label_InputVal.TabIndex = 13;
            this.label_InputVal.Text = "Input Validation";
            // 
            // linkLabel_AddConfig
            // 
            this.linkLabel_AddConfig.AutoSize = true;
            this.linkLabel_AddConfig.LinkColor = System.Drawing.Color.Black;
            this.linkLabel_AddConfig.Location = new System.Drawing.Point(454, 128);
            this.linkLabel_AddConfig.Name = "linkLabel_AddConfig";
            this.linkLabel_AddConfig.Size = new System.Drawing.Size(32, 16);
            this.linkLabel_AddConfig.TabIndex = 8;
            this.linkLabel_AddConfig.TabStop = true;
            this.linkLabel_AddConfig.Text = "Add";
            this.toolTip_Info.SetToolTip(this.linkLabel_AddConfig, "Creates a new config in current typed/available name");
            this.linkLabel_AddConfig.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_AddConfig_LinkClicked);
            // 
            // linkLabel_OpenConfig
            // 
            this.linkLabel_OpenConfig.AutoSize = true;
            this.linkLabel_OpenConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_OpenConfig.LinkColor = System.Drawing.Color.Black;
            this.linkLabel_OpenConfig.Location = new System.Drawing.Point(411, 128);
            this.linkLabel_OpenConfig.Name = "linkLabel_OpenConfig";
            this.linkLabel_OpenConfig.Size = new System.Drawing.Size(40, 16);
            this.linkLabel_OpenConfig.TabIndex = 7;
            this.linkLabel_OpenConfig.TabStop = true;
            this.linkLabel_OpenConfig.Text = "Open";
            this.toolTip_Info.SetToolTip(this.linkLabel_OpenConfig, "Opens the selected config file in editor");
            this.linkLabel_OpenConfig.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_OpenConfig_LinkClicked);
            // 
            // comboBox_Config
            // 
            this.comboBox_Config.FormattingEnabled = true;
            this.comboBox_Config.Location = new System.Drawing.Point(161, 123);
            this.comboBox_Config.Name = "comboBox_Config";
            this.comboBox_Config.Size = new System.Drawing.Size(243, 24);
            this.comboBox_Config.TabIndex = 3;
            this.toolTip_Info.SetToolTip(this.comboBox_Config, "Select any one config file");
            this.comboBox_Config.SelectedIndexChanged += new System.EventHandler(this.comboBox_Config_SelectedIndexChanged);
            this.comboBox_Config.TextUpdate += new System.EventHandler(this.comboBox_Config_TextUpdate);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Select Config File:";
            // 
            // button_RepAll
            // 
            this.button_RepAll.BackColor = System.Drawing.Color.HotPink;
            this.button_RepAll.Location = new System.Drawing.Point(671, 119);
            this.button_RepAll.Name = "button_RepAll";
            this.button_RepAll.Size = new System.Drawing.Size(108, 35);
            this.button_RepAll.TabIndex = 4;
            this.button_RepAll.Text = "Replace All";
            this.toolTip_Info.SetToolTip(this.button_RepAll, "Click to start batch replacement");
            this.button_RepAll.UseVisualStyleBackColor = false;
            this.button_RepAll.Click += new System.EventHandler(this.button_RepAll_Click);
            this.button_RepAll.MouseEnter += new System.EventHandler(this.button_RepAll_MouseEnter);
            this.button_RepAll.MouseLeave += new System.EventHandler(this.button_RepAll_MouseLeave);
            // 
            // button_Output
            // 
            this.button_Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Output.Location = new System.Drawing.Point(731, 70);
            this.button_Output.Name = "button_Output";
            this.button_Output.Size = new System.Drawing.Size(48, 31);
            this.button_Output.TabIndex = 6;
            this.button_Output.Text = "•••";
            this.toolTip_Info.SetToolTip(this.button_Output, "Click to select output directory");
            this.button_Output.UseVisualStyleBackColor = true;
            this.button_Output.Click += new System.EventHandler(this.button_Output_Click);
            // 
            // button_Input
            // 
            this.button_Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Input.Location = new System.Drawing.Point(731, 26);
            this.button_Input.Name = "button_Input";
            this.button_Input.Size = new System.Drawing.Size(48, 31);
            this.button_Input.TabIndex = 5;
            this.button_Input.Text = "•••";
            this.toolTip_Info.SetToolTip(this.button_Input, "Click/Left Click to select a single file\r\nRight Click to select a directory");
            this.button_Input.UseVisualStyleBackColor = true;
            this.button_Input.Click += new System.EventHandler(this.button_Input_Click);
            this.button_Input.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_Input_MouseDown);
            // 
            // textBox_Output
            // 
            this.textBox_Output.Location = new System.Drawing.Point(161, 73);
            this.textBox_Output.Name = "textBox_Output";
            this.textBox_Output.Size = new System.Drawing.Size(564, 22);
            this.textBox_Output.TabIndex = 2;
            this.toolTip_Info.SetToolTip(this.textBox_Output, "Output directory path");
            this.textBox_Output.TextChanged += new System.EventHandler(this.textBox_Output_TextChanged);
            // 
            // textBox_Input
            // 
            this.textBox_Input.Location = new System.Drawing.Point(161, 28);
            this.textBox_Input.Name = "textBox_Input";
            this.textBox_Input.Size = new System.Drawing.Size(564, 22);
            this.textBox_Input.TabIndex = 1;
            this.toolTip_Info.SetToolTip(this.textBox_Input, "Input file/folder path");
            this.textBox_Input.TextChanged += new System.EventHandler(this.textBox_Input_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Output Folder Path:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "File/Folder Path:";
            // 
            // openFileDialog_Input
            // 
            this.openFileDialog_Input.DefaultExt = "xml";
            this.openFileDialog_Input.FileName = "*.xml";
            this.openFileDialog_Input.Filter = "XML Document (.xml )| *.xml";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 441);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Working Directory:";
            // 
            // label_CurDir
            // 
            this.label_CurDir.AutoSize = true;
            this.label_CurDir.LinkColor = System.Drawing.Color.DarkViolet;
            this.label_CurDir.Location = new System.Drawing.Point(141, 441);
            this.label_CurDir.Name = "label_CurDir";
            this.label_CurDir.Size = new System.Drawing.Size(106, 16);
            this.label_CurDir.TabIndex = 10;
            this.label_CurDir.TabStop = true;
            this.label_CurDir.Text = "Current Directory";
            this.toolTip_Info.SetToolTip(this.label_CurDir, "Click to open the config directory");
            this.label_CurDir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.label_CurDir_LinkClicked);
            // 
            // button_ResetIni
            // 
            this.button_ResetIni.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_ResetIni.BackgroundImage")));
            this.button_ResetIni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_ResetIni.Location = new System.Drawing.Point(756, 5);
            this.button_ResetIni.Name = "button_ResetIni";
            this.button_ResetIni.Size = new System.Drawing.Size(33, 28);
            this.button_ResetIni.TabIndex = 11;
            this.toolTip_Warning.SetToolTip(this.button_ResetIni, "Click to reset the complete configuation to initial stage");
            this.button_ResetIni.UseVisualStyleBackColor = true;
            this.button_ResetIni.Click += new System.EventHandler(this.button_ResetIni_Click);
            // 
            // toolTip_Info
            // 
            this.toolTip_Info.BackColor = System.Drawing.SystemColors.MenuText;
            this.toolTip_Info.ForeColor = System.Drawing.Color.Fuchsia;
            this.toolTip_Info.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_Info.ToolTipTitle = "Helpful Info";
            // 
            // toolTip_Warning
            // 
            this.toolTip_Warning.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.toolTip_Warning.ToolTipTitle = "Warning!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(809, 466);
            this.Controls.Add(this.button_ResetIni);
            this.Controls.Add(this.label_CurDir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Magical Swapper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Output;
        private System.Windows.Forms.Button button_Input;
        private System.Windows.Forms.TextBox textBox_Output;
        private System.Windows.Forms.TextBox textBox_Input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog_Input;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_InputFolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_RepAll;
        private System.Windows.Forms.LinkLabel linkLabel_AddConfig;
        private System.Windows.Forms.LinkLabel linkLabel_OpenConfig;
        private System.Windows.Forms.ComboBox comboBox_Config;
        private System.Windows.Forms.Label label_OutputVal;
        private System.Windows.Forms.Label label_InputVal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel label_CurDir;
        private System.Windows.Forms.LinkLabel linkLabel_DeleteConfig;
        private System.Windows.Forms.Button button_ResetIni;
        private System.Windows.Forms.RichTextBox richTextBox_Result;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_OutputFolder;
        private System.Windows.Forms.ToolTip toolTip_Info;
        private System.Windows.Forms.ToolTip toolTip_Warning;
    }
}

