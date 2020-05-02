using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeYonetimiOrcunOzdil
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //Borderless formu hareket ettirmek için kullanılır
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
        //***************************************************


        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTitanic_Click(object sender, EventArgs e)
        {
            TitanicForm titanicForm = new TitanicForm();
            titanicForm.ShowDialog();
        }

        private void buttonRPS_Click(object sender, EventArgs e)
        {
            RockPaperScissorsForm rockPaperScissorsForm = new RockPaperScissorsForm();
            rockPaperScissorsForm.ShowDialog();
        }

        private void buttonZombie_Click(object sender, EventArgs e)
        {
            ZombieForm zombieForm = new ZombieForm();
            zombieForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
         
        }

       
    }
}
