
namespace AS7341_Manager
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ViewChart = new LiveCharts.WinForms.CartesianChart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.F1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FClear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FNir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPort = new System.Windows.Forms.TabPage();
            this.panelPort = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cboxPort = new System.Windows.Forms.ComboBox();
            this.cboxData = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxHandshake = new System.Windows.Forms.ComboBox();
            this.cboxBaud = new System.Windows.Forms.ComboBox();
            this.cboxParity = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboxStopBits = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCall = new System.Windows.Forms.Button();
            this.btnComs = new System.Windows.Forms.Button();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.btnConnect = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripLblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblHost = new System.Windows.Forms.Label();
            this.lblPeriph = new System.Windows.Forms.Label();
            this.lblRelease = new System.Windows.Forms.Label();
            this.tabProgram = new System.Windows.Forms.TabPage();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPort.SuspendLayout();
            this.panelPort.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewChart
            // 
            this.ViewChart.Location = new System.Drawing.Point(12, 12);
            this.ViewChart.Name = "ViewChart";
            this.ViewChart.Size = new System.Drawing.Size(590, 337);
            this.ViewChart.TabIndex = 0;
            this.ViewChart.Text = "cartesianChart1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.F1,
            this.F2,
            this.F3,
            this.F4,
            this.F6,
            this.F7,
            this.F8,
            this.FClear,
            this.FNir});
            this.dataGridView1.Location = new System.Drawing.Point(12, 355);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(944, 202);
            this.dataGridView1.TabIndex = 1;
            // 
            // F1
            // 
            this.F1.HeaderText = "405-425";
            this.F1.Name = "F1";
            this.F1.ReadOnly = true;
            // 
            // F2
            // 
            this.F2.HeaderText = "435-455";
            this.F2.Name = "F2";
            this.F2.ReadOnly = true;
            // 
            // F3
            // 
            this.F3.HeaderText = "470-490";
            this.F3.Name = "F3";
            this.F3.ReadOnly = true;
            // 
            // F4
            // 
            this.F4.HeaderText = "505-525";
            this.F4.Name = "F4";
            this.F4.ReadOnly = true;
            // 
            // F6
            // 
            this.F6.HeaderText = "580-600";
            this.F6.Name = "F6";
            this.F6.ReadOnly = true;
            // 
            // F7
            // 
            this.F7.HeaderText = "620-640";
            this.F7.Name = "F7";
            this.F7.ReadOnly = true;
            // 
            // F8
            // 
            this.F8.HeaderText = "670-690";
            this.F8.Name = "F8";
            this.F8.ReadOnly = true;
            // 
            // FClear
            // 
            this.FClear.HeaderText = "Clear";
            this.FClear.Name = "FClear";
            this.FClear.ReadOnly = true;
            // 
            // FNir
            // 
            this.FNir.HeaderText = "Nir";
            this.FNir.Name = "FNir";
            this.FNir.ReadOnly = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabProgram);
            this.tabControl.Controls.Add(this.tabPort);
            this.tabControl.Location = new System.Drawing.Point(604, 41);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(348, 308);
            this.tabControl.TabIndex = 2;
            // 
            // tabPort
            // 
            this.tabPort.Controls.Add(this.pictureBox);
            this.tabPort.Controls.Add(this.lblRelease);
            this.tabPort.Controls.Add(this.lblPeriph);
            this.tabPort.Controls.Add(this.lblHost);
            this.tabPort.Controls.Add(this.panelPort);
            this.tabPort.Controls.Add(this.btnCall);
            this.tabPort.Controls.Add(this.btnComs);
            this.tabPort.Location = new System.Drawing.Point(4, 22);
            this.tabPort.Name = "tabPort";
            this.tabPort.Padding = new System.Windows.Forms.Padding(3);
            this.tabPort.Size = new System.Drawing.Size(340, 282);
            this.tabPort.TabIndex = 1;
            this.tabPort.Text = "Port Settings";
            this.tabPort.UseVisualStyleBackColor = true;
            // 
            // panelPort
            // 
            this.panelPort.Controls.Add(this.label3);
            this.panelPort.Controls.Add(this.cboxPort);
            this.panelPort.Controls.Add(this.cboxData);
            this.panelPort.Controls.Add(this.label2);
            this.panelPort.Controls.Add(this.label1);
            this.panelPort.Controls.Add(this.cboxHandshake);
            this.panelPort.Controls.Add(this.cboxBaud);
            this.panelPort.Controls.Add(this.cboxParity);
            this.panelPort.Controls.Add(this.label4);
            this.panelPort.Controls.Add(this.label6);
            this.panelPort.Controls.Add(this.cboxStopBits);
            this.panelPort.Controls.Add(this.label5);
            this.panelPort.Location = new System.Drawing.Point(17, 16);
            this.panelPort.Name = "panelPort";
            this.panelPort.Size = new System.Drawing.Size(182, 181);
            this.panelPort.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Port:";
            // 
            // cboxPort
            // 
            this.cboxPort.FormattingEnabled = true;
            this.cboxPort.Location = new System.Drawing.Point(78, 13);
            this.cboxPort.Name = "cboxPort";
            this.cboxPort.Size = new System.Drawing.Size(76, 21);
            this.cboxPort.TabIndex = 4;
            // 
            // cboxData
            // 
            this.cboxData.FormattingEnabled = true;
            this.cboxData.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cboxData.Location = new System.Drawing.Point(78, 66);
            this.cboxData.Name = "cboxData";
            this.cboxData.Size = new System.Drawing.Size(76, 21);
            this.cboxData.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Handshake:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Parity:";
            // 
            // cboxHandshake
            // 
            this.cboxHandshake.FormattingEnabled = true;
            this.cboxHandshake.Items.AddRange(new object[] {
            "None",
            "RequestToSend",
            "RequestToSendXOnXOff",
            "XOnXOff"});
            this.cboxHandshake.Location = new System.Drawing.Point(78, 147);
            this.cboxHandshake.Name = "cboxHandshake";
            this.cboxHandshake.Size = new System.Drawing.Size(76, 21);
            this.cboxHandshake.TabIndex = 2;
            // 
            // cboxBaud
            // 
            this.cboxBaud.FormattingEnabled = true;
            this.cboxBaud.Items.AddRange(new object[] {
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "56000",
            "57600",
            "115200",
            "128000",
            "256000"});
            this.cboxBaud.Location = new System.Drawing.Point(78, 39);
            this.cboxBaud.Name = "cboxBaud";
            this.cboxBaud.Size = new System.Drawing.Size(76, 21);
            this.cboxBaud.TabIndex = 6;
            // 
            // cboxParity
            // 
            this.cboxParity.FormattingEnabled = true;
            this.cboxParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.cboxParity.Location = new System.Drawing.Point(78, 120);
            this.cboxParity.Name = "cboxParity";
            this.cboxParity.Size = new System.Drawing.Size(76, 21);
            this.cboxParity.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Baud rate:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Stop bits:";
            // 
            // cboxStopBits
            // 
            this.cboxStopBits.FormattingEnabled = true;
            this.cboxStopBits.Items.AddRange(new object[] {
            "One",
            "OnePointFive",
            "Two"});
            this.cboxStopBits.Location = new System.Drawing.Point(78, 93);
            this.cboxStopBits.Name = "cboxStopBits";
            this.cboxStopBits.Size = new System.Drawing.Size(76, 21);
            this.cboxStopBits.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Data bits:";
            // 
            // btnCall
            // 
            this.btnCall.Location = new System.Drawing.Point(227, 59);
            this.btnCall.Name = "btnCall";
            this.btnCall.Size = new System.Drawing.Size(75, 23);
            this.btnCall.TabIndex = 0;
            this.btnCall.Text = "Call";
            this.btnCall.UseVisualStyleBackColor = true;
            this.btnCall.Click += new System.EventHandler(this.btnCall_Click);
            // 
            // btnComs
            // 
            this.btnComs.Location = new System.Drawing.Point(227, 27);
            this.btnComs.Name = "btnComs";
            this.btnComs.Size = new System.Drawing.Size(75, 23);
            this.btnComs.TabIndex = 12;
            this.btnComs.Text = "COMs";
            this.btnComs.UseVisualStyleBackColor = true;
            this.btnComs.Click += new System.EventHandler(this.btnComs_Click);
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(880, 12);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(72, 23);
            this.btnConnect.TabIndex = 13;
            this.btnConnect.Text = "Disconnect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 560);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(968, 22);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripLblStatus
            // 
            this.toolStripLblStatus.Name = "toolStripLblStatus";
            this.toolStripLblStatus.Size = new System.Drawing.Size(29, 17);
            this.toolStripLblStatus.Text = "port";
            this.toolStripLblStatus.TextChanged += new System.EventHandler(this.toolStripLblStatus_TextChanged);
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHost.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblHost.Location = new System.Drawing.Point(242, 100);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(45, 13);
            this.lblHost.TabIndex = 14;
            this.lblHost.Text = "ESP32";
            // 
            // lblPeriph
            // 
            this.lblPeriph.AutoSize = true;
            this.lblPeriph.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPeriph.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPeriph.Location = new System.Drawing.Point(239, 123);
            this.lblPeriph.Name = "lblPeriph";
            this.lblPeriph.Size = new System.Drawing.Size(51, 13);
            this.lblPeriph.TabIndex = 15;
            this.lblPeriph.Text = "AS7341";
            // 
            // lblRelease
            // 
            this.lblRelease.AutoSize = true;
            this.lblRelease.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRelease.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblRelease.Location = new System.Drawing.Point(224, 146);
            this.lblRelease.Name = "lblRelease";
            this.lblRelease.Size = new System.Drawing.Size(80, 13);
            this.lblRelease.TabIndex = 16;
            this.lblRelease.Text = "Rel.21.09.22";
            // 
            // tabProgram
            // 
            this.tabProgram.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabProgram.BackgroundImage")));
            this.tabProgram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabProgram.Location = new System.Drawing.Point(4, 22);
            this.tabProgram.Name = "tabProgram";
            this.tabProgram.Padding = new System.Windows.Forms.Padding(3);
            this.tabProgram.Size = new System.Drawing.Size(340, 282);
            this.tabProgram.TabIndex = 0;
            this.tabProgram.Text = "Program";
            this.tabProgram.UseVisualStyleBackColor = true;
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::AS7341_Manager.Properties.Resources.chip_64;
            this.pictureBox.Location = new System.Drawing.Point(232, 175);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(64, 64);
            this.pictureBox.TabIndex = 17;
            this.pictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 582);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ViewChart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "AS7341_Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPort.ResumeLayout(false);
            this.tabPort.PerformLayout();
            this.panelPort.ResumeLayout(false);
            this.panelPort.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart ViewChart;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn F1;
        private System.Windows.Forms.DataGridViewTextBoxColumn F2;
        private System.Windows.Forms.DataGridViewTextBoxColumn F3;
        private System.Windows.Forms.DataGridViewTextBoxColumn F4;
        private System.Windows.Forms.DataGridViewTextBoxColumn F6;
        private System.Windows.Forms.DataGridViewTextBoxColumn F7;
        private System.Windows.Forms.DataGridViewTextBoxColumn F8;
        private System.Windows.Forms.DataGridViewTextBoxColumn FClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn FNir;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabProgram;
        private System.Windows.Forms.TabPage tabPort;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboxData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboxBaud;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboxPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxHandshake;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxParity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboxStopBits;
        private System.Windows.Forms.Button btnComs;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnCall;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripLblStatus;
        private System.Windows.Forms.Panel panelPort;
        private System.Windows.Forms.Label lblRelease;
        private System.Windows.Forms.Label lblPeriph;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

