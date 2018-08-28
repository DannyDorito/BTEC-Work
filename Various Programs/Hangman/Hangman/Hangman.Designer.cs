namespace Hangman
{
    partial class Hangman
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
            this.btnStart = new System.Windows.Forms.Button();
            this.rtbInput = new System.Windows.Forms.RichTextBox();
            this.rtbLives = new System.Windows.Forms.RichTextBox();
            this.rtbStart = new System.Windows.Forms.RichTextBox();
            this.btnInput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(592, 105);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(130, 47);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // rtbInput
            // 
            this.rtbInput.Enabled = false;
            this.rtbInput.Location = new System.Drawing.Point(199, 55);
            this.rtbInput.Name = "rtbInput";
            this.rtbInput.Size = new System.Drawing.Size(387, 97);
            this.rtbInput.TabIndex = 1;
            this.rtbInput.Text = "";
            // 
            // rtbLives
            // 
            this.rtbLives.Location = new System.Drawing.Point(12, 53);
            this.rtbLives.Name = "rtbLives";
            this.rtbLives.Size = new System.Drawing.Size(181, 97);
            this.rtbLives.TabIndex = 4;
            this.rtbLives.Text = "5";
            // 
            // rtbStart
            // 
            this.rtbStart.Enabled = false;
            this.rtbStart.Location = new System.Drawing.Point(199, 12);
            this.rtbStart.Name = "rtbStart";
            this.rtbStart.Size = new System.Drawing.Size(386, 35);
            this.rtbStart.TabIndex = 7;
            this.rtbStart.Text = "To start, press the START button.";
            // 
            // btnInput
            // 
            this.btnInput.Enabled = false;
            this.btnInput.Location = new System.Drawing.Point(592, 55);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(130, 44);
            this.btnInput.TabIndex = 8;
            this.btnInput.Text = "Make Guess";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 171);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.rtbStart);
            this.Controls.Add(this.rtbLives);
            this.Controls.Add(this.rtbInput);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Hengmen hEron";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.RichTextBox rtbInput;
        private System.Windows.Forms.RichTextBox rtbLives;
        private System.Windows.Forms.RichTextBox rtbStart;
        private System.Windows.Forms.Button btnInput;
    }
}

