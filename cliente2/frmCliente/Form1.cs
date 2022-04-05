using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace cliente2
{
    
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();

        }

        

        private void btnEnviar_Click(object sender, EventArgs e)
        {

            Socket listen = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint connect = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 6400);
            listen.Connect(connect);
            byte[] enviar_Info = new byte[100];
            string dato;
            dato = btnDatosUsuario.Text;
            enviar_Info = Encoding.Default.GetBytes(dato);
            listen.Send(enviar_Info);
        }
    }
}
