using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace El_Buen_Tamal_Bordeado
{
    public partial class CannyParameters : Form
    {
        Form1 form;

        public CannyParameters()
        {
            InitializeComponent();
        }

        public CannyParameters(Form1 fm)
        {
            InitializeComponent();
            form = fm;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if( form!= null)
            {
                form.ApplyCanny((double)NumericThreshold.Value, (double)NumericThresholdLink.Value);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
