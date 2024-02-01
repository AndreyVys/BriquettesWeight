using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.Sockets;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;
using System.IO;
using System.Text.RegularExpressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;

namespace BriquettesWeight
{
    public partial class BriquettesWeight : Form
    {

        public BriquettesWeight()
        {
            InitializeComponent();
        }

        private void BriquettesWeight_Load(object sender, EventArgs e)

        {
            this.Activated += AfterLoading;
        }

        private void AfterLoading(object sender, EventArgs e)
        {
            this.Activated -= AfterLoading;
            Connect("192.168.77.21", 4001);
        }
        async void  Connect(String server, Int32 port)
        {
            try
            {


                //TcpClient tcpClient = new TcpClient();
                //tcpClient.ConnectAsync("192.168.77.21", 4001);
                //NetworkStream stream = tcpClient.GetStream();
                //byte[] data = new byte[512];
                //var response = new StringBuilder();
                //string results;

                //do
                //{
                //    int len = stream.Read(data, 0, 12);
                //    response.Append(Encoding.ASCII.GetString(data, 0, len));
                //    Regex rg = new Regex(@"ww(.*?)kg"); //  = ;
                //    results = rg.Match(response.ToString()).Groups[1].Value;
                //}




                Socket mySocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                mySocket.Connect(server, port);
                while (true)
                {
                    Stream stream = new NetworkStream(mySocket);
                Byte[] responseData = new byte[12];
                int bytes;
                var response = new StringBuilder();

                    string result="";
                    responseData.Initialize();
                    do
                    {
                        bytes = await stream.ReadAsync(responseData, 0, 12);
                        response.Append(Encoding.ASCII.GetString(responseData, 0, bytes));
                        Regex rg = new Regex(@"ww(.*?)kg"); //  = ;
                        result = rg.Match(response.ToString()).Groups[1].Value;
                    }
                    while (result == "");
                    result = result.TrimStart('0');
                    result = result.Length > 0 ? result : "0";
                    labelWeight.Text = result;
                    stream.Close();
                    // Refresh();

                }
            }
            catch (ArgumentNullException e)
            {

                // MessageBox.Show("ArgumentNullException: {0}" + e.ToString());
                labelWeight.Text =  e.ToString();
            }
            catch (SocketException e)
            {
                // MessageBox.Show("SocketException: {0}" + e.ToString());
                labelWeight.Text = e.ToString();
            }
        }

    }
}
