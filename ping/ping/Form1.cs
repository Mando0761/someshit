using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net.NetworkInformation;
 
namespace ping
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            IPs = "192.168.0.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Enabled = false;
                button1.Text = "Deshabilitado";
                contador = 0;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
            }
            else
            {
                timer1.Enabled = true;
                button1.Text="Habilitado";
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
        }


        public static Boolean Ping(string url_or_IP)
        {
            Boolean ok = false;
            using (Ping ping = new Ping())
            {

                try
                {
                    
                    String algo = String.Empty;
                    PingReply reply = ping.Send(url_or_IP, 95);
                    if (reply.Status == IPStatus.Success)
                        {
                        
                        algo="Success - IP Address:"+ reply.Address.ToString() +" : " +reply.RoundtripTime.ToString();
                        ok = true;
                    }
                    else
                    {
                        algo=reply.Status.ToString();
                        ok = false;
                    }
                    ping.Dispose();
                    return ok;
                }
                catch (Exception)
                {
                    ok = false;
                    ping.Dispose();
                    return /*ex.InnerException.Message*/ ok;
                }

            }
        }

        int contador = 0;
        long ticks = 0;
        String IPs=String.Empty;
        private void timer1_Tick(object sender, System.EventArgs e)
        {
            if (contador==0)
            {
                ticks = DateTime.Now.Ticks;
            }
            
            String IP=IPs + contador;
            label2.Text = IP;
            if (listBox1.Items.Contains(IP))
            {
                if (Ping(IP)==false)
                {
                    listBox1.Items.Remove(IP);
                    listBox3.Items.Add("IP:" + IP + " Stop at " + DateTime.Now.ToString());
                    listBox2.Items.Add(IP);
                }
                
            }
            else
            {
                if (Ping(IP))
                {
                    listBox1.Items.Add(IP);
                    listBox3.Items.Add("IP:" + IP + " Start at " + DateTime.Now.ToString());
                    listBox2.Items.Remove(IP);
                }
                else
                {
                    if (listBox2.Items.Contains(IP)==false)
                    {
                        listBox2.Items.Add(IP);    
                    }
                    
                }
            }
            contador++;
            if (contador==255)
            {
                contador = 0; //timer1.Enabled = false;
            }
            DateTimeConverter con = new DateTimeConverter();

            this.Text = DateTime.FromBinary(DateTime.Now.Ticks - ticks).ToLongTimeString();
            //if (listBox1.Items.Count>0)
            //{
            //    listBox1.SelectedIndex = listBox1.Items.Count - 1;    
            //}
            //if (listBox2.Items.Count > 0)
            //{
            //    listBox2.SelectedIndex = listBox2.Items.Count - 1;
            //}
            

        }

        

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void sETIPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Input inp = new Input();
            if (inp.ShowDialog()==DialogResult.OK)
	            {
                    IPs = inp.IP;
	            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String f=String.Empty;
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                f += listBox2.Items[i].ToString() + Environment.NewLine;
            }
            if (f!=String.Empty)
            {
                Clipboard.SetText(f);    
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String f = String.Empty;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                f += listBox1.Items[i].ToString() + Environment.NewLine;
            }
            if (f != String.Empty)
            {
                Clipboard.SetText(f);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String f = String.Empty;
            for (int i = 0; i < listBox3.Items.Count; i++)
            {
                f += listBox3.Items[i].ToString() + Environment.NewLine;
            }
            if (f != String.Empty)
            {
                Clipboard.SetText(f);
            }
        }

       

       

    }
}
