using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiplayerSchach
{
    public partial class GameLobby : Form
    {
        public GameLobby()
        {
            InitializeComponent();
        }

        private void GameLobby_Load(object sender, EventArgs e)
        {
            CreateServerConnection();
            this.CenterToScreen();
        }

        private void GameLobby_Close(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Creates a connection with the Server
        private void CreateServerConnection()
        {
            //---data to send to the server---
            string textToSend = "Hallo vom Client";

            //---create a TCPClient object at the IP and port no.---
            TcpClient client = new TcpClient(ConnectionSettings.Default.ServerIp, ConnectionSettings.Default.ServerPort);
            NetworkStream nwStream = client.GetStream();
            byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(textToSend);

            //---send the text---
            Console.WriteLine("Sending : " + textToSend);
            nwStream.Write(bytesToSend, 0, bytesToSend.Length);

            //---read back the text---
            byte[] bytesToRead = new byte[client.ReceiveBufferSize];
            int bytesRead = nwStream.Read(bytesToRead, 0, client.ReceiveBufferSize);
            Console.WriteLine("Received : " + Encoding.ASCII.GetString(bytesToRead, 0, bytesRead));
            client.Close();
        }
    }
}
