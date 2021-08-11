namespace flappybird
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.score = new System.Windows.Forms.Label();
            this.pipedown = new System.Windows.Forms.PictureBox();
            this.pipeup = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pipedown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timerevent);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.BackgroundImage = global::flappybird.Properties.Resources.istockphoto_1215293810_640x640;
            this.panel1.Controls.Add(this.score);
            this.panel1.Controls.Add(this.pipedown);
            this.panel1.Controls.Add(this.pipeup);
            this.panel1.Controls.Add(this.ground);
            this.panel1.Controls.Add(this.flappyBird);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 398);
            this.panel1.TabIndex = 3;
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.BackColor = System.Drawing.Color.Transparent;
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.score.ForeColor = System.Drawing.Color.Black;
            this.score.Location = new System.Drawing.Point(42, 32);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(107, 31);
            this.score.TabIndex = 5;
            this.score.Text = "Score : ";
            // 
            // pipedown
            // 
            this.pipedown.Image = global::flappybird.Properties.Resources.Untitled_1;
            this.pipedown.Location = new System.Drawing.Point(225, 241);
            this.pipedown.Name = "pipedown";
            this.pipedown.Size = new System.Drawing.Size(60, 131);
            this.pipedown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pipedown.TabIndex = 4;
            this.pipedown.TabStop = false;
            // 
            // pipeup
            // 
            this.pipeup.Image = global::flappybird.Properties.Resources.Untitled_2;
            this.pipeup.Location = new System.Drawing.Point(289, 0);
            this.pipeup.Name = "pipeup";
            this.pipeup.Size = new System.Drawing.Size(57, 118);
            this.pipeup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pipeup.TabIndex = 3;
            this.pipeup.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = global::flappybird.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(0, 372);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(572, 23);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 1;
            this.ground.TabStop = false;
            // 
            // flappyBird
            // 
            this.flappyBird.BackColor = System.Drawing.Color.Transparent;
            this.flappyBird.Image = global::flappybird.Properties.Resources.flppy;
            this.flappyBird.Location = new System.Drawing.Point(90, 140);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(108, 73);
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.flappyBird.TabIndex = 2;
            this.flappyBird.TabStop = false;
            this.flappyBird.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(573, 394);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keydown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyup);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pipedown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pipeup;
        private System.Windows.Forms.PictureBox pipedown;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Timer timer1;
    }
}

