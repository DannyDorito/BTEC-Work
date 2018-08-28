namespace Backwards
{
    partial class Backwards
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
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.tmr1 = new System.Windows.Forms.Timer(this.components);
            this.rtbTimer = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbOutput
            // 
            this.rtbOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbOutput.Location = new System.Drawing.Point(12, 12);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(580, 400);
            this.rtbOutput.TabIndex = 0;
            this.rtbOutput.Text = "Type in here to reverse the text";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 476);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(580, 86);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Reverse";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tmr1
            // 
            this.tmr1.Interval = 1000;
            this.tmr1.Tick += new System.EventHandler(this.tmr1_Tick);
            // 
            // rtbTimer
            // 
            this.rtbTimer.Enabled = false;
            this.rtbTimer.Location = new System.Drawing.Point(12, 418);
            this.rtbTimer.Name = "rtbTimer";
            this.rtbTimer.Size = new System.Drawing.Size(580, 52);
            this.rtbTimer.TabIndex = 0;
            this.rtbTimer.TabStop = false;
            this.rtbTimer.Text = "10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 574);
            this.Controls.Add(this.rtbTimer);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.rtbOutput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Backwards";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer tmr1;
        private System.Windows.Forms.RichTextBox rtbTimer;
    }
}

