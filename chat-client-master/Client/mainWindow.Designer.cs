namespace Client
{
    partial class mainWindow
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.bwConnection = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.wbText = new System.Windows.Forms.WebBrowser();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tbNick = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbIP = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.nUDPort = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.bConnect = new MaterialSkin.Controls.MaterialRaisedButton();
            this.button1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tbMessage = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btBold = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btItalic = new MaterialSkin.Controls.MaterialRaisedButton();
            this.button2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.lInfo = new MaterialSkin.Controls.MaterialLabel();
            this.imgTears = new System.Windows.Forms.PictureBox();
            this.imgKiss = new System.Windows.Forms.PictureBox();
            this.imgMad = new System.Windows.Forms.PictureBox();
            this.imgSmileTears = new System.Windows.Forms.PictureBox();
            this.imgSmile = new System.Windows.Forms.PictureBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTears)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgKiss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSmileTears)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSmile)).BeginInit();
            this.SuspendLayout();
            // 
            // bwConnection
            // 
            this.bwConnection.WorkerSupportsCancellation = true;
            this.bwConnection.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwConnection_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // wbText
            // 
            this.wbText.Location = new System.Drawing.Point(12, 178);
            this.wbText.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbText.Name = "wbText";
            this.wbText.Size = new System.Drawing.Size(729, 344);
            this.wbText.TabIndex = 13;
            this.wbText.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.wbText_DocumentCompleted);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(178, 80);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(40, 19);
            this.materialLabel1.TabIndex = 20;
            this.materialLabel1.Text = "Nick";
            // 
            // tbNick
            // 
            this.tbNick.Depth = 0;
            this.tbNick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tbNick.Hint = "";
            this.tbNick.Location = new System.Drawing.Point(224, 80);
            this.tbNick.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbNick.Name = "tbNick";
            this.tbNick.PasswordChar = '\0';
            this.tbNick.SelectedText = "";
            this.tbNick.SelectionLength = 0;
            this.tbNick.SelectionStart = 0;
            this.tbNick.Size = new System.Drawing.Size(120, 23);
            this.tbNick.TabIndex = 21;
            this.tbNick.UseSystemPasswordChar = false;
            // 
            // tbIP
            // 
            this.tbIP.Depth = 0;
            this.tbIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tbIP.Hint = "";
            this.tbIP.Location = new System.Drawing.Point(441, 80);
            this.tbIP.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbIP.Name = "tbIP";
            this.tbIP.PasswordChar = '\0';
            this.tbIP.SelectedText = "";
            this.tbIP.SelectionLength = 0;
            this.tbIP.SelectionStart = 0;
            this.tbIP.Size = new System.Drawing.Size(99, 23);
            this.tbIP.TabIndex = 22;
            this.tbIP.Text = "192.168.1.104";
            this.tbIP.UseSystemPasswordChar = false;
            // 
            // nUDPort
            // 
            this.nUDPort.Depth = 0;
            this.nUDPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.nUDPort.Hint = "";
            this.nUDPort.Location = new System.Drawing.Point(612, 80);
            this.nUDPort.MouseState = MaterialSkin.MouseState.HOVER;
            this.nUDPort.Name = "nUDPort";
            this.nUDPort.PasswordChar = '\0';
            this.nUDPort.SelectedText = "";
            this.nUDPort.SelectionLength = 0;
            this.nUDPort.SelectionStart = 0;
            this.nUDPort.Size = new System.Drawing.Size(48, 23);
            this.nUDPort.TabIndex = 23;
            this.nUDPort.Text = "7777";
            this.nUDPort.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(371, 80);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(64, 19);
            this.materialLabel2.TabIndex = 24;
            this.materialLabel2.Text = "Address";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(569, 80);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(37, 19);
            this.materialLabel3.TabIndex = 25;
            this.materialLabel3.Text = "Port";
            // 
            // bConnect
            // 
            this.bConnect.Depth = 0;
            this.bConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.bConnect.Location = new System.Drawing.Point(25, 70);
            this.bConnect.MouseState = MaterialSkin.MouseState.HOVER;
            this.bConnect.Name = "bConnect";
            this.bConnect.Primary = true;
            this.bConnect.Size = new System.Drawing.Size(104, 39);
            this.bConnect.TabIndex = 28;
            this.bConnect.Text = "CONNECT";
            this.bConnect.UseVisualStyleBackColor = true;
            this.bConnect.Click += new System.EventHandler(this.bConnect_Click);
            // 
            // button1
            // 
            this.button1.Depth = 0;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button1.Location = new System.Drawing.Point(666, 563);
            this.button1.MouseState = MaterialSkin.MouseState.HOVER;
            this.button1.Name = "button1";
            this.button1.Primary = true;
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 30;
            this.button1.Text = "Wyślij";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbMessage
            // 
            this.tbMessage.Depth = 0;
            this.tbMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tbMessage.Hint = "";
            this.tbMessage.Location = new System.Drawing.Point(17, 570);
            this.tbMessage.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.PasswordChar = '\0';
            this.tbMessage.SelectedText = "";
            this.tbMessage.SelectionLength = 0;
            this.tbMessage.SelectionStart = 0;
            this.tbMessage.Size = new System.Drawing.Size(643, 23);
            this.tbMessage.TabIndex = 31;
            this.tbMessage.UseSystemPasswordChar = false;
            this.tbMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMessage_KeyDown);
            // 
            // btBold
            // 
            this.btBold.Depth = 0;
            this.btBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btBold.Location = new System.Drawing.Point(58, 534);
            this.btBold.MouseState = MaterialSkin.MouseState.HOVER;
            this.btBold.Name = "btBold";
            this.btBold.Primary = true;
            this.btBold.Size = new System.Drawing.Size(30, 30);
            this.btBold.TabIndex = 32;
            this.btBold.Text = "B";
            this.btBold.UseVisualStyleBackColor = true;
            this.btBold.Click += new System.EventHandler(this.btBold_Click);
            // 
            // btItalic
            // 
            this.btItalic.Depth = 0;
            this.btItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Italic);
            this.btItalic.Location = new System.Drawing.Point(99, 534);
            this.btItalic.MouseState = MaterialSkin.MouseState.HOVER;
            this.btItalic.Name = "btItalic";
            this.btItalic.Primary = true;
            this.btItalic.Size = new System.Drawing.Size(30, 30);
            this.btItalic.TabIndex = 33;
            this.btItalic.Text = "I";
            this.btItalic.UseVisualStyleBackColor = true;
            this.btItalic.Click += new System.EventHandler(this.BtItalic_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Depth = 0;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Underline);
            this.button2.Location = new System.Drawing.Point(140, 534);
            this.button2.MouseState = MaterialSkin.MouseState.HOVER;
            this.button2.Name = "button2";
            this.button2.Primary = true;
            this.button2.Size = new System.Drawing.Size(30, 30);
            this.button2.TabIndex = 34;
            this.button2.Text = "u";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(645, 143);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(65, 25);
            this.toolStrip1.TabIndex = 39;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(13, 22);
            this.toolStripDropDownButton1.Text = "Options";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.ToolStripDropDownButton1_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.ClearToolStripMenuItem_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.toolStripLabel1.Size = new System.Drawing.Size(49, 25);
            this.toolStripLabel1.Text = "Options";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(259, 143);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(332, 19);
            this.materialLabel5.TabIndex = 41;
            this.materialLabel5.Text = "say //p <nick> <message> to send priv message";
            // 
            // lInfo
            // 
            this.lInfo.AutoSize = true;
            this.lInfo.Depth = 0;
            this.lInfo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lInfo.Location = new System.Drawing.Point(13, 118);
            this.lInfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lInfo.Name = "lInfo";
            this.lInfo.Size = new System.Drawing.Size(21, 19);
            this.lInfo.TabIndex = 40;
            this.lInfo.Text = "   ";
            // 
            // imgTears
            // 
            this.imgTears.Image = ((System.Drawing.Image)(resources.GetObject("imgTears.Image")));
            this.imgTears.Location = new System.Drawing.Point(482, 528);
            this.imgTears.Name = "imgTears";
            this.imgTears.Size = new System.Drawing.Size(36, 36);
            this.imgTears.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgTears.TabIndex = 43;
            this.imgTears.TabStop = false;
            this.imgTears.Click += new System.EventHandler(this.imgTears_Click);
            // 
            // imgKiss
            // 
            this.imgKiss.Image = ((System.Drawing.Image)(resources.GetObject("imgKiss.Image")));
            this.imgKiss.Location = new System.Drawing.Point(524, 528);
            this.imgKiss.Name = "imgKiss";
            this.imgKiss.Size = new System.Drawing.Size(36, 36);
            this.imgKiss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgKiss.TabIndex = 44;
            this.imgKiss.TabStop = false;
            this.imgKiss.Click += new System.EventHandler(this.imgKiss_Click);
            // 
            // imgMad
            // 
            this.imgMad.Image = ((System.Drawing.Image)(resources.GetObject("imgMad.Image")));
            this.imgMad.Location = new System.Drawing.Point(608, 528);
            this.imgMad.Name = "imgMad";
            this.imgMad.Size = new System.Drawing.Size(36, 36);
            this.imgMad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgMad.TabIndex = 45;
            this.imgMad.TabStop = false;
            this.imgMad.Click += new System.EventHandler(this.imgMad_Click);
            // 
            // imgSmileTears
            // 
            this.imgSmileTears.Image = ((System.Drawing.Image)(resources.GetObject("imgSmileTears.Image")));
            this.imgSmileTears.Location = new System.Drawing.Point(566, 528);
            this.imgSmileTears.Name = "imgSmileTears";
            this.imgSmileTears.Size = new System.Drawing.Size(36, 36);
            this.imgSmileTears.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgSmileTears.TabIndex = 46;
            this.imgSmileTears.TabStop = false;
            this.imgSmileTears.Click += new System.EventHandler(this.imgSmileTears_Click);
            // 
            // imgSmile
            // 
            this.imgSmile.Image = ((System.Drawing.Image)(resources.GetObject("imgSmile.Image")));
            this.imgSmile.Location = new System.Drawing.Point(440, 528);
            this.imgSmile.Name = "imgSmile";
            this.imgSmile.Size = new System.Drawing.Size(36, 36);
            this.imgSmile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgSmile.TabIndex = 47;
            this.imgSmile.TabStop = false;
            this.imgSmile.Click += new System.EventHandler(this.imgSmile_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(12, 143);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(186, 19);
            this.materialLabel4.TabIndex = 48;
            this.materialLabel4.Text = "say //users to get user list";
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 624);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.imgSmile);
            this.Controls.Add(this.imgSmileTears);
            this.Controls.Add(this.imgMad);
            this.Controls.Add(this.imgKiss);
            this.Controls.Add(this.imgTears);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.lInfo);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btItalic);
            this.Controls.Add(this.btBold);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bConnect);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.nUDPort);
            this.Controls.Add(this.tbIP);
            this.Controls.Add(this.tbNick);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.wbText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainWindow";
            this.Text = "TCP CLIENT";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTears)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgKiss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSmileTears)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSmile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker bwConnection;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.WebBrowser wbText;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbNick;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbIP;
        private MaterialSkin.Controls.MaterialSingleLineTextField nUDPort;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialRaisedButton bConnect;
        private MaterialSkin.Controls.MaterialRaisedButton button1;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbMessage;
        private MaterialSkin.Controls.MaterialRaisedButton btBold;
        private MaterialSkin.Controls.MaterialRaisedButton btItalic;
        private MaterialSkin.Controls.MaterialRaisedButton button2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel lInfo;
        private System.Windows.Forms.PictureBox imgTears;
        private System.Windows.Forms.PictureBox imgKiss;
        private System.Windows.Forms.PictureBox imgMad;
        private System.Windows.Forms.PictureBox imgSmileTears;
        private System.Windows.Forms.PictureBox imgSmile;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
    }
}

