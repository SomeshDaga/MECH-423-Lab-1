namespace QueuesWithQueues
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnAvg = new System.Windows.Forms.Button();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.txtGet = new System.Windows.Forms.TextBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.txtN = new System.Windows.Forms.TextBox();
            this.txtAvg = new System.Windows.Forms.TextBox();
            this.lstQueueContents = new System.Windows.Forms.ListBox();
            this.tmrUpdate = new System.Windows.Forms.Timer(this.components);
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(251, 313);
            label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(37, 29);
            label1.TabIndex = 9;
            label1.Text = "N:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(447, 313);
            label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(59, 29);
            label2.TabIndex = 10;
            label2.Text = "Avg:";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(14, 62);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(197, 35);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add to Queue";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnGet
            // 
            this.btnGet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGet.Location = new System.Drawing.Point(14, 136);
            this.btnGet.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(197, 35);
            this.btnGet.TabIndex = 1;
            this.btnGet.Text = "Get from Queue";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // btnCount
            // 
            this.btnCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCount.Location = new System.Drawing.Point(14, 222);
            this.btnCount.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(197, 35);
            this.btnCount.TabIndex = 2;
            this.btnCount.Text = "Items in Queue";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnAvg
            // 
            this.btnAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvg.Location = new System.Drawing.Point(14, 307);
            this.btnAvg.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAvg.Name = "btnAvg";
            this.btnAvg.Size = new System.Drawing.Size(197, 35);
            this.btnAvg.TabIndex = 3;
            this.btnAvg.Text = "Avg of Last N";
            this.btnAvg.UseVisualStyleBackColor = true;
            this.btnAvg.Click += new System.EventHandler(this.btnAvg_Click);
            // 
            // txtAdd
            // 
            this.txtAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdd.Location = new System.Drawing.Point(256, 62);
            this.txtAdd.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(367, 35);
            this.txtAdd.TabIndex = 4;
            // 
            // txtGet
            // 
            this.txtGet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGet.Location = new System.Drawing.Point(256, 136);
            this.txtGet.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtGet.Name = "txtGet";
            this.txtGet.ReadOnly = true;
            this.txtGet.Size = new System.Drawing.Size(367, 35);
            this.txtGet.TabIndex = 5;
            // 
            // txtCount
            // 
            this.txtCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCount.Location = new System.Drawing.Point(256, 222);
            this.txtCount.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtCount.Name = "txtCount";
            this.txtCount.ReadOnly = true;
            this.txtCount.Size = new System.Drawing.Size(367, 35);
            this.txtCount.TabIndex = 6;
            // 
            // txtN
            // 
            this.txtN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN.Location = new System.Drawing.Point(298, 307);
            this.txtN.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(106, 35);
            this.txtN.TabIndex = 7;
            // 
            // txtAvg
            // 
            this.txtAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvg.Location = new System.Drawing.Point(516, 310);
            this.txtAvg.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtAvg.Name = "txtAvg";
            this.txtAvg.ReadOnly = true;
            this.txtAvg.Size = new System.Drawing.Size(107, 35);
            this.txtAvg.TabIndex = 8;
            // 
            // lstQueueContents
            // 
            this.lstQueueContents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstQueueContents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstQueueContents.FormattingEnabled = true;
            this.lstQueueContents.ItemHeight = 29;
            this.lstQueueContents.Location = new System.Drawing.Point(14, 393);
            this.lstQueueContents.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lstQueueContents.Name = "lstQueueContents";
            this.lstQueueContents.Size = new System.Drawing.Size(609, 352);
            this.lstQueueContents.TabIndex = 11;
            // 
            // tmrUpdate
            // 
            this.tmrUpdate.Enabled = true;
            this.tmrUpdate.Tick += new System.EventHandler(this.tmrUpdate_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 781);
            this.Controls.Add(this.lstQueueContents);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.txtAvg);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.txtGet);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.btnAvg);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.btnAdd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MinimumSize = new System.Drawing.Size(661, 837);
            this.Name = "Form1";
            this.Text = "Queue Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnAvg;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.TextBox txtGet;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.TextBox txtAvg;
        private System.Windows.Forms.ListBox lstQueueContents;
        private System.Windows.Forms.Timer tmrUpdate;
    }
}

