namespace SlotiTInClassButtF
{
    partial class SlotClass
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
            this.rtbReel1 = new System.Windows.Forms.RichTextBox();
            this.rtbReel2 = new System.Windows.Forms.RichTextBox();
            this.rtbReel3 = new System.Windows.Forms.RichTextBox();
            this.btnSpin = new System.Windows.Forms.Button();
            this.btnCoin = new System.Windows.Forms.Button();
            this.rtbCoin = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbReel1
            // 
            this.rtbReel1.Location = new System.Drawing.Point(12, 12);
            this.rtbReel1.Name = "rtbReel1";
            this.rtbReel1.Size = new System.Drawing.Size(133, 298);
            this.rtbReel1.TabIndex = 0;
            this.rtbReel1.Text = "";
            // 
            // rtbReel2
            // 
            this.rtbReel2.Location = new System.Drawing.Point(151, 12);
            this.rtbReel2.Name = "rtbReel2";
            this.rtbReel2.Size = new System.Drawing.Size(133, 298);
            this.rtbReel2.TabIndex = 1;
            this.rtbReel2.Text = "";
            // 
            // rtbReel3
            // 
            this.rtbReel3.Location = new System.Drawing.Point(290, 12);
            this.rtbReel3.Name = "rtbReel3";
            this.rtbReel3.Size = new System.Drawing.Size(133, 298);
            this.rtbReel3.TabIndex = 2;
            this.rtbReel3.Text = "";
            // 
            // btnSpin
            // 
            this.btnSpin.Location = new System.Drawing.Point(290, 316);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(133, 76);
            this.btnSpin.TabIndex = 3;
            this.btnSpin.Text = "Spin";
            this.btnSpin.UseVisualStyleBackColor = true;
            this.btnSpin.Click += new System.EventHandler(this.btnSpin_Click);
            // 
            // btnCoin
            // 
            this.btnCoin.Location = new System.Drawing.Point(12, 316);
            this.btnCoin.Name = "btnCoin";
            this.btnCoin.Size = new System.Drawing.Size(133, 76);
            this.btnCoin.TabIndex = 4;
            this.btnCoin.Text = "Insert Coin";
            this.btnCoin.UseVisualStyleBackColor = true;
            this.btnCoin.Click += new System.EventHandler(this.btnCoin_Click);
            // 
            // rtbCoin
            // 
            this.rtbCoin.Location = new System.Drawing.Point(151, 316);
            this.rtbCoin.Name = "rtbCoin";
            this.rtbCoin.Size = new System.Drawing.Size(133, 76);
            this.rtbCoin.TabIndex = 5;
            this.rtbCoin.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 404);
            this.Controls.Add(this.rtbCoin);
            this.Controls.Add(this.btnCoin);
            this.Controls.Add(this.btnSpin);
            this.Controls.Add(this.rtbReel3);
            this.Controls.Add(this.rtbReel2);
            this.Controls.Add(this.rtbReel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbReel1;
        private System.Windows.Forms.RichTextBox rtbReel2;
        private System.Windows.Forms.RichTextBox rtbReel3;
        private System.Windows.Forms.Button btnSpin;
        private System.Windows.Forms.Button btnCoin;
        private System.Windows.Forms.RichTextBox rtbCoin;
    }
}

