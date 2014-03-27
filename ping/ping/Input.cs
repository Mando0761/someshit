using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ping
{
    public partial class Input : Form
    {
        public String IP = String.Empty;
        public Input()
        {
            InitializeComponent();
            IP = numericUpDown1.Value.ToString() + "." + numericUpDown2.Value.ToString() + "." + numericUpDown3.Value.ToString()+".";
        }

        private void OButton_Click(object sender, EventArgs e)
        {
            IP = numericUpDown1.Value.ToString() + "." + numericUpDown2.Value.ToString() + "." + numericUpDown3.Value.ToString() + ".";
        }
    }
}
