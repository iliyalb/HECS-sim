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
using MetroFramework.Forms;

namespace HECS_Client
{
   
    public partial class HECS_Client : MetroForm
    {
       
        TcpClient mTcpClient;
        byte[] mrx;
        public HECS_Client()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            IPAddress ipa;
            int nPort;

            try
            {
                if (string.IsNullOrEmpty(tbIPAddress.Text) || string.IsNullOrEmpty(tbPort.Text)) return;

                {

                }

                if (!IPAddress.TryParse(tbIPAddress.Text, out ipa))
                {
                    MessageBox.Show("Please supply an IP Address.");
                    return;
                }
                if (!int.TryParse(tbPort.Text, out nPort))
                {
                    nPort = 23000;
                }
                mTcpClient = new TcpClient();
                mTcpClient.BeginConnect(ipa, nPort, onCompleteConnect, mTcpClient);
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message);
            }

        }

        void onCompleteConnect(IAsyncResult iar)
        {
            TcpClient tcpc;
            try
            {
                tcpc = (TcpClient)iar.AsyncState;
                tcpc.EndConnect(iar);
                mrx = new byte[512];
                tcpc.GetStream().BeginRead(mrx, 0, mrx.Length, onCompleteReadFromServerStream, tcpc);

            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message);
            }
        }

        void onCompleteReadFromServerStream(IAsyncResult iar)
        {
            TcpClient tcpc;
            int nCountByteReceivedFromServer;
            string strReceived;
            try
            {
                tcpc = (TcpClient)iar.AsyncState;
                nCountByteReceivedFromServer = tcpc.GetStream().EndRead(iar);

                if (nCountByteReceivedFromServer == 0)
                {
                    MessageBox.Show("Connection broken");
                    return;
                }
                strReceived = Encoding.ASCII.GetString(mrx, 0, nCountByteReceivedFromServer);
                printLine(strReceived);

                mrx = new byte[512];
                tcpc.GetStream().BeginRead(mrx, 0, mrx.Length, onCompleteReadFromServerStream, tcpc);
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void printLine(string _strPrint)
        {
            textBox1.Invoke(new Action<string>(doInvoke), _strPrint);
        }

        public void doInvoke(string _strPrint)
        {
            textBox1.Text = _strPrint + Environment.NewLine + textBox1.Text;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            byte[] tx;
            if (string.IsNullOrEmpty(tbPayLoad.Text)) return;

            try
            {
                tx = Encoding.ASCII.GetBytes(tbPayLoad.Text);

                if (mTcpClient != null)
                {
                    if (mTcpClient.Client.Connected)
                    {
                        mTcpClient.GetStream().BeginWrite(tx, 0, tx.Length, onCompleteWriteToServer, mTcpClient);
                    }
                }

            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message);
            }


        }
        void onCompleteWriteToServer(IAsyncResult iar)
        {
            TcpClient tcpc;
            try
            {
                tcpc = (TcpClient)iar.AsyncState;
                tcpc.GetStream().EndWrite(iar);
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void tbPayLoad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter )
            {
                IPAddress ipa;
                int nPort;

                try
                {
                    if (string.IsNullOrEmpty(tbIPAddress.Text) || string.IsNullOrEmpty(tbPort.Text)) return;

                    {

                    }

                    if (!IPAddress.TryParse(tbIPAddress.Text, out ipa))
                    {
                        MessageBox.Show("Please supply an IP Address.");
                        return;
                    }
                    if (!int.TryParse(tbPort.Text, out nPort))
                    {
                        nPort = 23000;
                    }
                    mTcpClient = new TcpClient();
                    mTcpClient.BeginConnect(ipa, nPort, onCompleteConnect, mTcpClient);
                }
                catch (Exception exc)
                {

                    MessageBox.Show(exc.Message);
                }
            }
        }
    }
}
