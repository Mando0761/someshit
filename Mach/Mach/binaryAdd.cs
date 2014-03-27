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
    public partial class binaryAdd : Form
    {
        List<Qstring> et = new List<Qstring>();
        List<char> sumando1 = new List<char>();
        List<char> sumando2 = new List<char>();
        List<char> lleva = new List<char>();
        List<char> suma = new List<char>();

        int cursor;
        int estado;
        
        public binaryAdd()
        {
            
            InitializeComponent();
            norma1();
            Labelintervalo.Text = "Intervalo: " + timer1.Interval.ToString() + " ms";
            this.Icon = Properties.Resources.Mattahan_Ultrabuuf_Comics_Batman_Logo;
        }



        public void norma1()
        {
        et.Clear();
            et.Add(new Qstring(0,"   ",' ',' ',true,1));
et.Add(new Qstring(1,"   ",' ',' ',false,3));
et.Add(new Qstring(1,"  1",'1',' ',true,1));
et.Add(new Qstring(1,"  0",'0',' ',true,1));
et.Add(new Qstring(1," 0 ",'0',' ',true,1));
et.Add(new Qstring(1," 01",'1',' ',true,1));
et.Add(new Qstring(1," 00",'0',' ',true,1));
et.Add(new Qstring(1," 1 ",'1',' ',true,1));
et.Add(new Qstring(1," 11",'0',' ',true,2));
et.Add(new Qstring(1," 10",'1',' ',true,1));
et.Add(new Qstring(1,"1  ",'1',' ',false,3));
et.Add(new Qstring(1,"1 1",'0',' ',true,2));
et.Add(new Qstring(1,"1 0",'1',' ',true,1));
et.Add(new Qstring(1,"10 ",'1',' ',true,1));
et.Add(new Qstring(1,"101",'0',' ',true,2));
et.Add(new Qstring(1,"100",'1',' ',true,1));
et.Add(new Qstring(1,"11 ",'0',' ',true,2));
et.Add(new Qstring(1,"111",'1',' ',true,2));
et.Add(new Qstring(1,"110",'0',' ',true,2));
et.Add(new Qstring(1,"0  ",'0','0',false,3));
et.Add(new Qstring(1,"0 1",'1',' ',true,1));
et.Add(new Qstring(1,"0 0",'0',' ',true,1));
et.Add(new Qstring(1,"00 ",'0',' ',true,1));
et.Add(new Qstring(1,"001",'1',' ',true,1));
et.Add(new Qstring(1,"000",'0',' ',true,1));
et.Add(new Qstring(1,"01 ",'1',' ',true,1));
et.Add(new Qstring(1,"011",'0',' ',true,2));
et.Add(new Qstring(1,"010",'1',' ',true,1));
et.Add(new Qstring(2,"   ",' ','1',false,1));
et.Add(new Qstring(2,"  1",' ','1',false,1));
et.Add(new Qstring(2,"  0",' ','1',false,1));
et.Add(new Qstring(2," 0 ",' ','1',false,1));
et.Add(new Qstring(2," 01",' ','1',false,1));
et.Add(new Qstring(2," 00",' ','1',false,1));
et.Add(new Qstring(2," 1 ",' ','1',false,1));
et.Add(new Qstring(2," 11",' ','1',false,1));
et.Add(new Qstring(2," 10",' ','1',false,1));
et.Add(new Qstring(2,"1  ",' ','1',false,1));
et.Add(new Qstring(2,"1 1",' ','1',false,1));
et.Add(new Qstring(2,"1 0",' ','1',false,1));
et.Add(new Qstring(2,"10 ",' ','1',false,1));
et.Add(new Qstring(2,"101",' ','1',false,1));
et.Add(new Qstring(2,"100",' ','1',false,1));
et.Add(new Qstring(2,"11 ",' ','1',false,1));
et.Add(new Qstring(2,"111",' ','1',false,1));
et.Add(new Qstring(2,"110",' ','1',false,1));
et.Add(new Qstring(2,"0  ",' ','1',false,1));
et.Add(new Qstring(2,"0 1",' ','1',false,1));
et.Add(new Qstring(2,"0 0",' ','1',false,1));
et.Add(new Qstring(2,"00 ",' ','1',false,1));
et.Add(new Qstring(2,"001",' ','1',false,1));
et.Add(new Qstring(2,"000",' ','1',false,1));
et.Add(new Qstring(2,"01 ",' ','1',false,1));
et.Add(new Qstring(2,"011",' ','1',false,1));
et.Add(new Qstring(2,"010",' ','1',false,1));
et.Add(new Qstring(3," ",' ',' ',true,3));


        }

        

       private void init(String sum1,String sum2)
        {
            sumando1.Clear(); sumando2.Clear();
            lleva.Clear();suma.Clear();
            estado = 0; cursor = 0;
            if (sum1.Length>sum2.Length)
            {
                while (sum2.Length!=sum1.Length)
                {
                    sum2 = ' ' + sum2;
                }
            }
            if (sum2.Length > sum1.Length)
            {
                while (sum2.Length != sum1.Length)
                {
                    sum1 = ' ' + sum1;
                }
            }
            
            for (int i = 0; i < sum1.Length; i++)
            {
                if (i==0)
	                {
                        sumando1.Add(' ');
                        sumando2.Add(' ');
                        lleva.Add(' ');
                        suma.Add(' ');
	                }
                sumando1.Add(sum1[sum1.Length - (i + 1)]); sumando2.Add(sum2[sum1.Length - (i + 1)]); lleva.Add(' '); suma.Add(' ');
                if (i==sum1.Length-1)
                {
                    sumando1.Add(' ');
                    sumando2.Add(' ');
                    lleva.Add(' ');
                    suma.Add(' ');
                    
                }
    
                
            }
            fill();
        }
       public void fill()
       {
           listBox1.DataSource = Qstring.list_to_BindingSource(sumando1);
           listBox2.DataSource = Qstring.list_to_BindingSource(sumando2);
           listBox3.DataSource = Qstring.list_to_BindingSource(lleva);
           listBox4.DataSource = Qstring.list_to_BindingSource(suma);
           listBox1.SelectedIndex = cursor;
           listBox2.SelectedIndex = cursor;
           listBox3.SelectedIndex = cursor;
           listBox4.SelectedIndex = cursor;
           cursorlabel.Text = "Cursor :"+cursor.ToString();
           statelabel.Text = "Estado :" + estado.ToString();
       }
       public void eval()
       {
           if (estado == 3 )
           {
               timer1.Enabled = false;
               process.Text = "Terminado";
               String res = String.Empty;
               for (int i = 0; i < suma.Count; i++)
               {
                   if (suma[i]!=' ')
                   {
                       res = suma[i] + res;
                   }
               }
               textBox3.Text = res;
               textBox1.SelectAll();
               textBox1.Focus();
               return;
           }

           for (int i = 0; i < et.Count; i++)
           {
               String chain = lleva[cursor].ToString() + sumando1[cursor] + sumando2[cursor];
               if (et[i]._estado == estado && et[i]._lee == chain)
               {
                   estado = et[i]._new;
                   suma[cursor] = et[i]._cambia;
                   lleva[cursor] = et[i]._cambialista;
                   if (et[i]._mueve)
                   {
                       cursor += 1;
                   }
                   i = et.Count;
                  
                       fill();    
                   
                   


               }
           }
       }
       
       private void KeyPresseed(object sender, KeyPressEventArgs e)
       {
           if (e.KeyChar=='\r')
	{

        if (sender == textBox1)
        {
            e.Handled = true;
            textBox2.Focus();
            return;
        }
        if (sender == textBox2)
        {
            e.Handled = true;
            Inicio.Focus();
            return;
        }
	}
           

           if (!(e.KeyChar == '1' || e.KeyChar == '0' || e.KeyChar == '\b'))
           {
               e.Handled = true;
            }
       }

       private void Inicio_Click(object sender, EventArgs e)
       {

           init(textBox1.Text,textBox2.Text);
           eval();
           Labelintervalo.Text = "Intervalo: " + timer1.Interval.ToString() + " ms";
           textBox3.Text = String.Empty;
           process.Text = "En Proceso";
           timer1.Enabled = true;

       }

       private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
       {

       }

       private void button1_Click(object sender, EventArgs e)
       {
           eval();
       }

       private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
       {

       }

       private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
       {

       }

       private void timer1_Tick(object sender, EventArgs e)
       {
           eval();
       }

       private void cursorlabel_Click(object sender, EventArgs e)
       {

       }

       private void pause_Click(object sender, EventArgs e)
       {
           if (timer1.Enabled)
           {
               timer1.Enabled = false;
           }
           else
           {
               timer1.Enabled = true;

           }
       }

       private void setInterval_Click(object sender, EventArgs e)
       {
           interval tim = new interval(timer1.Interval);
           if (tim.ShowDialog() == DialogResult.OK && tim.numericUpDown1.Value != 0)
           {
               timer1.Interval = (int)tim.numericUpDown1.Value;
               Labelintervalo.Text = "Intervalo: " + timer1.Interval.ToString() + " ms";
           }
       }

       private void binaryAdd_Load(object sender, EventArgs e)
       {

       }

       private void sumando1ToolStripMenuItem_Click(object sender, EventArgs e)
       {
           FontDialog font = new FontDialog();
           font.Font = textBox1.Font;
           font.ShowColor = true;
           font.ShowEffects = true;
           if (font.ShowDialog() == DialogResult.OK)
           {
               textBox1.Font = font.Font;
               textBox1.ForeColor = font.Color;
           }
       }

       private void sumando1ToolStripMenuItem1_Click(object sender, EventArgs e)
       {
           FontDialog font = new FontDialog();
           font.Font = listBox1.Font;
           font.ShowColor = true;
           font.ShowEffects = true;
           if (font.ShowDialog() == DialogResult.OK)
           {
               listBox1.Font = font.Font;
               listBox1.ForeColor = font.Color;
           }
       }

       private void sumando2ToolStripMenuItem_Click(object sender, EventArgs e)
       {
           FontDialog font = new FontDialog();
           font.Font = textBox2.Font;
           font.ShowColor = true;
           font.ShowEffects = true;
           if (font.ShowDialog() == DialogResult.OK)
           {
               textBox2.Font = font.Font;
               textBox2.ForeColor = font.Color;
           }
       }

       private void resultadoToolStripMenuItem_Click(object sender, EventArgs e)
       {
           FontDialog font = new FontDialog();
           font.Font = textBox3.Font;
           font.ShowColor = true;
           font.ShowEffects = true;
           if (font.ShowDialog() == DialogResult.OK)
           {
               textBox3.Font = font.Font;
               textBox3.ForeColor = font.Color;
           }
       }

       private void sumando2ToolStripMenuItem1_Click(object sender, EventArgs e)
       {
           FontDialog font = new FontDialog();
           font.Font = listBox2.Font;
           font.ShowColor = true;
           font.ShowEffects = true;
           if (font.ShowDialog() == DialogResult.OK)
           {
               listBox2.Font = font.Font;
               listBox2.ForeColor = font.Color;
           }
       }

       private void sumando3ToolStripMenuItem_Click(object sender, EventArgs e)
       {
           FontDialog font = new FontDialog();
           font.Font = listBox3.Font;
           font.ShowColor = true;
           font.ShowEffects = true;
           if (font.ShowDialog() == DialogResult.OK)
           {
               listBox3.Font = font.Font;
               listBox3.ForeColor = font.Color;
           }
       }

       private void abrirArchivoToolStripMenuItem_Click(object sender, EventArgs e)
       {
           try
           {
               Qstring.open_excel();
           }
           catch (Exception m)
           {

               MessageBox.Show(m.Message);
           }
       }

       private void infoToolStripMenuItem_Click(object sender, EventArgs e)
       {
           info inf = new info("MAQUINA DE TURING" + Environment.NewLine + "SUMA BINARIA", "Soluciona para una Suma Binaria" + '\n' +
"donde las palabras se forman con solo " + '\n' +
"0 y 1" + '\n' +
"Q = {q0, q1,q2,q3}." + '\n' +
"Σ = {0, 1}." + '\n' +
"Γ = {0, 1, , B}." + '\n' +
"F = {q3}." + '\n' +
"Se ejemplifica el uso de" + '\n' +
"cintas multiples");
           inf.ShowDialog();
       }
    }
}
