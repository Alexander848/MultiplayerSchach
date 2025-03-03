using System;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Diagnostics;

namespace Server
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string SERVER_IP = "127.0.0.1";
            int PORT_NO = 5000;

            //---listen at the specified IP and port no.---
            IPAddress localAdd = IPAddress.Parse(SERVER_IP);
            TcpListener listener = new TcpListener(localAdd, PORT_NO);
            Debug.WriteLine("Listening...");
            listener.Start();

            //---incoming client connected---
            TcpClient client = listener.AcceptTcpClient();

            //---get the incoming data through a network stream---
            NetworkStream nwStream = client.GetStream();
            byte[] buffer = new byte[client.ReceiveBufferSize];

            //---read incoming stream---
            int bytesRead = nwStream.Read(buffer, 0, client.ReceiveBufferSize);

            //---convert the data received into a string---
            string dataReceived = Encoding.ASCII.GetString(buffer, 0, bytesRead);
            Debug.WriteLine("Received : " + dataReceived);

            //---write back the text to the client---
            Console.WriteLine("Sending back message");
            byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes("Antwort vom Server");
            nwStream.Write(bytesToSend, 0, bytesToSend.Length);
            client.Close();
            listener.Stop();
        }
    }
}