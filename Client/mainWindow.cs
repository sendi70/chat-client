using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using J3QQ4;
using System.Net;
using System.Media;

namespace Client
{
    public partial class mainWindow : MaterialForm
    {

        public TcpClient client;
        public StreamReader reading = null;
        public StreamWriter writing = null;
        private bool activeCall = false;
        public bool bolder = false;
        public string message = "";
        public string nick="";
        public Boolean isConnected = false;
        public String styleOfwb;
        public SoundPlayer soundPlayer = null; 
        public mainWindow()
        {
            InitializeComponent();
            MaterialSkinManager materialManager = MaterialSkinManager.Instance;
            materialManager.AddFormToManage(this);
            materialManager.Theme = MaterialSkinManager.Themes.DARK;
            materialManager.ColorScheme = new ColorScheme(Primary.DeepPurple400,
                Primary.DeepPurple500, Primary.DeepPurple500, Accent.Pink400, TextShade.WHITE);
            materialManager.ColorScheme = new ColorScheme(Primary.Red600, Primary.Red800, Primary.Red400, Accent.Pink400, TextShade.WHITE);
            string mp3path = Directory.GetCurrentDirectory();
            soundPlayer = new SoundPlayer(mp3path + "\\mp3\\gg.wav");

            styleOfwb = @"<style>body {
                margin: 0;
                padding: 0;
                display: block;
                position: relative;
                background-color: #353535;
                overflow: hiden;
            }
            document{
                overflow: hiden;
            }
            .me {
                width: 30%;
                float: right;
                width: 60%;
                background-color: #252525;
                color: white;
            }
            .you {
                background-color: #e53935;
                width: 30%;
                float: left;
                width: 60%;
            }

            .message {
                margin: 0;
                word-wrap: break-word;
                width: 68%; 
                font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode',
                    Geneva, Verdana, sans-serif;
                font-size: 2.8vw;
                float: left;
                margin-left: 2%;
            }
            .nick {
                margin: 0;
                margin-left: 2%;
                box-sizing: border-box;
                word-wrap: break-word;
                width: 30%;
                font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode',
                    Geneva, Verdana, sans-serif;
                font-size: 2.8vw;
                float: left;
                font-weight: bold;
            }
            .me, .you {
                box-sizing: border-box;
                margin: 1% 0;
                border: 0px solid;
                border-radius: 22px;
                padding: 8px;
            }
            .time {
                font-size: 1.5vw;
                font-family: monospace;
                width: 100%;
                text-align: center;
                font-weight: bold;
            }            img{                width: 35px;                height: 35px;            }</style>";
            wbText.DocumentText = styleOfwb;
        }

        private void bConnect_Click(object sender, EventArgs e)
        {
            bwConnection.WorkerSupportsCancellation = true;
            backgroundWorker2.WorkerSupportsCancellation = true;
            if (isConnected == false&& tbNick.Text != "" && tbIP.Text != "" && nUDPort.Text != "") {
                bwConnection.RunWorkerAsync ();
                nick = tbNick.Text;

                bConnect.Text = "DISCONNECT";
                isConnected = !isConnected;

            }
            else {
                string host = tbIP.Text;
                int port = Convert.ToInt16 (nUDPort.Text);

                isConnected = !isConnected;
                bConnect.Text = "CONNECT";


                try {
                    client.Close ();
                    bwConnection.CancelAsync ();
                    backgroundWorker2.CancelAsync ();
                    //lbMessage.Invoke (new MethodInvoker (delegate { lbMessage.Items.Add ("Przerwano połączenie z " + host + " na porcie: " + port); }));
                    lInfo.Invoke (( new MethodInvoker (delegate { lInfo.Text = "Przerwano połączenie z " + host + " na porcie: " + port; }) ));
                    activeCall = false;

                }
                catch (Exception ex) {
                    //lbMessage.Invoke (new MethodInvoker (delegate { lbMessage.Items.Add ("Błąd. Nie udało sie przerwać połączenia!"); }));
                    lInfo.Invoke (( new MethodInvoker (delegate { lInfo.Text = "Błąd. Nie udało sie przerwać połączenia!"; }) ));
                    //MessageBox.Show (ex.ToString ());
                }
            }

        }
        
        
        public void bwConnection_DoWork(object sender, DoWorkEventArgs e)
        {
            string host = tbIP.Text;
            int port = Convert.ToInt16(nUDPort.Text);
            try
            {
                client = new TcpClient();
                client.Connect(new IPEndPoint(IPAddress.Parse(host), Convert.ToInt32(port)));

                //lbMessage.Invoke(new MethodInvoker(delegate { lbMessage.Items.Add("Nawiązano połączenie z " + host + " na porcie: " + port); }));
                lInfo.Invoke (( new MethodInvoker (delegate { lInfo.Text = "Nawiązano połączenie z " + host + " na porcie: " + port; }) ));

                //lbMessage.Items.Add("Nawiązano połączenie z " + host + " na porcie: " + port);
                //client.Close();
                NetworkStream ns = client.GetStream();                    
                writing = new StreamWriter(client.GetStream());
                
                //writing.Write("password");
                writing.WriteLine(tbNick.Text+"|"+tbRoom.Text);
                writing.Flush();
                activeCall = true;
                backgroundWorker2.RunWorkerAsync();

            }
            catch (Exception ex)
            {
                //lbMessage.Invoke(new MethodInvoker(delegate { lbMessage.Items.Add("Błąd. Nie udało sie nawiązać połączenia!"); }));
                lInfo.Invoke (( new MethodInvoker (delegate { lInfo.Text = "Błąd. Nie udało sie nawiązać połączenia!"; }) ));

                activeCall = false;
                //MessageBox.Show(ex.ToString());
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            if (activeCall)
            {
            reading = new StreamReader(client.GetStream());
                try {
                    string messageRecived;//receive a message
                    while((messageRecived = reading.ReadLine()) != "END") {
                        string[] splited =messageRecived.Split(new Char[] { '|' });
                        Console.WriteLine(splited[1]);
                        if (splited[2].Split(null)[0] == "//p")
                        {
                            string[] usuwane = splited[2].Split(null).Skip(2).ToArray();
                            string message = string.Join(" ", usuwane);
                            splited[2] = message;
                        }
                        if(splited[0]=="disconnect")
                        {
                            MessageBox.Show("Ktoś cię nie lubi :/ Zostałeś wyrzucony.");
                            bConnect_Click(null,null);
                        }
                        if (splited[1] == nick)
                            wbText.Invoke(new MethodInvoker(delegate { wbText.DocumentText += "<div class='me'><p class='time'>" + splited[0] + "</p><p class='nick'>" + splited[1] + "</p><p class='message'>" + splited[2] + "</p></div>"; }));
                        else {
                            soundPlayer.Play();
                            wbText.Invoke(new MethodInvoker(delegate { wbText.DocumentText+="<div class='you'><p class='time'>"+splited[0]+ "</p><p class='nick'>" + splited[1] + "</p><p class='message'>" + splited[2] + "</p></div>"; }));
                        }
                        if(splited[0]=="room")
                        {
                            tbRoom.Invoke(new MethodInvoker(delegate { tbRoom.Text = splited[1]; }));
                        }
                        //wbText.Document.Window.ScrollTo(0, wbText.Document.Window.Size.Height);
                    }
                    client.Close();
                }
                catch (Exception ex){ 
                    //lbMessage.Invoke(new MethodInvoker(delegate { lbMessage.Items.Add("Brak połączeniaa"); }));
                    lInfo.Invoke (( new MethodInvoker (delegate { lInfo.Text = "Brak połączenia"; }) ));

                    activeCall = false;
            }                  
            }
        }

        public void button1_Click(object sender, EventArgs e)
        {
            string messageSent = tbMessage.Text;//send a message
            if( messageSent != "" ) {
                try
                {
                    string path = Directory.GetCurrentDirectory();
                    DirectoryInfo directoryInfo =
                    Directory.GetParent(path);
                    directoryInfo =
                    Directory.GetParent(directoryInfo.FullName);
                    messageSent = messageSent.Replace("<smile>", "<img src='" + directoryInfo.FullName + "\\img\\smile.png'>");
                    messageSent = messageSent.Replace("<tears>", "<img src='" + directoryInfo.FullName + "\\img\\sadTears.png'>");
                    messageSent = messageSent.Replace("<kiss>", "<img src='" + directoryInfo.FullName + "\\img\\kiss.png'>");
                    messageSent = messageSent.Replace("<smileTears>", "<img src='" + directoryInfo.FullName + "\\img\\smileTears.png'>");
                    messageSent = messageSent.Replace("<mad>", "<img src='" + directoryInfo.FullName + "\\img\\mad.png'>");
                    writing.WriteLine(messageSent);
                    writing.Flush();
                    //wbText.Invoke(new MethodInvoker(delegate { wbText.DocumentText += "<div class='me'><p>" + messageSent + "</p><div>"; }));
                    //wbText.Document.Window.ScrollTo(0, wbText.Document.Window.Size.Height);
                    tbMessage.Clear();
                }
                catch (Exception ex)
                {
                    //lbMessage.Items.Add("Brak połączenia");
                    lInfo.Invoke (( new MethodInvoker (delegate { lInfo.Text = "Brak połączenia"; }) ));

                    //MessageBox.Show(ex.ToString());
                }
            }            
        }

        private void wbText_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            wbText.Document.Window.ScrollTo(0, wbText.Document.Body.ScrollRectangle.Height);
        }
        private void tbMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                button1_Click(null, null);
            }
            
        }

        private void btBold_Click(object sender, EventArgs e)
        {
            if (bolder == false)
                bolder = true;
            else
                bolder = false;
            //string bolder = "<b>" + tbMessage.SelectedText + "</b>";
            if (tbMessage.SelectedText != String.Empty)
                tbMessage.Text = tbMessage.Text.Replace(tbMessage.SelectedText, "<b>" + tbMessage.SelectedText + "</b>");
            else
                tbMessage.Text += "<b></b>";
        }

        private void BtItalic_Click(object sender, EventArgs e)
        {
            if (tbMessage.SelectedText != String.Empty)
                tbMessage.Text = tbMessage.Text.Replace(tbMessage.SelectedText, "<i>" + tbMessage.SelectedText + "</i>");
            else
                tbMessage.Text += "<i></i>";
        }


        private void Button2_Click(object sender, EventArgs e)
        {
            if (tbMessage.SelectedText != String.Empty)
                tbMessage.Text = tbMessage.Text.Replace(tbMessage.SelectedText, "<u>" + tbMessage.SelectedText + "</u>");
            else
                tbMessage.Text += "<u></u>";
        }


        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "HTML Files|*.html";
            dialog.Title = "Zapisz swoja rozmowe!";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(dialog.FileName, wbText.Document.Body.Parent.OuterHtml);
            }
        }

        private void ToolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wbText.Invoke(new MethodInvoker(delegate { wbText.DocumentText = ""; }));
            wbText.Invoke(new MethodInvoker(delegate { wbText.DocumentText = styleOfwb; }));
        }

        // images with emotion
        private void imgSmile_Click(object sender, EventArgs e) {
            tbMessage.Text += "<smile>";
        }

        private void imgTears_Click(object sender, EventArgs e) {
            tbMessage.Text += "<tears>";
        }

        private void imgKiss_Click(object sender, EventArgs e) {
            tbMessage.Text += "<kiss>";
        }

        private void imgSmileTears_Click(object sender, EventArgs e) {
            tbMessage.Text += "<smileTears>";
        }

        private void imgMad_Click(object sender, EventArgs e) {
            tbMessage.Text += "<mad>";
        }
    }
}
