using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfigXMLEditor
{
    public partial class Form2 : Form
    {
        string InputXML;
        string inFile;
        Api apics = new Api();

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string input)
        {
            InitializeComponent();
            this.InputXML = input;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (!(Path.GetExtension(InputXML) == ""))
            {
               richTextBox_Editor.Text = File.ReadAllText(@InputXML);
            }
            
            
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inFile = richTextBox_Editor.Text;
            File.WriteAllText(InputXML, inFile);
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            apics.apicall();
        }
    }
}
