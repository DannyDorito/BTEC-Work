namespace PethTheDogeClassbut
{
    partial class PetClass
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
            this.rtbAge = new System.Windows.Forms.RichTextBox();
            this.rtbHygine = new System.Windows.Forms.RichTextBox();
            this.rtbHunger = new System.Windows.Forms.RichTextBox();
            this.rtbHealth = new System.Windows.Forms.RichTextBox();
            this.rtbName = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tmr_1 = new System.Windows.Forms.Timer(this.components);
            this.btnFeed = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbAge
            // 
            this.rtbAge.Enabled = false;
            this.rtbAge.Location = new System.Drawing.Point(486, 168);
            this.rtbAge.Name = "rtbAge";
            this.rtbAge.Size = new System.Drawing.Size(99, 33);
            this.rtbAge.TabIndex = 9;
            this.rtbAge.Text = "";
            // 
            // rtbHygine
            // 
            this.rtbHygine.Enabled = false;
            this.rtbHygine.Location = new System.Drawing.Point(486, 129);
            this.rtbHygine.Name = "rtbHygine";
            this.rtbHygine.Size = new System.Drawing.Size(99, 33);
            this.rtbHygine.TabIndex = 7;
            this.rtbHygine.Text = "";
            // 
            // rtbHunger
            // 
            this.rtbHunger.Enabled = false;
            this.rtbHunger.Location = new System.Drawing.Point(486, 90);
            this.rtbHunger.Name = "rtbHunger";
            this.rtbHunger.Size = new System.Drawing.Size(99, 33);
            this.rtbHunger.TabIndex = 6;
            this.rtbHunger.Text = "";
            // 
            // rtbHealth
            // 
            this.rtbHealth.Enabled = false;
            this.rtbHealth.Location = new System.Drawing.Point(486, 51);
            this.rtbHealth.Name = "rtbHealth";
            this.rtbHealth.Size = new System.Drawing.Size(99, 33);
            this.rtbHealth.TabIndex = 5;
            this.rtbHealth.Text = "";
            // 
            // rtbName
            // 
            this.rtbName.Location = new System.Drawing.Point(486, 12);
            this.rtbName.Name = "rtbName";
            this.rtbName.Size = new System.Drawing.Size(99, 33);
            this.rtbName.TabIndex = 10;
            this.rtbName.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(445, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(442, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Health";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(438, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Hunger";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(440, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Hygine";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(449, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Age";
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(12, 177);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 16;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(93, 177);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 17;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tmr_1
            // 
            this.tmr_1.Interval = 500;
            this.tmr_1.Tick += new System.EventHandler(this.tmr_1_Tick);
            // 
            // btnFeed
            // 
            this.btnFeed.Location = new System.Drawing.Point(175, 177);
            this.btnFeed.Name = "btnFeed";
            this.btnFeed.Size = new System.Drawing.Size(75, 23);
            this.btnFeed.TabIndex = 19;
            this.btnFeed.Text = "Feed";
            this.btnFeed.Click += new System.EventHandler(this.btnFeed_Click);
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(256, 177);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 23);
            this.btnClean.TabIndex = 20;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 212);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnFeed);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbName);
            this.Controls.Add(this.rtbAge);
            this.Controls.Add(this.rtbHygine);
            this.Controls.Add(this.rtbHunger);
            this.Controls.Add(this.rtbHealth);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.RichTextBox rtbAge;
        public System.Windows.Forms.RichTextBox rtbHygine;
        public System.Windows.Forms.RichTextBox rtbHunger;
        public System.Windows.Forms.RichTextBox rtbHealth;
        public System.Windows.Forms.RichTextBox rtbName;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Timer tmr_1;
        private System.Windows.Forms.Button btnFeed;
        private System.Windows.Forms.Button btnClean;
    }
}

