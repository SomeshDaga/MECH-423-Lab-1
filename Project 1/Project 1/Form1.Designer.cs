namespace Project_1
{
    partial class frmMainWindow
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
            this.txtXPos = new System.Windows.Forms.TextBox();
            this.txtYPos = new System.Windows.Forms.TextBox();
            this.txtDrawingWindow = new System.Windows.Forms.TextBox();
            this.tmrMoveDelayCounter = new System.Windows.Forms.Timer(this.components);
            this.lstDeltaTime = new System.Windows.Forms.ListBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(45, 33);
            label1.TabIndex = 0;
            label1.Text = "X:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(12, 53);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(45, 33);
            label2.TabIndex = 1;
            label2.Text = "Y:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(12, 96);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(120, 33);
            label3.TabIndex = 2;
            label3.Text = "Delta T";
            // 
            // txtXPos
            // 
            this.txtXPos.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXPos.Location = new System.Drawing.Point(63, 6);
            this.txtXPos.Name = "txtXPos";
            this.txtXPos.ReadOnly = true;
            this.txtXPos.Size = new System.Drawing.Size(150, 40);
            this.txtXPos.TabIndex = 3;
            // 
            // txtYPos
            // 
            this.txtYPos.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYPos.Location = new System.Drawing.Point(63, 53);
            this.txtYPos.Name = "txtYPos";
            this.txtYPos.ReadOnly = true;
            this.txtYPos.Size = new System.Drawing.Size(150, 40);
            this.txtYPos.TabIndex = 4;
            // 
            // txtDrawingWindow
            // 
            this.txtDrawingWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDrawingWindow.Location = new System.Drawing.Point(219, 6);
            this.txtDrawingWindow.Multiline = true;
            this.txtDrawingWindow.Name = "txtDrawingWindow";
            this.txtDrawingWindow.ReadOnly = true;
            this.txtDrawingWindow.Size = new System.Drawing.Size(211, 196);
            this.txtDrawingWindow.TabIndex = 6;
            this.txtDrawingWindow.Text = "Drawing Window";
            this.txtDrawingWindow.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtDrawingWindow_MouseMove);
            // 
            // tmrMoveDelayCounter
            // 
            this.tmrMoveDelayCounter.Enabled = true;
            this.tmrMoveDelayCounter.Interval = 50;
            this.tmrMoveDelayCounter.Tick += new System.EventHandler(this.tmrMoveDelayCounter_Tick);
            // 
            // lstDeltaTime
            // 
            this.lstDeltaTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstDeltaTime.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDeltaTime.FormattingEnabled = true;
            this.lstDeltaTime.ItemHeight = 33;
            this.lstDeltaTime.Location = new System.Drawing.Point(12, 133);
            this.lstDeltaTime.Name = "lstDeltaTime";
            this.lstDeltaTime.Size = new System.Drawing.Size(195, 70);
            this.lstDeltaTime.TabIndex = 7;
            // 
            // frmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 221);
            this.Controls.Add(this.lstDeltaTime);
            this.Controls.Add(this.txtDrawingWindow);
            this.Controls.Add(this.txtYPos);
            this.Controls.Add(this.txtXPos);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.MinimumSize = new System.Drawing.Size(464, 277);
            this.Name = "frmMainWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtXPos;
        private System.Windows.Forms.TextBox txtYPos;
        private System.Windows.Forms.TextBox txtDrawingWindow;
        private System.Windows.Forms.Timer tmrMoveDelayCounter;
        private System.Windows.Forms.ListBox lstDeltaTime;
    }
}

