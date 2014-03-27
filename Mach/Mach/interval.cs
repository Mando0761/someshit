using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mach
{
    public partial class interval : Form
    {
        //simple forma para asignar el valor del intervalo del timer de donde es llamado
        public interval(decimal U)
        {
            InitializeComponent();
            numericUpDown1.Value = U;
            numericUpDown1.Select(0, numericUpDown1.Value.ToString().Length);
        }

        private void numericUpDown1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar=='\r')
            {
                button1.PerformClick();
            }
        }
    }
}
