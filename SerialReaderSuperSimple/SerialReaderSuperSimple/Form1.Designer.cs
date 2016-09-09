namespace SerialReaderSuperSimple
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.cmbComPort = new System.Windows.Forms.ComboBox();
            this.txtXAccel = new System.Windows.Forms.TextBox();
            this.txtYAccel = new System.Windows.Forms.TextBox();
            this.txtZAccel = new System.Windows.Forms.TextBox();
            this.btnComStatus = new System.Windows.Forms.Button();
            this.serGumstick = new System.IO.Ports.SerialPort(this.components);
            this.tmrUpdate = new System.Windows.Forms.Timer(this.components);
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbComPort
            // 
            this.cmbComPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbComPort.FormattingEnabled = true;
            this.cmbComPort.Location = new System.Drawing.Point(12, 35);
            this.cmbComPort.Name = "cmbComPort";
            this.cmbComPort.Size = new System.Drawing.Size(273, 37);
            this.cmbComPort.TabIndex = 0;
            this.cmbComPort.DropDown += new System.EventHandler(this.cmbComPort_DropDown);
            this.cmbComPort.SelectionChangeCommitted += new System.EventHandler(this.cmbComPort_SelectionChangeCommitted);
            // 
            // txtXAccel
            // 
            this.txtXAccel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXAccel.Location = new System.Drawing.Point(12, 92);
            this.txtXAccel.Name = "txtXAccel";
            this.txtXAccel.Size = new System.Drawing.Size(198, 35);
            this.txtXAccel.TabIndex = 1;
            // 
            // txtYAccel
            // 
            this.txtYAccel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYAccel.Location = new System.Drawing.Point(12, 150);
            this.txtYAccel.Name = "txtYAccel";
            this.txtYAccel.Size = new System.Drawing.Size(198, 35);
            this.txtYAccel.TabIndex = 2;
            // 
            // txtZAccel
            // 
            this.txtZAccel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZAccel.Location = new System.Drawing.Point(12, 209);
            this.txtZAccel.Name = "txtZAccel";
            this.txtZAccel.Size = new System.Drawing.Size(198, 35);
            this.txtZAccel.TabIndex = 3;
            // 
            // btnComStatus
            // 
            this.btnComStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComStatus.Location = new System.Drawing.Point(314, 35);
            this.btnComStatus.Name = "btnComStatus";
            this.btnComStatus.Size = new System.Drawing.Size(183, 37);
            this.btnComStatus.TabIndex = 4;
            this.btnComStatus.Text = "Connect";
            this.btnComStatus.UseVisualStyleBackColor = true;
            this.btnComStatus.Click += new System.EventHandler(this.btnComStatus_Click);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(234, 97);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(75, 27);
            label1.TabIndex = 5;
            label1.Text = "X axis";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(234, 155);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(77, 27);
            label2.TabIndex = 6;
            label2.Text = "Y Axis";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(234, 214);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(76, 27);
            label3.TabIndex = 7;
            label3.Text = "Z Axis";
            // 
            // serGumstick
            // 
            this.serGumstick.BaudRate = 128000;
            this.serGumstick.ReceivedBytesThreshold = 7;
            this.serGumstick.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serGumstick_DataReceived);
            // 
            // tmrUpdate
            // 
            this.tmrUpdate.Enabled = true;
            this.tmrUpdate.Tick += new System.EventHandler(this.tmrUpdate_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 274);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.btnComStatus);
            this.Controls.Add(this.txtZAccel);
            this.Controls.Add(this.txtYAccel);
            this.Controls.Add(this.txtXAccel);
            this.Controls.Add(this.cmbComPort);
            this.MinimumSize = new System.Drawing.Size(536, 330);
            this.Name = "Form1";
            this.Text = "Super SImple Serial Port Reader";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbComPort;
        private System.Windows.Forms.TextBox txtXAccel;
        private System.Windows.Forms.TextBox txtYAccel;
        private System.Windows.Forms.TextBox txtZAccel;
        private System.Windows.Forms.Button btnComStatus;
        private System.IO.Ports.SerialPort serGumstick;
        private System.Windows.Forms.Timer tmrUpdate;
    }
}

