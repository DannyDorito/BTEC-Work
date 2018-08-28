namespace Compliment
{
    partial class Compliment
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.rtbName = new System.Windows.Forms.RichTextBox();
            this.rtbGender = new System.Windows.Forms.RichTextBox();
            this.rtbAge = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(21, 18);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(86, 31);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Name";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(3, 84);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(104, 31);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Gender";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(45, 150);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(62, 31);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "Age";
            // 
            // rtbName
            // 
            this.rtbName.Location = new System.Drawing.Point(113, 18);
            this.rtbName.Name = "rtbName";
            this.rtbName.Size = new System.Drawing.Size(299, 60);
            this.rtbName.TabIndex = 3;
            this.rtbName.Text = "";
            // 
            // rtbGender
            // 
            this.rtbGender.Location = new System.Drawing.Point(113, 84);
            this.rtbGender.Name = "rtbGender";
            this.rtbGender.Size = new System.Drawing.Size(299, 60);
            this.rtbGender.TabIndex = 4;
            this.rtbGender.Text = "";
            // 
            // rtbAge
            // 
            this.rtbAge.Location = new System.Drawing.Point(113, 150);
            this.rtbAge.Name = "rtbAge";
            this.rtbAge.Size = new System.Drawing.Size(299, 60);
            this.rtbAge.TabIndex = 5;
            this.rtbAge.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(3, 216);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(409, 81);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Compliment Me";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rtbOutput
            // 
            this.rtbOutput.Enabled = false;
            this.rtbOutput.Location = new System.Drawing.Point(3, 305);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(408, 138);
            this.rtbOutput.TabIndex = 7;
            this.rtbOutput.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 454);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rtbAge);
            this.Controls.Add(this.rtbGender);
            this.Controls.Add(this.rtbName);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Compliment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.RichTextBox rtbName;
        private System.Windows.Forms.RichTextBox rtbGender;
        private System.Windows.Forms.RichTextBox rtbAge;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RichTextBox rtbOutput;
    }
}

