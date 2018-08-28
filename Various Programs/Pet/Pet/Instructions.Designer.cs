namespace WindowsFormsApplication1
{
    partial class Instructions
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
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.btnDisagree = new System.Windows.Forms.Button();
            this.btnAgree = new System.Windows.Forms.Button();
            this.btnChangeName = new System.Windows.Forms.Button();
            this.rtbChangeName = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbText
            // 
            this.rtbText.Location = new System.Drawing.Point(9, 12);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(204, 291);
            this.rtbText.TabIndex = 0;
            this.rtbText.Text = "\n";
            this.rtbText.TextChanged += new System.EventHandler(this.rtbText_TextChanged);
            // 
            // btnDisagree
            // 
            this.btnDisagree.Location = new System.Drawing.Point(9, 309);
            this.btnDisagree.Name = "btnDisagree";
            this.btnDisagree.Size = new System.Drawing.Size(99, 33);
            this.btnDisagree.TabIndex = 12;
            this.btnDisagree.Text = "I Disagree";
            this.btnDisagree.UseVisualStyleBackColor = true;
            // 
            // btnAgree
            // 
            this.btnAgree.Location = new System.Drawing.Point(114, 309);
            this.btnAgree.Name = "btnAgree";
            this.btnAgree.Size = new System.Drawing.Size(99, 33);
            this.btnAgree.TabIndex = 13;
            this.btnAgree.Text = "I Agree";
            this.btnAgree.UseVisualStyleBackColor = true;
            this.btnAgree.Click += new System.EventHandler(this.btnAgree_Click);
            // 
            // btnChangeName
            // 
            this.btnChangeName.Location = new System.Drawing.Point(114, 348);
            this.btnChangeName.Name = "btnChangeName";
            this.btnChangeName.Size = new System.Drawing.Size(99, 33);
            this.btnChangeName.TabIndex = 14;
            this.btnChangeName.Text = "Change Name";
            this.btnChangeName.UseVisualStyleBackColor = true;
            // 
            // rtbChangeName
            // 
            this.rtbChangeName.Location = new System.Drawing.Point(9, 348);
            this.rtbChangeName.Name = "rtbChangeName";
            this.rtbChangeName.Size = new System.Drawing.Size(99, 33);
            this.rtbChangeName.TabIndex = 18;
            this.rtbChangeName.Text = "";
            // 
            // Instructions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 430);
            this.Controls.Add(this.rtbChangeName);
            this.Controls.Add(this.btnChangeName);
            this.Controls.Add(this.btnAgree);
            this.Controls.Add(this.btnDisagree);
            this.Controls.Add(this.rtbText);
            this.Name = "Instructions";
            this.Text = "Instructions";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDisagree;
        private System.Windows.Forms.Button btnAgree;
        public System.Windows.Forms.RichTextBox rtbText;
        private System.Windows.Forms.Button btnChangeName;
        private System.Windows.Forms.RichTextBox rtbChangeName;
    }
}