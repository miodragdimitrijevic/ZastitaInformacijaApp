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
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fajloviList
            // 
            this.fajloviList.FormattingEnabled = true;
            this.fajloviList.Location = new System.Drawing.Point(91, 100);
            this.fajloviList.Name = "fajloviList";
            this.fajloviList.Size = new System.Drawing.Size(359, 134);
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
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(124, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(375, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Upload";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(84, 263);
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
            this.label3.Location = new System.Drawing.Point(8, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Vasi fajlovi su:";
            // 
            // rbtnKnapsack
            // 
            this.rbtnKnapsack.AutoSize = true;
            this.rbtnKnapsack.Checked = true;
            this.rbtnKnapsack.Location = new System.Drawing.Point(477, 65);
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
            this.rbtnDoubleT.Location = new System.Drawing.Point(476, 136);
            this.rbtnDoubleT.Name = "rbtnDoubleT";
            this.rbtnDoubleT.Size = new System.Drawing.Size(121, 17);
            this.rbtnDoubleT.TabIndex = 8;
            this.rbtnDoubleT.Text = "Double transposition";
            this.rbtnDoubleT.UseVisualStyleBackColor = true;
            // 
            // rbtnXTEA
            // 
            this.rbtnXTEA.AutoSize = true;
            this.rbtnXTEA.Location = new System.Drawing.Point(477, 217);
            this.rbtnXTEA.Name = "rbtnXTEA";
            this.rbtnXTEA.Size = new System.Drawing.Size(53, 17);
            this.rbtnXTEA.TabIndex = 9;
            this.rbtnXTEA.Text = "XTEA";
            this.rbtnXTEA.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(277, 57);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Osvezi svoju listu fajlova";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 315);
            this.Controls.Add(this.button3);
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
        private System.Windows.Forms.Button button3;
    }
}