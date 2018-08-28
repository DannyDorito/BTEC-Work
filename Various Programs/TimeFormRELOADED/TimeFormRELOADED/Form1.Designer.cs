namespace TimeFormRELOADED
{
    partial class Form1
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
            this.picStan = new System.Windows.Forms.PictureBox();
            this.tmrAnimate = new System.Windows.Forms.Timer(this.components);
            this.btnMove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picStan)).BeginInit();
            this.SuspendLayout();
            // 
            // picStan
            // 
            this.picStan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picStan.Image = global::TimeFormRELOADED.Properties.Resources.MegaStan;
            this.picStan.Location = new System.Drawing.Point(0, 0);
            this.picStan.Name = "picStan";
            this.picStan.Size = new System.Drawing.Size(155, 75);
            this.picStan.TabIndex = 0;
            this.picStan.TabStop = false;
            // 
            // tmrAnimate
            // 
            this.tmrAnimate.Enabled = true;
            this.tmrAnimate.Tick += new System.EventHandler(this.tmrAnimate_Tick);
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(12, 285);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(657, 62);
            this.btnMove.TabIndex = 1;
            this.btnMove.Text = "Stop";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 359);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.picStan);
            this.Name = "Form1";
            this.Text = "Mega Stan";
            ((System.ComponentModel.ISupportInitialize)(this.picStan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picStan;
        private System.Windows.Forms.Timer tmrAnimate;
        private System.Windows.Forms.Button btnMove;
    }
}

