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
    public partial class SobelParameters : Form
    {
        Form1 form;

        public SobelParameters()
        {
            InitializeComponent();
        }

        public SobelParameters(Form1 fm)
        {
            InitializeComponent();
            form = fm;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (form != null)
            {
                form.ApplySobel((int)NumericXOrder.Value, (int)NumericYOrder.Value, (int)NumericApertureSize.Value);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
