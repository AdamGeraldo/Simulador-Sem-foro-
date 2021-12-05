using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semáforo
{
    public partial class Semáforo : Form
    {
        int caso = 0;

        public Semáforo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Semaforo.Properties.Resources.verde;
            pictureBox2.Image = Semaforo.Properties.Resources.peatonalverde;
            btnapagar.Enabled = false;
            btndetener.Enabled = false;
        }

        private void btnencender_Click(object sender, EventArgs e)
        {
            timer1.Start();
            btnencender.Enabled = false;
            btndetener.Enabled = true;
            btnapagar.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (caso)
            {
                case 0:
                    pictureBox1.Image = Semaforo.Properties.Resources.verde;
                    timer1.Interval = 7000;
                    pictureBox2.Image = Semaforo.Properties.Resources.peatonalrojo;
                    caso = 1;
                    break;
                case 1:
                    pictureBox1.Image = Semaforo.Properties.Resources.amarillo;
                    timer1.Interval = 5000;
                    caso = 2;
                    break;
                case 2:
                    pictureBox1.Image = Semaforo.Properties.Resources.rojo;
                    timer1.Interval = 10000;
                    pictureBox2.Image = Semaforo.Properties.Resources.peatonalverde;
                    caso = 0;
                    break;
            }
        }

        private void btndetener_Click(object sender, EventArgs e)
        {
            if (btndetener.Text == "Detener")
            {
                timer1.Enabled = false;
                btndetener.Text = "Reanudar";
            }
            else
              if (btndetener.Text == "Detener")
            {
                timer1.Enabled = true;
                btndetener.Text = "Detener";
            }
        }

        private void btnapagar_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            btndetener.Enabled = false;
            btnapagar.Enabled = false;
            btnencender.Enabled = true;
        }
    }
}
