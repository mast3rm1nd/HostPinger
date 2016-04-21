using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace HostPinger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }        

        private void Button_Go_Click(object sender, EventArgs e)
        {
            System.Net.NetworkInformation.Ping ping =
            new System.Net.NetworkInformation.Ping();
            //System.Net.NetworkInformation.PingReply pingReply = ping.Send("www.cyberforum.ru");
            System.Net.NetworkInformation.PingReply pingReply;

            Text_Box_Results.Text = "";

            string[] test = TextBox_Hosts.Text.Split('\n');

            foreach (string host in TextBox_Hosts.Text.Replace("\r","").Split('\n'))
            {
                try
                {
                    //System.Net.NetworkInformation.PingReply pingReply = ping.Send(host);
                    pingReply = ping.Send(host);
                    Text_Box_Results.Text += host + " - " + pingReply.Status + " [" + pingReply.RoundtripTime + " ms]" + "\r\n";
                }
                catch
                {
                    Text_Box_Results.Text += host + " - " + "Failed" + "\r\n";
                }
            }
            //Text_Box_Results.Text += pingReply.Status;
            //Console.WriteLine(pingReply.RoundtripTime); //время ответа
            //Console.WriteLine(pingReply.Status);        //статус
            //Console.WriteLine(pingReply.Address);       //IP
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("hosts.txt"))
                TextBox_Hosts.Text = File.ReadAllText("hosts.txt");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.WriteAllText("hosts.txt", TextBox_Hosts.Text);
        }
    }
}
