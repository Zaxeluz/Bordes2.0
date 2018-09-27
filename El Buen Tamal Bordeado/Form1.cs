using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;

namespace El_Buen_Tamal_Bordeado
{
    public partial class Form1 : Form
    {
        Image<Bgr, byte> Tamalito;

        public Form1()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog tamalitoOfd = new OpenFileDialog();

            if (tamalitoOfd.ShowDialog() == DialogResult.OK)
            {
                Tamalito = new Image<Bgr, byte>(tamalitoOfd.FileName);

                imageBox1.Image = Tamalito;
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("                      You sure?", "System Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cannyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyCanny();
        }

        public void ApplyCanny(double thresh=50.0, double threshlink=20.0)
        {
            if (Tamalito == null)
            {
                return;
            }

            Image<Gray, byte> TamalitoCanny = new Image<Gray, byte>(Tamalito.Width, Tamalito.Height, new Gray(0));

            TamalitoCanny = Tamalito.Canny(thresh, threshlink);
            imageBox1.Image = TamalitoCanny;
        }

        private void sobelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplySobel();
        }

        public void ApplySobel(int xorder=1, int yorder=1, int apertureSize=1)
        {
            if (Tamalito == null)
            {
                return;
            }

            Image<Gray, byte> TamalitoGray = Tamalito.Convert<Gray, byte>();
            Image<Gray, float> TamalitoSobel = new Image<Gray, float>(Tamalito.Width, Tamalito.Height, new Gray(0));

            TamalitoSobel = TamalitoGray.Sobel(xorder, yorder, apertureSize);
            imageBox1.Image = TamalitoSobel;
        }

        private void laplacianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyLaplacian();
        }

        public void ApplyLaplacian(int lApertureSize=1)
        {
            if (Tamalito == null)
            {
                return;
            }

            Image<Gray, byte> TamalitoGray = Tamalito.Convert<Gray, byte>();
            Image<Gray, float> TamalitoLaplacian = new Image<Gray, float>(Tamalito.Width, Tamalito.Height, new Gray(0));

            TamalitoLaplacian = TamalitoGray.Laplace(lApertureSize);
            imageBox1.Image = TamalitoLaplacian;
        }

        private void cannyParametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CannyParameters cp = new El_Buen_Tamal_Bordeado.CannyParameters(this);
            cp.StartPosition = FormStartPosition.CenterParent;
            cp.Show();
        }

        private void sobelParametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SobelParameters sp = new El_Buen_Tamal_Bordeado.SobelParameters(this);
            sp.StartPosition = FormStartPosition.CenterParent;
            sp.Show();
        }

        private void laplacianParametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LaplacianParameters lp = new El_Buen_Tamal_Bordeado.LaplacianParameters(this);
            lp.StartPosition = FormStartPosition.CenterParent;
            lp.Show();
        }
    }
}
