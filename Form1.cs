using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StresserClientTutorial
{
    public partial class Form1 : Form
    {

        private Client client;

        private int threads = 500;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Attack_Click(object sender, EventArgs e)
        {
            string ip = IP.Text;
            int port = int.Parse(Port.Text);
            //int threads = int.Parse(ThreadCount.Text);

            client = new Client(ip, port);

            client.Attack(threads);
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            client.Stop();
        }

        private void ThreadCount_TextChanged(object sender, EventArgs e)
        {
            if (ThreadCount.Text != "")
            {
                threads = int.Parse(ThreadCount.Text);
            }
        }
    }
}
