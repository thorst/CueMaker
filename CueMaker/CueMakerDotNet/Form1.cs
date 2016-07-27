using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CueMakerDotNet
{
    public partial class Form1 : Form
    {
        public string cueTemplate = @"FILE ""%FILENAME%.bin"" BINARY
TRACK 01 MODE1/2352
INDEX 01 00:00:00";

        public Form1()
        {
            InitializeComponent();
        }

        private void btBrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txPath.Text = openFileDialog1.FileName;
            }
        }

        private void btGo_Click(object sender, EventArgs e)
        {
            try
            {
                string path = txPath.Text;

                // Determine if its a file or a dir
                if (File.Exists(path))
                {
                    // Its a file
                    createCue(path);

                } else if (Directory.Exists(path))  {
                    // Its a dir
                    SearchOption so = ckRecursive.Checked? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
                    var files = Directory.GetFiles(path, "*.bin", so);
                    foreach (var file in files)
                    {
                        createCue(file);
                    }
                }
            }
            catch (System.Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }
        }
        public void createCue (string file)
        {
            string justFilename = Path.GetFileNameWithoutExtension(file);
            string cue = Path.Combine(Path.GetDirectoryName(file), justFilename + ".cue");

            // Ensure it doesnt already exist
            if (!File.Exists(cue))
            {
                rtOutput.AppendText("Cue created: " + cue + "\r");
                File.WriteAllText(cue, cueTemplate.Replace("%FILENAME%", justFilename));
            }
        }
    }
}
