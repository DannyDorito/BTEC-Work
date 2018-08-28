namespace WindowsFormsApplication1
{
    partial class Pet
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
            this.rtbFood = new System.Windows.Forms.RichTextBox();
            this.rtbWater = new System.Windows.Forms.RichTextBox();
            this.rtbWeight = new System.Windows.Forms.RichTextBox();
            this.rtbPlay = new System.Windows.Forms.RichTextBox();
            this.rtbAge = new System.Windows.Forms.RichTextBox();
            this.btnFood = new System.Windows.Forms.Button();
            this.btnWater = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rtbName = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tmr1 = new System.Windows.Forms.Timer(this.components);
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnPullName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbFood
            // 
            this.rtbFood.Enabled = false;
            this.rtbFood.Location = new System.Drawing.Point(489, 52);
            this.rtbFood.Name = "rtbFood";
            this.rtbFood.Size = new System.Drawing.Size(99, 33);
            this.rtbFood.TabIndex = 0;
            this.rtbFood.Text = "50";
            // 
            // rtbWater
            // 
            this.rtbWater.Enabled = false;
            this.rtbWater.Location = new System.Drawing.Point(489, 91);
            this.rtbWater.Name = "rtbWater";
            this.rtbWater.Size = new System.Drawing.Size(99, 33);
            this.rtbWater.TabIndex = 1;
            this.rtbWater.Text = "50";
            // 
            // rtbWeight
            // 
            this.rtbWeight.Enabled = false;
            this.rtbWeight.Location = new System.Drawing.Point(489, 130);
            this.rtbWeight.Name = "rtbWeight";
            this.rtbWeight.Size = new System.Drawing.Size(99, 33);
            this.rtbWeight.TabIndex = 2;
            this.rtbWeight.Text = "50";
            // 
            // rtbPlay
            // 
            this.rtbPlay.Enabled = false;
            this.rtbPlay.Location = new System.Drawing.Point(489, 169);
            this.rtbPlay.Name = "rtbPlay";
            this.rtbPlay.Size = new System.Drawing.Size(99, 33);
            this.rtbPlay.TabIndex = 3;
            this.rtbPlay.Text = "50";
            // 
            // rtbAge
            // 
            this.rtbAge.Enabled = false;
            this.rtbAge.Location = new System.Drawing.Point(489, 208);
            this.rtbAge.Name = "rtbAge";
            this.rtbAge.Size = new System.Drawing.Size(99, 33);
            this.rtbAge.TabIndex = 4;
            this.rtbAge.Text = "5";
            // 
            // btnFood
            // 
            this.btnFood.Enabled = false;
            this.btnFood.Location = new System.Drawing.Point(12, 12);
            this.btnFood.Name = "btnFood";
            this.btnFood.Size = new System.Drawing.Size(99, 33);
            this.btnFood.TabIndex = 6;
            this.btnFood.Text = "Feed";
            this.btnFood.UseVisualStyleBackColor = true;
            this.btnFood.Click += new System.EventHandler(this.btnFood_Click);
            // 
            // btnWater
            // 
            this.btnWater.Enabled = false;
            this.btnWater.Location = new System.Drawing.Point(12, 51);
            this.btnWater.Name = "btnWater";
            this.btnWater.Size = new System.Drawing.Size(99, 33);
            this.btnWater.TabIndex = 7;
            this.btnWater.Text = "Drink";
            this.btnWater.UseVisualStyleBackColor = true;
            this.btnWater.Click += new System.EventHandler(this.btnWater_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Enabled = false;
            this.btnPlay.Location = new System.Drawing.Point(12, 90);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(99, 33);
            this.btnPlay.TabIndex = 8;
            this.btnPlay.Text = "Exercise";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnExercise_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 205);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(99, 33);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(422, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Food";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(414, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Water";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(404, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Weight";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(429, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Play";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(433, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Age";
            // 
            // rtbName
            // 
            this.rtbName.Location = new System.Drawing.Point(489, 13);
            this.rtbName.Name = "rtbName";
            this.rtbName.Size = new System.Drawing.Size(99, 33);
            this.rtbName.TabIndex = 17;
            this.rtbName.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(415, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Name";
            // 
            // tmr1
            // 
            this.tmr1.Interval = 5000;
            this.tmr1.Tick += new System.EventHandler(this.tmr1_Tick);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(12, 130);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(99, 33);
            this.btnHelp.TabIndex = 19;
            this.btnHelp.Text = "Instructions";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnInstructions_Click);
            // 
            // MrGoochForum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 250);
            this.Controls.Add(this.btnPullName);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnWater);
            this.Controls.Add(this.btnFood);
            this.Controls.Add(this.rtbAge);
            this.Controls.Add(this.rtbPlay);
            this.Controls.Add(this.rtbWeight);
            this.Controls.Add(this.rtbWater);
            this.Controls.Add(this.rtbFood);
            this.Name = "MrGoochForum";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbFood;
        private System.Windows.Forms.RichTextBox rtbWater;
        private System.Windows.Forms.RichTextBox rtbWeight;
        private System.Windows.Forms.RichTextBox rtbPlay;
        private System.Windows.Forms.RichTextBox rtbAge;
        private System.Windows.Forms.Button btnFood;
        private System.Windows.Forms.Button btnWater;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer tmr1;
        private System.Windows.Forms.Button btnHelp;
        public System.Windows.Forms.RichTextBox rtbName;
        public System.Windows.Forms.Button btnPullName;
    }
}

