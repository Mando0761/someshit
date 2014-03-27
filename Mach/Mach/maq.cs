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
    
    public partial class maq : Form
    {
    //****Declaracion de Variables**************************************************************************************//
    // "et" es una lista de la Clase "estados" donde se guardan los estados de la maquina de turing                     //        
    // la variable lista es vaya una lista tipo char donde guardo cada caracter de lo que este en el textbox de  entrada//
    // la variable cursor  indica en que posicion de la lista se encuentra el cursor de la maquina                      //
    // la variable estado indica el estado actual del cursor de la maquina de turing                                    //
    //******************************************************************************************************************//

        #region Variables
        List<estados> et = new List<estados>();
    List<char> lista = new List<char>();
    int cursor;
    int estado;
#endregion
        #region normas

        //funcion para cargar la tabla en el arreglo de estados de la norma2 
        public void norma2()
        {
            et.Clear();
            et.Add(new estados(0, ' ', ' ', true, 1));
            et.Add(new estados(1, '0', ' ', true, 2));
            et.Add(new estados(1, ' ', ' ', false, 3));
            et.Add(new estados(1, '1', ' ', true, 1));
            et.Add(new estados(2, '0', ' ', true, 1));
            et.Add(new estados(2, ' ', ' ', false, 4));
            et.Add(new estados(2, '1', ' ', true, 2));


        }
        //funcion para cargar la tabla en el arreglo de estados de la norma1 
        public void norma1()
        {
            et.Clear();
            et.Add(new estados(0, ' ', ' ', true, 1));
            et.Add(new estados(1, 'C', 'C', true, 3));
            et.Add(new estados(1, 'B', 'B', true, 3));
            et.Add(new estados(1, 'A', 'X', true, 4));
            et.Add(new estados(1, ' ', ' ', false, 3));
            et.Add(new estados(1, 'Y', 'Y', true, 2));
            et.Add(new estados(2, 'Z', 'Z', true, 2));
            et.Add(new estados(2, 'X', 'X', true, 2));
            et.Add(new estados(2, 'C', 'C', true, 3));
            et.Add(new estados(2, ' ', ' ', false, 7));
            et.Add(new estados(2, 'B', 'B', true, 3));
            et.Add(new estados(2, 'A', 'A', true, 3));
            et.Add(new estados(2, 'Y', 'Y', true, 2));
            et.Add(new estados(4, 'Y', 'Y', true, 4));
            et.Add(new estados(4, 'A', 'A', true, 4));
            et.Add(new estados(4, 'B', 'Y', true, 5));
            et.Add(new estados(4, ' ', ' ', false, 3));
            et.Add(new estados(4, 'Z', 'Z', true, 3));
            et.Add(new estados(4, 'C', 'C', true, 3));
            et.Add(new estados(5, 'Z', 'Z', true, 5));
            et.Add(new estados(5, 'B', 'B', true, 5));
            et.Add(new estados(5, 'X', 'X', true, 3));
            et.Add(new estados(5, 'A', 'A', true, 3));
            et.Add(new estados(5, ' ', ' ', false, 3));
            et.Add(new estados(5, 'C', 'Z', false, 6));
            et.Add(new estados(6, 'A', 'A', false, 6));
            et.Add(new estados(6, 'B', 'B', false, 6));
            et.Add(new estados(6, 'Y', 'Y', false, 6));
            et.Add(new estados(6, 'Z', 'Z', false, 6));
            et.Add(new estados(6, 'X', 'X', true, 1));

         
        }
#endregion
        #region metodos
        //Funcion para inicializar las variables; 
        public void init()
        {
            // se limpia el label del resultado
            resultado.Text = "RESULTADO:";
            // se limpia la lista
            lista.Clear();
            // se agregan el caracter vacio al inicio de la cadena
            lista.Add(' ');
            // se agrega cada caracter  de la entrada a la lista
            for (int i = 0; i < _entradas.TextLength; i++)
            {
                lista.Add(_entradas.Text[i]);
            }
            // se agregan el c   aracter vacio al final de la cadena
            lista.Add(' ');
            // y  final mente se posicionan el cursor al inicio de la lista y se posiciona en el estado 0
            cursor = 0;
            estado = 0;


        }
        //Funcion eval, obviamente evalua la maquina de turing
        public void eval()
        {
            // si los estados son 7 o 3 llega al final del proceso, mostrando resultados
            // deshabilitando el timer, seleccionando todo el texto de entrada y haciendo una interrupcion.

            if (estado == 3 || estado == 7)
            {
                if (estado == 7)
                {
                    resultado.Text = "RESULTADO:" + Environment.NewLine + "ACEPTADO";
                }
                else
                {
                    resultado.Text = "RESULTADO:" + Environment.NewLine + "RECHAZADO";
                }

                timer1.Enabled = false;
                _entradas.SelectAll();
                return;
            }

            // entra en un ciclo de esta manera evaluaremos los valores de la variable "estado" y "cursor"
            // con cada una de las reglas de la variable "et"
            for (int i = 0; i < et.Count; i++)
            {
                // hace el recorrido, si la variable _estado y _lee de la posicion de la lista
                // coinciden con las variables "estado" y  el caracter de la lista que esta en la posicion "cursor"
                if (et[i]._estado == estado && et[i]._lee == lista[cursor])
                {
                    //asignamos el estado nuevo a nuestra variable estado
                    estado = et[i]._new;
                    //cambiamos lo que hay en la lista por lo que se debe de cambiar segun las reglas
                    lista[cursor] = et[i]._cambia;
                    //si el valor de mueve es true el cursor se mueve a la derecha
                    //si no, se mueve a la izquierda 
                    if (et[i]._mueve)
                    {
                        cursor += 1;
                    }
                    else
                    {
                        cursor -= 1;
                    }
                    //se cambia la bandera del contador  asi se sale del ciclo y no hace mas comparaciones innecesarias
                    // que pueden causar error dado que se han cambiado los estados y cursores.
                    // ademas asi se hace una solo evaluacion cada ves que se hace un llamado a eval,
                    // sino, el proceso seria tecnicamente inmediato.
                    i = et.Count;

                    // si el estado es igual a 3, estado de no aceptacion se hace un return,
                    //es util  solo para saber el ultimo estado antes de hacer un nuevo movimiento 
                    if (estado == 3)
                    {
                        statelabel.Text = "Estado:" + estado.ToString();
                        return;
                    }

                    // se hace un llamado a la funcion fill
                    fill();


                }
            }
        }
        //tecnicamente hace lo mismo que eval1 pero cambian los estados de aceptacion
        // esto  lo pude optimizar para no repetir codigo pero ya me dio flojera
        public void eval2()
        {

            if (estado == 3 || estado == 4)
            {
                if (estado == 3)
                {
                    resultado.Text = "RESULTADO:" + Environment.NewLine + "ACEPTADO";
                }
                else
                {
                    resultado.Text = "RESULTADO:" + Environment.NewLine + "RECHAZADO";
                }

                timer1.Enabled = false;
                _entradas.SelectAll();
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
                    if (estado == 4 || estado == 3)
                    {
                        statelabel.Text = "Estado:" + estado.ToString();
                        return;
                    }


                    fill();


                }
            }
        }

        // funcion fill para actualizar los valores de "estado","cursor" y la lista donde se van moviendo el cursor
        public void fill()
        {

            statelabel.Text = "Estado:" + estado.ToString();
            cursorlabel.Text = "Cursor:" + cursor.ToString();
            BindingSource source = new BindingSource();
            source.DataSource = lista;
            listavisual.DataSource = source;
            listavisual.SelectedIndex = cursor;
            _entradas.Focus();
            _entradas.SelectionStart = cursor - 1;
            _entradas.SelectionLength = 1;


        }
        #endregion
        #region todo_el_demas_cochinero_de_los_botones_y_demas
        //Constructor
        public maq()
        {
            InitializeComponent();
            //Dependiendo de si esta seleccionado la norma 1 o 2 se cargan las reglas 
            //en la variable "et",haciendo uso de las funciones norm1 y norm2
            if (norm1.Checked)
            {
                norma1();
            }
            else
            {
                norma2();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                return;
            }

            // se hace un llamado a la inicializacion de la variables
            init();
            //Dependiendo de si esta seleccionado la norma 1 o 2 se hace una primera evaluacion 
            if (norm1.Checked)
            {
                eval();    
            }
            else
            {
                eval2();
            }
            // se habilita  el timer, que en cada  tick hara un llamado a la funcion "eval" correspondiente
            timer1.Enabled = true;
            //Setea el label que nos indica el valor del intervalo dle timer
            Labelintervalo.Text = "Intervalo: " + timer1.Interval.ToString() + " ms";
            



        }

        
         private void timer1_Tick(object sender, EventArgs e)
        {// llamado a eval1 o eval2 dependiendo que norma se este usando
            if (norm1.Checked)
            {
                eval();    
            }
            else
            {
                eval2();
            }
        }

        private void intervalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // esto solo para cambiar el valor del intervalo del timer
            //se creo una nueva forma y asi...
            interval tim= new interval(timer1.Interval);
            if (tim.ShowDialog()==DialogResult.OK&&tim.numericUpDown1.Value!=0)
            {
                timer1.Interval = (int)tim.numericUpDown1.Value;
                Labelintervalo.Text = "Intervalo: " + timer1.Interval.ToString() + " ms";
            }
        }

        

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            
            // condicion para saber que caracteres son permitidos dependiendo de la maquina a usar

            if (norm1.Checked)
            {
                // la norma 1 solo acepta 'A','B','C','a','b','c' y el retroceso
                if (!(e.KeyChar == 'A' || e.KeyChar == 'B' || e.KeyChar == 'C' || e.KeyChar == 'a' || e.KeyChar == 'b' || e.KeyChar == 'c' || e.KeyChar == '\b'))
                {
                    e.Handled = true;

                }
            }
            else
            {
                // la norma 1 solo acepta '0','1' y el retroceso
                if (!(e.KeyChar == '1' || e.KeyChar == '0' || e.KeyChar == '\b'))
                {
                    e.Handled = true;

                }
            }
                
                

               
            
                
            
            
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //limpieza de el textbox de entrada y llamado a la inicializacion de variables
            // asi como asignacion de reglas en el arreglo "et"
            _entradas.Text = string.Empty;
            init();
            if (norm1.Checked)
            {
                
                norma1();
            }
            else
            {
                norma2();
            }
            _entradas.Focus();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics r = e.Graphics;
            r.FillRectangle(new SolidBrush(Color.FromArgb(200,200,200)),new Rectangle(new Point(0,0),this.Size));
        }

        private void button1_Click_1(object sender, EventArgs e)
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

        private void abrirARchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // abre archivo de excel donde estan las tablas de las maquinas de turing
                Qstring.open_excel();
            }
            catch (Exception r)
            {
                MessageBox.Show(r.Message);

            }
        }
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
        #endregion

        

    }
}
