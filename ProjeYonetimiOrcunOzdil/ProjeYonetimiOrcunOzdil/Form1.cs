using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjeYonetimiOrcunOzdil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> folders = new List<string>() { "Rock", "Paper", "Scissors" };

            foreach (string folder in folders)
            {
                DirectoryInfo d = new DirectoryInfo(@"Data/RockPaperScissors/" + folder + "/");//Assuming Test is your Folder
                FileInfo[] Files = d.GetFiles("*.jpg"); //Getting Text files


                int counter = 0;
                int total = Files.Count();
                foreach (FileInfo file in Files)
                {

                    Image image;
                    using (Stream stream = File.OpenRead(@"Data/RockPaperScissors/" + folder + "/" + file.Name))
                    {
                        image = System.Drawing.Image.FromStream(stream);
                    }
                    image.RotateFlip(RotateFlipType.Rotate90FlipY);


                    if (counter < total / 3 * 2)
                        image.Save(@"C:\ProjeYonetimiOrcunOzdil\ProjeYonetimiOrcunOzdil\bin\Debug\PythonServer\RockPaperSic\datasetUser\test_set\" + folder.ToLower() + "\\" + file.Name);
                    else
                        image.Save(@"C:\ProjeYonetimiOrcunOzdil\ProjeYonetimiOrcunOzdil\bin\Debug\PythonServer\RockPaperSic\datasetUser\training_set\" + folder.ToLower() + "\\" + file.Name);

                    counter++;
                }
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetupConfig setupConfig = new SetupConfig();
            //string name = setupConfig.Test;
            //MessageBox.Show(name);
        }
    }
}
