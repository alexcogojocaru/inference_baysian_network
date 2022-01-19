using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace IAProiect
{
    public partial class Form1 : Form
    {
        private OpenFileDialog openFileDialog;
        private Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();
        private List<Node> nodes = new List<Node>();

        Pen pen = new Pen(Brushes.Black);
        Graphics g;

        public Form1()
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();

            g = this.CreateGraphics();

            InitializeComponent();
        }

        List<List<double>> parseProbabilities(string data)
        {
            List<List<double>> returnList = new List<List<double>>();
            string[] probs = data.Substring(1, data.Length - 2).Split(';');
            
            foreach (var str in probs)
            {
                List<double> pair;

                if (str.Contains(';'))
                {
                    pair = str.Substring(1, str.Length - 2).Split(',').Select(x => double.Parse(x)).ToList();
                }
                else
                {
                    pair = str.Substring(1, str.Length - 3).Split(',').Select(x => double.Parse(x)).ToList();
                }

                returnList.Add(pair);
            }

            return returnList;
        }

        Tuple<int, int> parsePositions(string data)
        {
            int[] position = data.Substring(1, data.Length - 2).Split(',').Select(x => int.Parse(x)).ToArray();
            return new Tuple<int, int>(position[0] * 50, position[1] * 50);
        }

        private void loadFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                loadFileTextBox.Text = openFileDialog.FileName;
                StringFormat drawFormat = new StringFormat();
                Font font = new Font("Arial", 12);
                Brush brush = new SolidBrush(Color.Black);

                var stream = openFileDialog.OpenFile();
                using (StreamReader reader = new StreamReader(stream))
                {
                    var fileContent = reader.ReadToEnd();
                    List<string> lines = fileContent.Split('\n').ToList();

                    foreach (var line in lines)
                    {
                        string[] config = line.Split(' ');
                        int id = int.Parse(config[1]);
                        Tuple<int, int> position = parsePositions(config[0]);

                        graph[id] = new List<int>();
                        Node node = new Node(id, position);
                        
                        g.DrawString(config[2], font, brush, position.Item1, position.Item2);
                        
                        if (config[3] != "[]")
                        {
                            List<int> parents = config[3].Substring(1, config[3].Length - 2).Split(',').Select(x => int.Parse(x)).ToList();
                            node.Parents = parents;

                            foreach (var parent in parents)
                            {
                                graph[parent].Add(id);
                                AdjustableArrowCap bigArrow = new AdjustableArrowCap(5, 5);
                                pen.CustomEndCap = bigArrow;
                                g.DrawLine(pen, nodes[parent].Position.Item1, nodes[parent].Position.Item2, position.Item1, position.Item2);
                            }
                        }

                        List<List<double>> probs = parseProbabilities(config[5]);
                        node.Probabilities = probs;

                        nodes.Add(node);
                    }
                }
            }
        }
    }
}
