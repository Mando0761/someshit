using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Mach
{
    public partial class palindrome : Form
    {

        //******************************************************************************************************//
        // Esta forma consiste practicamente en lo mismo que la forma de los ejercicios 1 y 2                   //
        // la unica diferencia es que tiene una lista donde se han separado cada una de las palabras de entrada //
        // y un contador por como se va moviendo la lista de las palabras                                       //
        //******************************************************************************************************//
        #region Variables
        List<estados> et = new List<estados>();
        List<char> lista = new List<char>();
        String[] palabras;
        int cursor;
        int estado;
        int contador;
        #endregion
        public palindrome()
        {
            InitializeComponent();
            norma2();
        }
        #region funciones
        public void norma2()
        {
            et.Clear();
            et.Add(new estados(0,' ',' ',true,1));
            et.Add(new estados(1,'1',' ',true,2));
            et.Add(new estados(1,'0',' ',true,5));
            et.Add(new estados(1,' ',' ',false,8));
            et.Add(new estados(2,'1','1',true,2));
            et.Add(new estados(2,'0','0',true,2));
            et.Add(new estados(2,' ',' ',false,3));
            et.Add(new estados(3,' ',' ',true,8));
            et.Add(new estados(3,'1',' ',false,7));
            et.Add(new estados(3,'0',' ',false,4));
            et.Add(new estados(7,'1','1',false,7));
            et.Add(new estados(7,'0','0',false,7));
            et.Add(new estados(7,' ',' ',true,1));
            et.Add(new estados(5,'1','1',true,5));
            et.Add(new estados(5,'0','0',true,5));
            et.Add(new estados(5,' ',' ',false,6));
            et.Add(new estados(6,'0',' ',false,7));
            et.Add(new estados(6,'1',' ',true,4));
            et.Add(new estados(6,' ',' ',true,8));



        }
        public void init()
        {
            lista.Clear();

            lista.Add(' ');


            for (int i = 0; i < palabras[contador].Length; i++)
            {

                lista.Add(palabras[contador][i]);

            }

            lista.Add(' ');


            cursor = 0;

            estado = 0;


        }
        public void eval()
        {

            if (estado == 8 || estado == 4)
            {
                if (estado == 8)
                {
                    resultado.Text = "RESULTADO:" + Environment.NewLine + "ACEPTADO";
                    listBox1.Items.Add(palabras[contador]);
                    contador += 1;
                    if (palabras.Length!=contador)
                    {
                        init();              
                    }
                    else
                    {
                        timer1.Enabled = false;
                        _entradas.SelectAll();
                        
                    }
                    

                }
                else
                {
                    resultado.Text = "RESULTADO:" + Environment.NewLine + "RECHAZADO";
                    listBox2.Items.Add(palabras[contador]);
                    contador += 1;
                    if (palabras.Length != contador)
                    {
                        init();
                    }
                    else
                    {
                        timer1.Enabled = false;
                        _entradas.SelectAll();
                        
                    }
                }
                return;
                
            }
            for (int i = 0; i < et.Count; i++)
            {
                if (et[i]._estado == estado && et[i]._lee == lista[cursor])
                {
                    estado = et[i]._new;

                    lista[cursor] = et[i]._cambia;
                    if (et[i]._mueve)
                    {
                        cursor += 1;
                    }
                    else
                    {
                        cursor -= 1;
                    }
                    i = et.Count;
                    if (estado == 4 || estado == 8)
                    {
                        statelabel.Text = "Estado:" + estado.ToString();
                        return;
                    }


                    fill();


                }
            }
        }
        public void fill()
        {

            statelabel.Text = "Estado:" + estado.ToString();
            cursorlabel.Text = "Cursor:" + cursor.ToString();
            BindingSource source = new BindingSource();
            source.DataSource = lista;
            listavisual.DataSource = source;
            listavisual.SelectedIndex = cursor;
            _entradas.Focus();
            int sum = 0;
            if (contador>0)
            {
                for (int i = 0; i < contador; i++)
                {
                    sum = sum + palabras[i].Length ;
                }
                sum += cursor - 1+contador;
            }
            else
            {
                sum = sum + cursor - 1;
            }
            

            _entradas.SelectionStart = sum;
            _entradas.SelectionLength = 1;


        }
        #endregion
        #region todo_el_demas_cochinero
        private void timer1_Tick(object sender, EventArgs e)
        {
            eval();    
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

        private void _entradas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar == '1' || e.KeyChar == '0' || e.KeyChar == '\b'||e.KeyChar==' '))
            {
                e.Handled = true;

            }
        }

        private void setFont_Click(object sender, EventArgs e)
        {
            
        }

        private void palindrome_Paint(object sender, PaintEventArgs e)
        {
            Graphics r = e.Graphics;
            r.FillRectangle(new SolidBrush(Color.FromArgb(200, 200, 200)), new Rectangle(new Point(0, 0), this.Size));
        }

        
        private void iniciar_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                return;
            }

            palabras = _entradas.Text.Split(' ');
            if (palabras.Length==0)
            {
                return;
            }
            
            resultado.Text = "RESULTADO:";
            contador = 0;
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            init();
            eval();
            timer1.Enabled = true;
            Labelintervalo.Text = "Intervalo: " + timer1.Interval.ToString() + " ms";
            
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void normasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            info inf = new info("MAQUINA DE TURING"+Environment.NewLine+"PALINDROMOS","Soluciona para un lenguaje  de Palindromes"+'\n'+
"donde las palabras se forman con solo "+'\n'+
"0 y 1" + '\n' +
"Q = {q0, q1,q2,q3,q4,q5,q6,q7,q8}." + '\n' +
"Σ = {0, 1}." + '\n' +
"Γ = {0, 1, `, B}." + '\n' +
"F = {q4,q8}." + '\n' +
"Normas de estados determinadas " + '\n' +
"en el archivo ABC.xlsx");
            inf.ShowDialog();
        }

        private void abrirArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Qstring.open_excel();
            }
            catch (Exception r)
            {
                MessageBox.Show(r.Message);
                
            }
            
            
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
        #endregion

        private void entradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Llamado a  un font dialog para cambiar la letra de el textbox de entrada
            FontDialog font = new FontDialog();
            font.Font = _entradas.Font;
            font.ShowColor = true;
            font.ShowEffects = true;
            if (font.ShowDialog() == DialogResult.OK)
            {
                _entradas.Font = font.Font;
                _entradas.ForeColor = font.Color;
            }
        }

        private void analisisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Llamado a  un font dialog para cambiar la letra de la lista de analisis
            FontDialog font = new FontDialog();
            font.Font = listavisual.Font;
            font.ShowColor = true;
            font.ShowEffects = true;
            if (font.ShowDialog() == DialogResult.OK)
            {
                listavisual.Font = font.Font;
                listavisual.ForeColor = font.Color;
            }
        }




    }
}
