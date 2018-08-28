namespace Converter
{
    partial class Converter
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
            this.cmbCurrency1 = new System.Windows.Forms.ComboBox();
            this.cmbCurrency2 = new System.Windows.Forms.ComboBox();
            this.rtbInput = new System.Windows.Forms.RichTextBox();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbCurrency1
            // 
            this.cmbCurrency1.FormattingEnabled = true;
            this.cmbCurrency1.Items.AddRange(new object[] {
            "Euro",
            "Pound"});
            this.cmbCurrency1.Location = new System.Drawing.Point(12, 12);
            this.cmbCurrency1.Name = "cmbCurrency1";
            this.cmbCurrency1.Size = new System.Drawing.Size(185, 21);
            this.cmbCurrency1.TabIndex = 0;
            // 
            // cmbCurrency2
            // 
            this.cmbCurrency2.FormattingEnabled = true;
            this.cmbCurrency2.Items.AddRange(new object[] {
            "Euro",
            "Pound"});
            this.cmbCurrency2.Location = new System.Drawing.Point(290, 12);
            this.cmbCurrency2.Name = "cmbCurrency2";
            this.cmbCurrency2.Size = new System.Drawing.Size(185, 21);
            this.cmbCurrency2.TabIndex = 1;
            // 
            // rtbInput
            // 
            this.rtbInput.Location = new System.Drawing.Point(12, 39);
            this.rtbInput.Name = "rtbInput";
            this.rtbInput.Size = new System.Drawing.Size(184, 105);
            this.rtbInput.TabIndex = 2;
            this.rtbInput.Text = "";
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(290, 39);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(185, 105);
            this.rtbOutput.TabIndex = 3;
            this.rtbOutput.Text = "";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(12, 159);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(463, 52);
            this.btnConvert.TabIndex = 4;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 229);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.rtbInput);
            this.Controls.Add(this.cmbCurrency2);
            this.Controls.Add(this.cmbCurrency1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCurrency1;
        private System.Windows.Forms.ComboBox cmbCurrency2;
        private System.Windows.Forms.RichTextBox rtbInput;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Button btnConvert;
    }
}

