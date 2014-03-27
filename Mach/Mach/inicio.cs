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
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
            this.MaximumSize= new Size(SystemInformation.VirtualScreen.Width,SystemInformation.VirtualScreen.Height);
            this.MinimumSize = new Size(SystemInformation.VirtualScreen.Width, SystemInformation.VirtualScreen.Height);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            maq maquina = new maq();
            
            maquina.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            palindrome pal = new palindrome();
            
            pal.ShowDialog();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Desea Cerrar?", "Salir", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                e.Cancel=true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            binaryAdd bin = new binaryAdd();
         
            bin.ShowDialog();
         
        }
    }
}
