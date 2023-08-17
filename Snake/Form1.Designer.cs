namespace Snake
{
	partial class SnakeGame
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
			this.pictureSnake = new System.Windows.Forms.PictureBox();
			this.Startbtn = new System.Windows.Forms.Button();
			this.Snapbtn = new System.Windows.Forms.Button();
			this.txtScore = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.GameTimer = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pictureSnake)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureSnake
			// 
			this.pictureSnake.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.pictureSnake.Location = new System.Drawing.Point(12, 12);
			this.pictureSnake.Name = "pictureSnake";
			this.pictureSnake.Size = new System.Drawing.Size(587, 737);
			this.pictureSnake.TabIndex = 0;
			this.pictureSnake.TabStop = false;
			this.pictureSnake.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdatePictureBoxGFX);
			// 
			// Startbtn
			// 
			this.Startbtn.BackColor = System.Drawing.Color.Turquoise;
			this.Startbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Startbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Startbtn.Location = new System.Drawing.Point(635, 22);
			this.Startbtn.Name = "Startbtn";
			this.Startbtn.Size = new System.Drawing.Size(122, 43);
			this.Startbtn.TabIndex = 1;
			this.Startbtn.Text = "START";
			this.Startbtn.UseVisualStyleBackColor = false;
			this.Startbtn.Click += new System.EventHandler(this.StartGame);
			// 
			// Snapbtn
			// 
			this.Snapbtn.BackColor = System.Drawing.Color.Turquoise;
			this.Snapbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Snapbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Snapbtn.Location = new System.Drawing.Point(635, 71);
			this.Snapbtn.Name = "Snapbtn";
			this.Snapbtn.Size = new System.Drawing.Size(122, 43);
			this.Snapbtn.TabIndex = 1;
			this.Snapbtn.Text = "SNAP";
			this.Snapbtn.UseVisualStyleBackColor = false;
			this.Snapbtn.Click += new System.EventHandler(this.TakeSnapshot);
			// 
			// txtScore
			// 
			this.txtScore.AutoSize = true;
			this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtScore.Location = new System.Drawing.Point(632, 131);
			this.txtScore.Name = "txtScore";
			this.txtScore.Size = new System.Drawing.Size(96, 20);
			this.txtScore.TabIndex = 2;
			this.txtScore.Text = "SCORE : 0";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(632, 167);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(147, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "HIGH SCORE : 0";
			// 
			// GameTimer
			// 
			this.GameTimer.Tick += new System.EventHandler(this.GameTimerEven);
			// 
			// SnakeGame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ClientSize = new System.Drawing.Size(803, 761);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtScore);
			this.Controls.Add(this.Snapbtn);
			this.Controls.Add(this.Startbtn);
			this.Controls.Add(this.pictureSnake);
			this.Name = "SnakeGame";
			this.Text = "SnakeGame";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
			((System.ComponentModel.ISupportInitialize)(this.pictureSnake)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureSnake;
		private System.Windows.Forms.Button Startbtn;
		private System.Windows.Forms.Button Snapbtn;
		private System.Windows.Forms.Label txtScore;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Timer GameTimer;
	}
}

