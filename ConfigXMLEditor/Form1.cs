using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.XPath;

namespace ConfigXMLEditor
{
    public partial class Form1 : Form
    {
        string InputXML = "";
        string OutputXML = "";
        string setIni = "";
        string CurDir = "";
        int ConfigFile = 0;
        int inXvalid = 0;
        int outXvalid = 0;
        int chk = 0;
        string[] configs;
        XDocument setxml;
        XElement setroot;
        TextWriterTraceListener myTrace;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox_Input.Text = "D:\\in\\9780192848635_Parpworth.xml";
            textBox_Output.Text = "D:\\out";
            label_InputVal.Text = "";
            label_OutputVal.Text = "";
            InitialCheck("D");
            if(chk == 0)
            {
                InitialCheck("C");
            }
            InitializeConfig();
            ListOutConfig();
            comboBox_Config.SelectedIndex = 0;
            richTextBox_Result.Text = "Process ready to start!";
            MyTraceBox tr1 = new MyTraceBox(richTextBox_Result);
            Trace.Listeners.Add(tr1);
            myTrace = new TextWriterTraceListener(OutputXML + "Output.log");
            Trace.Listeners.Add(myTrace);

        }

        private void ListOutConfig()
        {
            comboBox_Config.Items.Clear();
            foreach (var item in setroot.XPathSelectElements("//ConfigList/config"))
            {
                comboBox_Config.Items.Add(Path.GetFileNameWithoutExtension(item.Value));
            }
        }
        private void InitializeConfig()
        {
            if (!File.Exists(CurDir + "settings.ini"))
            {
                configs = Directory.GetFiles(CurDir, "*.config");
                setxml = new XDocument();
                setxml.AddFirst(new XElement("ConfigXml", new XComment("Don't try to delete the first two default configs!")));
                setroot = setxml.Root;
                setroot.Add(new XElement("ConfigList"));
                foreach (var item in configs)
                {
                    setroot.XPathSelectElement("ConfigList").Add(new XElement("config", Path.GetFileName(item)));
                }
                setxml.Save(CurDir + "settings.ini");
                setIni = CurDir + "settings.ini";
            }
            else
            {
                try
                {
                    setxml = XDocument.Load(CurDir + "settings.ini", LoadOptions.None);
                    setroot = setxml.Root;
                    setIni = CurDir + "settings.ini";
                }
                catch (Exception)
                {
                    if (MessageBox.Show("Settings.ini invalid! Are you sure want to reset it?", "Warning!", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        File.Delete(CurDir + "settings.ini");
                        InitializeConfig();
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                }
               
            }
        }

        private void ResetConfig()
        {
            File.Delete(CurDir + "settings.ini");
            configs = Directory.GetFiles(CurDir, "*.config");
            setxml = new XDocument();
            setxml.AddFirst(new XElement("ConfigXml", new XComment("Don't try to delete the first two default configs!")));
            setroot = setxml.Root;
            setroot.Add(new XElement("ConfigList"));
            foreach (var item in configs)
            {
                setroot.XPathSelectElement("ConfigList").Add(new XElement("config", Path.GetFileName(item)));
            }
            setxml.Save(CurDir + "settings.ini");
            setIni = CurDir + "settings.ini";
        }

        private void InitialCheck(string drLet)
        {
            if (Directory.Exists(drLet + ":\\"))
            {
                if (Directory.Exists(drLet + ":\\Config-Editor"))
                {
                    FileTestNCreater(drLet + ":\\Config-Editor\\Pre_Cleanup.config");
                    FileTestNCreater(drLet + ":\\Config-Editor\\Final_Updates.config");
                }
                else
                {
                    DirTestNCreater(drLet + ":\\Config-Editor");
                    FileTestNCreater(drLet + ":\\Config-Editor\\Pre_Cleanup.config");
                    FileTestNCreater(drLet + ":\\Config-Editor\\Final_Updates.config");
                }
                CurDir = drLet + ":\\Config-Editor\\";
                label_CurDir.Text = CurDir;
                chk = 1;
            }
            else
            {
                MessageBox.Show("C or D drive not exist!");
            }
        }

        private void textBox_Input_TextChanged(object sender, EventArgs e)
        {
            InputXML = textBox_Input.Text;
            if (!(File.Exists(InputXML)) && !(InputXML == "") && !(Directory.Exists(InputXML)))
            {
                if (Path.GetExtension(InputXML) == "")
                {
                    label_InputVal.Text = "Directory not available or invalid!";
                    inXvalid = 0;
                }
                else
                {
                    label_InputVal.Text = "Input file not available or invalid!";
                    inXvalid = 0;
                }
                
            }
            if (InputXML == "")
            {
                label_InputVal.Text = "";
                inXvalid = 0;
            }
            else if (File.Exists(InputXML) || Directory.Exists(InputXML))
            {
                label_InputVal.Text = "";
                if (!(InputXML.EndsWith("\\")) && Path.GetExtension(InputXML) == "")
                {
                    InputXML = InputXML + "\\";
                }
                inXvalid = 1;
            }
        }

        private void textBox_Output_TextChanged(object sender, EventArgs e)
        {
            OutputXML = textBox_Output.Text;
            if (!(Directory.Exists(OutputXML)))
            {
                label_OutputVal.Text = "Destination folder not available or invalid!";
                outXvalid = 0;
            }
            else
            {
                label_OutputVal.Text = "";
                if(!OutputXML.EndsWith("\\"))
                {
                    OutputXML = OutputXML + "\\";
                }
                outXvalid = 1;
            }
            if (OutputXML == "")
            {
                label_OutputVal.Text = "";
                outXvalid = 0;
            }

        }

        private void comboBox_Config_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfigFile = comboBox_Config.SelectedIndex;
        }

        private void button_Input_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                if (folderBrowserDialog_InputFolder.ShowDialog() == DialogResult.OK)
                {
                    textBox_Input.Text = folderBrowserDialog_InputFolder.SelectedPath;
                }

            }
            else if (e.Button == MouseButtons.Left)
            {
                if (openFileDialog_Input.ShowDialog() == DialogResult.OK)
                {
                    textBox_Input.Text = openFileDialog_Input.FileName;
                }
            }
        }

        private void button_Input_Click(object sender, EventArgs e)
        {  
            if (openFileDialog_Input.ShowDialog() == DialogResult.OK)
            {
                    textBox_Input.Text = openFileDialog_Input.FileName;
            }
           
        }

        private void button_RepAll_Click(object sender, EventArgs e)
        {
            if (inXvalid == 1 && outXvalid == 1)
            {
                richTextBox_Result.Text = "";
                Trace.WriteLine("Batch replacement started:\n");
                var confname = CurDir + comboBox_Config.SelectedItem + ".config";
                var sxml = File.ReadAllText(confname);
                var xmlfindmths = Regex.Matches(sxml, "<spanFind>(.+)</spanFind>");
                var xmlreplmths = Regex.Matches(sxml, "<spanReplace>(.+)</spanReplace>");

                var xmlfind = xmlfindmths.Cast<Match>().Select(match => Regex.Replace(match.Value, "<spanFind>(.+)</spanFind>", "$1")).ToList();
                var xmlrepl = xmlreplmths.Cast<Match>().Select(match => Regex.Replace(match.Value, "<spanReplace>(.+)</spanReplace>", "$1")).ToList();

                var replcnt = xmlfind.Count;

                if (!(Path.GetExtension(InputXML) == ""))
                {
                    Trace.WriteLine("Process started in " + InputXML + ":\n");
                    string inFile = File.ReadAllText(@InputXML);

                    for(var i=0; i<replcnt; i++)
                    {
                        var rFind = xmlfind[i];
                        var rRepl = xmlrepl[i];
                        var rCnt = Regex.Matches(inFile, rFind).Count;
                        inFile = inFile.Replace(rFind, rRepl);
                        Trace.WriteLine("Find value: \"" + rFind + "\"");
                        Trace.WriteLine("Replace value: \"" + rRepl + "\"");
                        Trace.WriteLine("Occurrence replaced: \"" + rCnt + "\"\n");
                    }
                    File.WriteAllText(OutputXML + Path.GetFileName(InputXML), inFile);
                }
                else
                {
                    var xfiles = Directory.GetFiles(InputXML);
                    foreach (var xfile in xfiles)
                    {
                        Trace.WriteLine("Process started in " + xfile + ":\n");
                        string inFile = File.ReadAllText(xfile);
                        for (var i = 0; i < replcnt; i++)
                        {
                            var rFind = xmlfind[i];
                            var rRepl = xmlrepl[i];
                            var rCnt = Regex.Matches(inFile, rFind).Count;
                            inFile = inFile.Replace(rFind, rRepl);
                            Trace.WriteLine("Find value: \"" + rFind + "\"");
                            Trace.WriteLine("Replace value: \"" + rRepl + "\"");
                            Trace.WriteLine("Occurrence replaced: \"" + rCnt + "\"\n");
                        }
                        File.WriteAllText(OutputXML + Path.GetFileName(xfile), inFile);
                    }

                }
                Trace.WriteLine("Batch replacement completed!");
                Trace.WriteLine("____________________________________________________________");
                Trace.WriteLine("____________________________________________________________\n\n");
                Trace.Flush();
                Trace.Close();
                MessageBox.Show("Process Completed!", "Info");
            }
            else
            {
                MessageBox.Show("Provide both the Input and Output locaition and try again!", "Info");
            }
        }

        private void FileTestNCreater(string FileName)
        {
            if (!File.Exists(FileName))
            {
                var nfile = new XDocument();
                nfile.AddFirst(new XElement("Config", new XComment(Path.GetFileNameWithoutExtension(FileName) + " config starts here")));
                var nfilevalue = nfile.Root;
                nfilevalue.Add(new XElement("Replace", new XElement("spanFind", "Find"), new XElement("spanReplace", "Replace")));
                nfile.Save(FileName);
            }
        }

        private void DirTestNCreater(string DirName)
        {
            if (!Directory.Exists(DirName))
            {
                Directory.CreateDirectory(DirName);
            }
        }


        private void label_CurDir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(CurDir);
        }

        private void linkLabel_OpenConfig_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(CurDir + comboBox_Config.SelectedItem + ".config");
        }

        private void linkLabel_AddConfig_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var configs = setroot.XPathSelectElements("ConfigList/config");
            var newItem = comboBox_Config.Text;
            var isval = 0;
            if (Regex.IsMatch(newItem, "^[a-zA-Z0-9_]*$"))
            {
                isval = 1;
            }
            var isExist = 0;
            foreach (var item in configs)
            {
                if (item.Value.Equals(newItem + ".config"))
                {
                    isExist = 1;
                    break;
                }
            }
            if (isExist == 0 && isval == 1 && !(newItem == "") && !(newItem == "Select") && !(newItem == "select"))
            {
                setroot.XPathSelectElement("ConfigList").Add(new XElement("config", comboBox_Config.Text + ".config"));
                setxml.Save(CurDir + "settings.ini");
                FileTestNCreater(CurDir + newItem + ".config");
                ListOutConfig();
                comboBox_Config.Text = "Select";
                MessageBox.Show("Config \"" + newItem + "\" Added!", "Info");
            }
            else if (newItem == "" || newItem == "Select" || newItem == "select")
            {
                MessageBox.Show("Please type a valid config file name and then click \"Add\"!", "Error");
            }
            else if (isval == 0)
            {
                MessageBox.Show("Only use Alphanumeric and Underscores!", "Error");
            }
            else
            {
                MessageBox.Show("Config \"" + newItem + "\" already avaialble!", "Error");
            }
        }

        private void button_ResetIni_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to reset the \"settings.ini\"?", "Warning!", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                File.Delete(CurDir + "settings.ini");
                InitialCheck("D");
                if (chk == 0)
                {
                    InitialCheck("C");
                }
                InitializeConfig();
                ListOutConfig();
                MessageBox.Show("Settings.ini reinitialized!", "Info");
            }
        }

        private void comboBox_Config_TextUpdate(object sender, EventArgs e)
        {
            
        }

        private void linkLabel_DeleteConfig_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete the \"" + comboBox_Config.Text + "\"?", "Warning!", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                setroot = setxml.Root;
                var configs = setroot.XPathSelectElements("ConfigList/config");

                foreach (var config in configs)
                {
                    if (config.Value == comboBox_Config.Text + ".config" && !(comboBox_Config.Text == "Select") && !(comboBox_Config.Text == "select"))
                    {
                        File.Delete(CurDir + config.Value);
                        config.Remove();
                        setxml.Save(CurDir + "settings.ini");
                        ListOutConfig();
                        MessageBox.Show("Config \"" + comboBox_Config.Text + "\" deleted!", "Info");
                        comboBox_Config.Text = "Select";
                        break;
                    }
                    else if (comboBox_Config.Text == "" || comboBox_Config.Text == "Select" || comboBox_Config.Text == "select")
                    {
                        MessageBox.Show("Please select a valid config file name and then click \"Delete\"!", "Error");
                    }
                }
            }
          
        }


    }

    public class MyTraceBox : TraceListener
    {
        private TextBoxBase ot;

        public MyTraceBox(TextBoxBase TraceBox)
        {
            this.Name = "Trace";
            this.ot = TraceBox;
        }
        public override void Write(string message)
        {
            Action append = () =>
            {
                ot.AppendText(message);
            };
            if (ot.InvokeRequired)
            {
                ot.BeginInvoke(append);
            }
            else
            {
                append();
            }
        }

        public override void WriteLine(string message)
        {
            Write(message + Environment.NewLine);
        }
    }
}