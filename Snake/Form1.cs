using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
	public partial class SnakeGame : Form
	{
		private List<Circle> Snake = new List<Circle>();

		private Circle food = new Circle();

		int maxWidth;
		int maxHeight;
		int higScore;
		int score;

		Random rand = new Random();

		bool goLeft, goRight, goUp, goDown;

		public SnakeGame()
		{
			InitializeComponent();

			new Settings();
		}

		private void KeyIsDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Left && Settings.directions != "right")// allows to move left but stops from going right over the body
			{
				goLeft = true;
			}
			if (e.KeyCode == Keys.Right && Settings.directions != "left")
			{
				goRight = true;
			}
			if (e.KeyCode == Keys.Up && Settings.directions != "down")
			{
				goUp = true;
			}
			if (e.KeyCode == Keys.Down && Settings.directions != "Up")
			{
				goDown = true;
			}
		}

		private void KeyIsUp(object sender, KeyEventArgs e)
		{

			if (e.KeyCode == Keys.Left )
			{ 
				goLeft = false;
			}
			if (e.KeyCode == Keys.Right )
			{
				goRight = false;
			}
			if (e.KeyCode == Keys.Up)
			{
				goUp = false;
			}
			if (e.KeyCode == Keys.Down)
			{
				goDown = false;
			}
		}

		private void StartGame(object sender, EventArgs e)
		{
			RestartGame();
		}

		private void TakeSnapshot(object sender, EventArgs e)
		{

		}

		private void GameTimerEven(object sender, EventArgs e)
		{
			if (goLeft)
			{
				Settings.directions = "left";
			}
			if (goRight)
			{
				Settings.directions = "right";
			}
			if (goUp)
			{
				Settings.directions = "Up";
			}
			if (goDown)
			{
				Settings.directions = "down";
			}

			for (int i = Snake.Count - 1; i >= 0; i--)
			{
				if (i == 0)
				{
					switch (Settings.directions)
					{
						case "left":
							Snake[i].X--;
							break;
						case "right":
							Snake[i].X++;
							break;
						case "up":
							Snake[i].Y--;
							break;
						case "down":
							Snake[i].Y++;
							break;
					}
				}
			}
		}

		private void UpdatePictureBoxGFX(object sender, PaintEventArgs e)
		{
			Graphics canvas = e.Graphics;

			Brush snakeColour;

			for (int i = 0; i < Snake.Count; i++) 
			{
				if (i == 0)
				{
					snakeColour =Brushes.Black;
				}
				else
				{
					snakeColour = Brushes.Blue;
				}

				canvas.FillEllipse(snakeColour, new Rectangle
						(
							Snake[i].X * Settings.Width,
							Snake[i].Y * Settings.Height,
							Settings.Width, Settings.Height
						));
			}
			canvas.FillEllipse(Brushes.DarkRed, new Rectangle
						(
							food.X * Settings.Width,
							food.Y * Settings.Height,
							Settings.Width, Settings.Height
						));

		}

		private void RestartGame() 
		{
			maxWidth = pictureSnake.Width / Settings.Width - 1;
			maxHeight = pictureSnake.Height / Settings.Height - 1; 

			Snake.Clear();

			Startbtn.Enabled = false;
			Snapbtn.Enabled = false;

			score = 0;
			txtScore.Text = "Score: " + score;

			Circle head = new Circle { X = 10, Y = 5 };
			Snake.Add(head); //At head to the snake list

			for (int i = 0; i < 10; i++;)
			{
				Circle body = new Circle();
				Snake.Add(body);
			}

			food = new Circle { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight)};

			GameTimer.Start();

		}
		private void EatFood() 
		{	
			
		}
		private void GameOver() 
		{
			
		}
	}
}
