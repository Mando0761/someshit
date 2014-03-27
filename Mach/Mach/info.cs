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
    public partial class info : Form
    {
        public info(String Mayor,String Menor)
        {
            InitializeComponent();
            label1.Text = Mayor;
            label2.Text = Menor;
            this.Icon = Properties.Resources.Mattahan_Ultrabuuf_Comics_Batman_Logo;
        }
    }
}
