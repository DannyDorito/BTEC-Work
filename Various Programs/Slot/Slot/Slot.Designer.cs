namespace SlotItIN
{
    partial class Slot
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
            this.btnSpin = new System.Windows.Forms.Button();
            this.btnMoney = new System.Windows.Forms.Button();
            this.rtbCredit = new System.Windows.Forms.RichTextBox();
            this.rtbOutput1 = new System.Windows.Forms.RichTextBox();
            this.rtbOutput2 = new System.Windows.Forms.RichTextBox();
            this.rtbOutput3 = new System.Windows.Forms.RichTextBox();
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnSpin
            // 
            this.btnSpin.Enabled = false;
            this.btnSpin.Location = new System.Drawing.Point(151, 248);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(357, 133);
            this.btnSpin.TabIndex = 0;
            this.btnSpin.Text = "Spin";
            this.btnSpin.UseVisualStyleBackColor = true;
            this.btnSpin.Click += new System.EventHandler(this.btnSpin_Click);
            // 
            // btnMoney
            // 
            this.btnMoney.Location = new System.Drawing.Point(12, 12);
            this.btnMoney.Name = "btnMoney";
            this.btnMoney.Size = new System.Drawing.Size(134, 100);
            this.btnMoney.TabIndex = 1;
            this.btnMoney.Text = "Insert Coin";
            this.btnMoney.UseVisualStyleBackColor = true;
            this.btnMoney.Click += new System.EventHandler(this.btnMoney_Click);
            // 
            // rtbCredit
            // 
            this.rtbCredit.Enabled = false;
            this.rtbCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbCredit.Location = new System.Drawing.Point(12, 248);
            this.rtbCredit.MaximumSize = new System.Drawing.Size(134, 130);
            this.rtbCredit.MinimumSize = new System.Drawing.Size(134, 130);
            this.rtbCredit.Name = "rtbCredit";
            this.rtbCredit.Size = new System.Drawing.Size(134, 130);
            this.rtbCredit.TabIndex = 2;
            this.rtbCredit.Text = "0";
            // 
            // rtbOutput1
            // 
            this.rtbOutput1.Enabled = false;
            this.rtbOutput1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbOutput1.Location = new System.Drawing.Point(152, 118);
            this.rtbOutput1.Name = "rtbOutput1";
            this.rtbOutput1.Size = new System.Drawing.Size(115, 124);
            this.rtbOutput1.TabIndex = 3;
            this.rtbOutput1.Text = "0";
            // 
            // rtbOutput2
            // 
            this.rtbOutput2.Enabled = false;
            this.rtbOutput2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbOutput2.Location = new System.Drawing.Point(273, 118);
            this.rtbOutput2.Name = "rtbOutput2";
            this.rtbOutput2.Size = new System.Drawing.Size(115, 124);
            this.rtbOutput2.TabIndex = 4;
            this.rtbOutput2.Text = "0";
            // 
            // rtbOutput3
            // 
            this.rtbOutput3.Enabled = false;
            this.rtbOutput3.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbOutput3.Location = new System.Drawing.Point(394, 118);
            this.rtbOutput3.Name = "rtbOutput3";
            this.rtbOutput3.Size = new System.Drawing.Size(115, 124);
            this.rtbOutput3.TabIndex = 5;
            this.rtbOutput3.Text = "0";
            // 
            // rtbText
            // 
            this.rtbText.Enabled = false;
            this.rtbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbText.Location = new System.Drawing.Point(153, 12);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(355, 99);
            this.rtbText.TabIndex = 6;
            this.rtbText.Text = "";
            // 
            // Slot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 386);
            this.Controls.Add(this.rtbText);
            this.Controls.Add(this.rtbOutput3);
            this.Controls.Add(this.rtbOutput2);
            this.Controls.Add(this.rtbOutput1);
            this.Controls.Add(this.rtbCredit);
            this.Controls.Add(this.btnMoney);
            this.Controls.Add(this.btnSpin);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(536, 425);
            this.MinimumSize = new System.Drawing.Size(536, 425);
            this.Name = "Slot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Slot";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSpin;
        private System.Windows.Forms.Button btnMoney;
        private System.Windows.Forms.RichTextBox rtbCredit;
        private System.Windows.Forms.RichTextBox rtbOutput1;
        private System.Windows.Forms.RichTextBox rtbOutput2;
        private System.Windows.Forms.RichTextBox rtbOutput3;
        private System.Windows.Forms.RichTextBox rtbText;
    }
}

