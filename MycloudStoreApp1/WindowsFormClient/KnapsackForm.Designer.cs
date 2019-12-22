namespace WindowsFormClient
{
    partial class KnapsackForm
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
            this.uploadBtn = new System.Windows.Forms.Button();
            this.hashKnap = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrivateP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrivatem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrivateN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPublicJ = new System.Windows.Forms.TextBox();
            this.im = new System.Windows.Forms.Label();
            this.txtPrivateim = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uploadBtn
            // 
            this.uploadBtn.Location = new System.Drawing.Point(336, 260);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(138, 23);
            this.uploadBtn.TabIndex = 0;
            this.uploadBtn.Text = "Upload";
            this.uploadBtn.UseVisualStyleBackColor = true;
            this.uploadBtn.Click += new System.EventHandler(this.uploadBtn_Click);
            // 
            // hashKnap
            // 
            this.hashKnap.FormattingEnabled = true;
            this.hashKnap.Location = new System.Drawing.Point(336, 98);
            this.hashKnap.Name = "hashKnap";
            this.hashKnap.Size = new System.Drawing.Size(268, 134);
            this.hashKnap.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "P:";
            // 
            // txtPrivateP
            // 
            this.txtPrivateP.Location = new System.Drawing.Point(85, 54);
            this.txtPrivateP.Name = "txtPrivateP";
            this.txtPrivateP.Size = new System.Drawing.Size(156, 20);
            this.txtPrivateP.TabIndex = 3;
            this.txtPrivateP.Text = "2,3,7,14,30,57,120,252";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "m:";
            // 
            // txtPrivatem
            // 
            this.txtPrivatem.Location = new System.Drawing.Point(291, 54);
            this.txtPrivatem.Name = "txtPrivatem";
            this.txtPrivatem.Size = new System.Drawing.Size(100, 20);
            this.txtPrivatem.TabIndex = 5;
            this.txtPrivatem.Text = "41";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "N:";
            // 
            // txtPrivateN
            // 
            this.txtPrivateN.Location = new System.Drawing.Point(471, 54);
            this.txtPrivateN.Name = "txtPrivateN";
            this.txtPrivateN.Size = new System.Drawing.Size(118, 20);
            this.txtPrivateN.TabIndex = 7;
            this.txtPrivateN.Text = "491";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "J:";
            // 
            // txtPublicJ
            // 
            this.txtPublicJ.Location = new System.Drawing.Point(85, 137);
            this.txtPublicJ.Name = "txtPublicJ";
            this.txtPublicJ.Size = new System.Drawing.Size(156, 20);
            this.txtPublicJ.TabIndex = 9;
            // 
            // im
            // 
            this.im.AutoSize = true;
            this.im.Location = new System.Drawing.Point(42, 219);
            this.im.Name = "im";
            this.im.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.im.Size = new System.Drawing.Size(20, 13);
            this.im.TabIndex = 10;
            this.im.Text = "im:";
            // 
            // txtPrivateim
            // 
            this.txtPrivateim.Location = new System.Drawing.Point(85, 212);
            this.txtPrivateim.Name = "txtPrivateim";
            this.txtPrivateim.Size = new System.Drawing.Size(156, 20);
            this.txtPrivateim.TabIndex = 11;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(121, 260);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(120, 23);
            this.btnGenerate.TabIndex = 12;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // KnapsackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 314);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtPrivateim);
            this.Controls.Add(this.im);
            this.Controls.Add(this.txtPublicJ);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrivateN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrivatem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrivateP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hashKnap);
            this.Controls.Add(this.uploadBtn);
            this.Name = "KnapsackForm";
            this.Text = "KnapsackForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uploadBtn;
        private System.Windows.Forms.ListBox hashKnap;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrivateP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrivatem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrivateN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPublicJ;
        private System.Windows.Forms.Label im;
        private System.Windows.Forms.TextBox txtPrivateim;
        private System.Windows.Forms.Button btnGenerate;
    }
}