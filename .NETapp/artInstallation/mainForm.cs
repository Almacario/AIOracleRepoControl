using System;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace artInstallation
{
    public partial class mainForm : Form
    {
        static SerialPort _serialPort;
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        int cntStates;
        int cntVirtualConsole;
        int S1, S2, S3, S4;
        bool connected;
        ThreadStart childref;
        Thread childThread;

        public mainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadPorts();
            listMusic.DataSource = File.ReadAllLines("./trackList.txt");
            writeState("Program ready to work");
        }

        private void randomTrack()
        {
            Random random=new Random();
            if (listMusic.Items.Count > 0)
            {
                int num = random.Next(listMusic.Items.Count);
                axWindowsMediaPlayer1.URL = listMusic.Items[num].ToString();
                writeState("Random track is played");
            }
        }

        private void writeState(string str)
        {
            if (cntStates > 100) 
            { 
                stateBox.Text = "";
                cntStates = 0;
            }
            stateBox.AppendText("[" + DateTime.Now + "]"+ str+"\n");
            cntStates++;
        }

        private void serialWrite(string str)
        {            
            virtualConsole.AppendText("[COMPUTER:] Writes: "+ str + "\n");
            _serialPort.Write(str);
        }

        private void check()
        {
            childref = new ThreadStart(CallToChildThread);
            childThread = new Thread(childref);
            childThread.Start();
        }

        private void CallToChildThread()
        {
            while (true)
            {
                if (cntVirtualConsole > 10000)
                {
                    virtualConsole.Text = "";
                    cntVirtualConsole = 0;
                }
                string a = _serialPort.ReadExisting();
                if(a.Length>0){
                    virtualConsole.AppendText(a);
                    cntVirtualConsole++;
                    if (a.Contains("DDDDDDDDDD")) {
                        serialWrite("h");
                        randomTrack();
                    }
                }
                Thread.Sleep(200);
            }
        }

        private void loadPorts()
        {
            foreach (string s in SerialPort.GetPortNames())
            {
                listPorts.Items.Add(s);
            }
        }

        private void connect()
        {
            try
            {
                _serialPort = new SerialPort();
                _serialPort.PortName = listPorts.SelectedItem.ToString();
                _serialPort.BaudRate = 9600;
                _serialPort.Open();
                MessageBox.Show("Connection successful", "Connection error");
                virtualConsole.Text = "The device is successfully connected to the PC\n";
                writeState("The device is successfully connected to the PC");
                connected = true;
                virtualConsole.HideSelection = false;
                check();
            }
            catch{
                MessageBox.Show("Connection not successful", "Connection error");
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            connect();
        }

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            childThread.Abort();
            Application.Exit();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            listPorts.Items.Clear();
            loadPorts();
            writeState("Ports refreshed");
        }

        private void listMusic_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void addMusicBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                string fileNameAndPath = op.FileName;
                StreamWriter sw = File.AppendText("./trackList.txt");
                sw.WriteLine(fileNameAndPath);
                sw.Close();
                listMusic.DataSource = File.ReadAllLines("./trackList.txt");
                writeState("Track added");
            }
        }

        private void delMusicBtn_Click(object sender, EventArgs e)
        {
            File_DeleteLine(listMusic.SelectedIndex+1, "./trackList.txt");
            listMusic.DataSource = File.ReadAllLines("./trackList.txt");
            writeState("Track removed");
        }

        private void File_DeleteLine(int Line, string Path)
        {
            StringBuilder sb = new StringBuilder();
            using (StreamReader sr = new StreamReader(Path))
            {
                int Countup = 0;
                while (!sr.EndOfStream)
                {
                    Countup++;
                    if (Countup != Line)
                    {
                        using (StringWriter sw = new StringWriter(sb))
                        {
                            sw.WriteLine(sr.ReadLine());
                        }
                    }
                    else
                    {
                        sr.ReadLine();
                    }
                }
            }
            using (StreamWriter sw = new StreamWriter(Path))
            {
                sw.Write(sb.ToString());
            }
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            randomTrack();
        }

        private void listMusic_DoubleClick(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = listMusic.Items[listMusic.SelectedIndex].ToString();
        }

        private void boxSen1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lightsBtn_Click(object sender, EventArgs e)
        {
            checkTest();
            serialWrite("a");
        }
        private void checkTest()
        {
            if (connected)
            {
                writeState("Test started");
            }
            else
            {
                writeState("Connection not established, test not available");
            }
        }

        private void motorBtn_Click(object sender, EventArgs e)
        {
            checkTest();
            serialWrite("b");
        }

        private void smokeBtn_Click(object sender, EventArgs e)
        {
            checkTest();
            serialWrite("c");
        }

        private void btnSensor_Click(object sender, EventArgs e)
        {
            checkTest();
            serialWrite("d");
        }

        private void virtualConsole_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            checkTest();
            serialWrite("e");
        }

        private void virtualConsole_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
