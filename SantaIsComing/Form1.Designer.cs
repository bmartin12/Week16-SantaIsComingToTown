namespace SantaIsComing
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Ground = new System.Windows.Forms.PictureBox();
            this.Moon = new System.Windows.Forms.PictureBox();
            this.Hut = new System.Windows.Forms.PictureBox();
            this.Tree = new System.Windows.Forms.PictureBox();
            this.Snowflake = new System.Windows.Forms.PictureBox();
            this.ScoreBoard = new System.Windows.Forms.Label();
            this.Santa = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PlayAgain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Moon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Snowflake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Santa)).BeginInit();
            this.SuspendLayout();
            // 
            // Ground
            // 
            this.Ground.Image = ((System.Drawing.Image)(resources.GetObject("Ground.Image")));
            this.Ground.Location = new System.Drawing.Point(-2, 385);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(806, 64);
            this.Ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ground.TabIndex = 0;
            this.Ground.TabStop = false;
            this.Ground.Click += new System.EventHandler(this.Ground_Click);
            // 
            // Moon
            // 
            this.Moon.Image = ((System.Drawing.Image)(resources.GetObject("Moon.Image")));
            this.Moon.Location = new System.Drawing.Point(664, 12);
            this.Moon.Name = "Moon";
            this.Moon.Size = new System.Drawing.Size(124, 77);
            this.Moon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Moon.TabIndex = 1;
            this.Moon.TabStop = false;
            this.Moon.Click += new System.EventHandler(this.Moon_Click);
            // 
            // Hut
            // 
            this.Hut.BackColor = System.Drawing.Color.Transparent;
            this.Hut.Image = ((System.Drawing.Image)(resources.GetObject("Hut.Image")));
            this.Hut.Location = new System.Drawing.Point(194, 288);
            this.Hut.Name = "Hut";
            this.Hut.Size = new System.Drawing.Size(125, 120);
            this.Hut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Hut.TabIndex = 2;
            this.Hut.TabStop = false;
            this.Hut.Click += new System.EventHandler(this.Hut_Click);
            // 
            // Tree
            // 
            this.Tree.BackColor = System.Drawing.Color.Transparent;
            this.Tree.Image = ((System.Drawing.Image)(resources.GetObject("Tree.Image")));
            this.Tree.Location = new System.Drawing.Point(688, 239);
            this.Tree.Name = "Tree";
            this.Tree.Size = new System.Drawing.Size(100, 169);
            this.Tree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Tree.TabIndex = 3;
            this.Tree.TabStop = false;
            this.Tree.Click += new System.EventHandler(this.Tree_Click);
            // 
            // Snowflake
            // 
            this.Snowflake.Image = ((System.Drawing.Image)(resources.GetObject("Snowflake.Image")));
            this.Snowflake.Location = new System.Drawing.Point(521, 126);
            this.Snowflake.Name = "Snowflake";
            this.Snowflake.Size = new System.Drawing.Size(51, 50);
            this.Snowflake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Snowflake.TabIndex = 4;
            this.Snowflake.TabStop = false;
            this.Snowflake.Click += new System.EventHandler(this.Snowflake_Click);
            // 
            // ScoreBoard
            // 
            this.ScoreBoard.AutoSize = true;
            this.ScoreBoard.Font = new System.Drawing.Font("Vineta BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ScoreBoard.Location = new System.Drawing.Point(40, 30);
            this.ScoreBoard.Name = "ScoreBoard";
            this.ScoreBoard.Size = new System.Drawing.Size(112, 29);
            this.ScoreBoard.TabIndex = 5;
            this.ScoreBoard.Text = "Score:";
            this.ScoreBoard.Click += new System.EventHandler(this.ScoreBoard_Click);
            // 
            // Santa
            // 
            this.Santa.Image = ((System.Drawing.Image)(resources.GetObject("Santa.Image")));
            this.Santa.Location = new System.Drawing.Point(51, 125);
            this.Santa.Name = "Santa";
            this.Santa.Size = new System.Drawing.Size(156, 74);
            this.Santa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Santa.TabIndex = 6;
            this.Santa.TabStop = false;
            this.Santa.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PlayAgain
            // 
            this.PlayAgain.Font = new System.Drawing.Font("Vineta BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayAgain.Location = new System.Drawing.Point(370, 176);
            this.PlayAgain.Name = "PlayAgain";
            this.PlayAgain.Size = new System.Drawing.Size(75, 23);
            this.PlayAgain.TabIndex = 7;
            this.PlayAgain.Text = "PLAY AGAIN";
            this.PlayAgain.UseVisualStyleBackColor = true;
            this.PlayAgain.Click += new System.EventHandler(this.PlayAgain_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PlayAgain);
            this.Controls.Add(this.Santa);
            this.Controls.Add(this.ScoreBoard);
            this.Controls.Add(this.Snowflake);
            this.Controls.Add(this.Tree);
            this.Controls.Add(this.Hut);
            this.Controls.Add(this.Moon);
            this.Controls.Add(this.Ground);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Moon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Snowflake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Santa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.PictureBox Moon;
        private System.Windows.Forms.PictureBox Hut;
        private System.Windows.Forms.PictureBox Tree;
        private System.Windows.Forms.PictureBox Snowflake;
        private System.Windows.Forms.Label ScoreBoard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Santa;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button PlayAgain;
    }
}

