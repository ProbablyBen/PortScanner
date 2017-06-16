namespace PortScanner
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstPorts = new System.Windows.Forms.ListView();
            this.clmStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmPort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnScan = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.lblIP = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.cmbScanType = new System.Windows.Forms.ComboBox();
            this.lblScanType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstPorts
            // 
            this.lstPorts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmStatus,
            this.clmPort});
            this.lstPorts.Location = new System.Drawing.Point(12, 118);
            this.lstPorts.Name = "lstPorts";
            this.lstPorts.Size = new System.Drawing.Size(562, 199);
            this.lstPorts.TabIndex = 4;
            this.lstPorts.UseCompatibleStateImageBehavior = false;
            this.lstPorts.View = System.Windows.Forms.View.Details;
            // 
            // clmStatus
            // 
            this.clmStatus.Text = "Status";
            // 
            // clmPort
            // 
            this.clmPort.Text = "Port";
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(214, 89);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(159, 23);
            this.btnScan.TabIndex = 3;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.BtnScan_Click);
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(214, 13);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(159, 20);
            this.txtIP.TabIndex = 0;
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(188, 16);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(20, 13);
            this.lblIP.TabIndex = 5;
            this.lblIP.Text = "IP:";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(179, 69);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(29, 13);
            this.lblPort.TabIndex = 7;
            this.lblPort.Text = "Port:";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(214, 66);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(159, 20);
            this.txtPort.TabIndex = 2;
            this.txtPort.Text = "1-65535";
            // 
            // cmbScanType
            // 
            this.cmbScanType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbScanType.FormattingEnabled = true;
            this.cmbScanType.Items.AddRange(new object[] {
            "Single Port",
            "Port Range",
            "All Ports"});
            this.cmbScanType.Location = new System.Drawing.Point(214, 39);
            this.cmbScanType.Name = "cmbScanType";
            this.cmbScanType.Size = new System.Drawing.Size(159, 21);
            this.cmbScanType.TabIndex = 1;
            this.cmbScanType.SelectedIndex = 1;
            // 
            // lblScanType
            // 
            this.lblScanType.AutoSize = true;
            this.lblScanType.Location = new System.Drawing.Point(150, 42);
            this.lblScanType.Name = "lblScanType";
            this.lblScanType.Size = new System.Drawing.Size(58, 13);
            this.lblScanType.TabIndex = 6;
            this.lblScanType.Text = "Scan type:";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 331);
            this.Controls.Add(this.lblScanType);
            this.Controls.Add(this.cmbScanType);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.lblIP);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.lstPorts);
            this.Name = "FrmMain";
            this.Text = "Port Scanner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstPorts;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.ComboBox cmbScanType;
        private System.Windows.Forms.Label lblScanType;
        private System.Windows.Forms.ColumnHeader clmPort;
        private System.Windows.Forms.ColumnHeader clmStatus;
    }
}

