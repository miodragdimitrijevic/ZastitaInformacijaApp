namespace WindowsFormClient
{
    partial class UserForm
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fajloviList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.userNametxt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rbtnKnapsack = new System.Windows.Forms.RadioButton();
            this.rbtnDoubleT = new System.Windows.Forms.RadioButton();
            this.rbtnXTEA = new System.Windows.Forms.RadioButton();
            this.rbtnMD5 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fajloviList
            // 
            this.fajloviList.FormattingEnabled = true;
            this.fajloviList.Location = new System.Drawing.Point(117, 136);
            this.fajloviList.Name = "fajloviList";
            this.fajloviList.Size = new System.Drawing.Size(256, 108);
            this.fajloviList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "USER:";
            // 
            // userNametxt
            // 
            this.userNametxt.AutoSize = true;
            this.userNametxt.Location = new System.Drawing.Point(88, 32);
            this.userNametxt.Name = "userNametxt";
            this.userNametxt.Size = new System.Drawing.Size(0, 13);
            this.userNametxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Upload";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(77, 263);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Download";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Vasi fajlovi su:";
            // 
            // rbtnKnapsack
            // 
            this.rbtnKnapsack.AutoSize = true;
            this.rbtnKnapsack.Checked = true;
            this.rbtnKnapsack.Location = new System.Drawing.Point(429, 147);
            this.rbtnKnapsack.Name = "rbtnKnapsack";
            this.rbtnKnapsack.Size = new System.Drawing.Size(73, 17);
            this.rbtnKnapsack.TabIndex = 7;
            this.rbtnKnapsack.TabStop = true;
            this.rbtnKnapsack.Text = "Knapsack";
            this.rbtnKnapsack.UseVisualStyleBackColor = true;
            // 
            // rbtnDoubleT
            // 
            this.rbtnDoubleT.AutoSize = true;
            this.rbtnDoubleT.Location = new System.Drawing.Point(429, 170);
            this.rbtnDoubleT.Name = "rbtnDoubleT";
            this.rbtnDoubleT.Size = new System.Drawing.Size(121, 17);
            this.rbtnDoubleT.TabIndex = 8;
            this.rbtnDoubleT.Text = "Double transposition";
            this.rbtnDoubleT.UseVisualStyleBackColor = true;
            // 
            // rbtnXTEA
            // 
            this.rbtnXTEA.AutoSize = true;
            this.rbtnXTEA.Location = new System.Drawing.Point(429, 193);
            this.rbtnXTEA.Name = "rbtnXTEA";
            this.rbtnXTEA.Size = new System.Drawing.Size(53, 17);
            this.rbtnXTEA.TabIndex = 9;
            this.rbtnXTEA.Text = "XTEA";
            this.rbtnXTEA.UseVisualStyleBackColor = true;
            // 
            // rbtnMD5
            // 
            this.rbtnMD5.AutoSize = true;
            this.rbtnMD5.Location = new System.Drawing.Point(429, 216);
            this.rbtnMD5.Name = "rbtnMD5";
            this.rbtnMD5.Size = new System.Drawing.Size(48, 17);
            this.rbtnMD5.TabIndex = 10;
            this.rbtnMD5.Text = "MD5";
            this.rbtnMD5.UseVisualStyleBackColor = true;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 315);
            this.Controls.Add(this.rbtnMD5);
            this.Controls.Add(this.rbtnXTEA);
            this.Controls.Add(this.rbtnDoubleT);
            this.Controls.Add(this.rbtnKnapsack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userNametxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fajloviList);
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox fajloviList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label userNametxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbtnKnapsack;
        private System.Windows.Forms.RadioButton rbtnDoubleT;
        private System.Windows.Forms.RadioButton rbtnXTEA;
        private System.Windows.Forms.RadioButton rbtnMD5;
    }
}