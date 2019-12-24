namespace WindowsFormClient
{
    partial class DTForm
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
            this.dimX = new System.Windows.Forms.TextBox();
            this.dimY = new System.Windows.Forms.TextBox();
            this.perX = new System.Windows.Forms.TextBox();
            this.perY = new System.Windows.Forms.TextBox();
            this.hashList = new System.Windows.Forms.ListBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // dimX
            // 
            this.dimX.Location = new System.Drawing.Point(12, 26);
            this.dimX.Name = "dimX";
            this.dimX.Size = new System.Drawing.Size(93, 20);
            this.dimX.TabIndex = 0;
            this.dimX.Text = "4";
            // 
            // dimY
            // 
            this.dimY.Location = new System.Drawing.Point(145, 26);
            this.dimY.Name = "dimY";
            this.dimY.Size = new System.Drawing.Size(100, 20);
            this.dimY.TabIndex = 1;
            this.dimY.Text = "3";
            // 
            // perX
            // 
            this.perX.Location = new System.Drawing.Point(288, 26);
            this.perX.Name = "perX";
            this.perX.Size = new System.Drawing.Size(100, 20);
            this.perX.TabIndex = 2;
            this.perX.Text = "3,0,1,2";
            // 
            // perY
            // 
            this.perY.Location = new System.Drawing.Point(452, 26);
            this.perY.Name = "perY";
            this.perY.Size = new System.Drawing.Size(100, 20);
            this.perY.TabIndex = 3;
            this.perY.Text = "1,2,0";
            // 
            // hashList
            // 
            this.hashList.FormattingEnabled = true;
            this.hashList.Location = new System.Drawing.Point(58, 81);
            this.hashList.Name = "hashList";
            this.hashList.Size = new System.Drawing.Size(451, 95);
            this.hashList.TabIndex = 4;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(201, 211);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(151, 23);
            this.btnUpload.TabIndex = 5;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // DTForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 261);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.hashList);
            this.Controls.Add(this.perY);
            this.Controls.Add(this.perX);
            this.Controls.Add(this.dimY);
            this.Controls.Add(this.dimX);
            this.Name = "DTForm";
            this.Text = "DTForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dimX;
        private System.Windows.Forms.TextBox dimY;
        private System.Windows.Forms.TextBox perX;
        private System.Windows.Forms.TextBox perY;
        private System.Windows.Forms.ListBox hashList;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}