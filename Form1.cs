using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IAProiect
{
    public partial class Form1 : Form
    {
        private OpenFileDialog openFileDialog;

        public Form1()
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();

            InitializeComponent();
        }

        private void loadFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                loadFileTextBox.Text = openFileDialog.FileName;

                var stream = openFileDialog.OpenFile();
                using (StreamReader reader = new StreamReader(stream))
                {
                    var fileContent = reader.ReadToEnd();
                    //bool result = NetworkValidator.validateFile(fileContent);

                    //textBox1.Text = result.ToString();

                    List<string> lines = fileContent.Split('\n').ToList();

                    foreach (var line in lines)
                    {
                        string[] config = line.Split(' ');

                        textBox1.Text += config[0].Substring(1, config[0].Length - 2) + Environment.NewLine;
                    }
                }
            }
        }
    }
}
