using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
//------
using System.Windows.Forms;

namespace Mach
{
    //clase donde se define la tabla de  estados de la maquina de turing
    // esto se puede hacer obviamente con un arreglo bidimensional de estados,caracteres
    // pero ps  me parecio mas sencillo usar una lista y que cada miembro de la lista contenga una de las normas
    // de la maquina de turing

    public class estados
    {
        public estados(int estado, char lee, char cambia, Boolean mueve, int nuevo)
        {
            Xestado = estado;// el estado en el que se encuentra la maquina actualmene
            Xlee = lee;      // lo que se encuentra dentro de la lista en la posicion del cursor
            Xcambia = cambia;// por lo que se va a cambiar lo que esta en la lista
            Xmueve = mueve;  // hacia que lado se va a mover el cursor si es true, se mueve hacia la derecha
                             // si es false se mueve hacia la izquierda
            Xnew = nuevo;    // el estado  al que se va a mover la maquina
        }

        #region variables_y_metodos_devueltos
        private int Xestado;
        private char Xlee;
        private char Xcambia;
        private Boolean Xmueve;
        private int Xnew;

        public int _estado
        {
            get { return Xestado; }
        }
        public char _lee
        {
            get { return Xlee; }
        }
        public char _cambia
        {
            get { return Xcambia; }
        }
        public Boolean _mueve
        {
            get { return Xmueve; }
        }
        public int _new
        {
            get { return Xnew; }
        }
        #endregion

    }
    public class Qstring
    {

     public Qstring(int estado, String lee, Char cambia,Char cambialista, Boolean mueve, int nuevo)
        {
            Xestado = estado;
            Xlee = lee;
            Xcambia = cambia;
            Xmueve = mueve;
            Xnew = nuevo;
            Xcambialista = cambialista;
        }
     #region variables_y_metodos_devueltos
     private int Xestado;
        private String Xlee;
        private Char Xcambia;
        private Boolean Xmueve;
        private int Xnew;
        private Char Xcambialista;
        public Char _cambialista
        {
            get { return Xcambialista; }
        }
        public int _estado
        {
            get { return Xestado; }
        }
        public String _lee
        {
            get { return Xlee; }
        }
        public Char _cambia
        {
            get { return Xcambia; }
        }
        public Boolean _mueve
        {
            get { return Xmueve; }
        }
        public int _new
        {
            get { return Xnew; }
        }
     #endregion
        // Funcion para abrir el archivo donde  se encuentran las variables
        public static void open_excel()
        {

            
            string path = Path.Combine(Directory.GetCurrentDirectory(), "ABC.xlsx");
            try
            {
                Process pro = new Process();
                pro.StartInfo = new ProcessStartInfo(path);
                pro.Start();
            }
            catch (Exception)
            {

                path = path.Replace("bin\\Debug\\ABC.xlsx", "Resources\\ABC.xlsx");
                Process pro = new Process();
                pro.StartInfo = new ProcessStartInfo(path);
                pro.Start();    
            }
            
        }
        public static BindingSource list_to_BindingSource(List<char> data)
        {
            BindingSource source = new BindingSource();
            source.DataSource = data;
            return source;

        }

    }
   

}
