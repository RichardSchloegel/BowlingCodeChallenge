using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace BowlingApp.Models
{
	public class Scoreboard
	{
		private BowlFrame[] _frames;
		private int _currentTurn;
		private string _totalScore;


		public Scoreboard()
		{
			Frames = new BowlFrame[10];
			for (int i = 0; i < _frames.Length; i++)
			{
				Frames[i] = new BowlFrame();
				Frames[i].Score = "0";
			}
			Frames[0].Turns[0].IsReadOnly = false;
			Frames[0].Turns[0].IsTurn = true;
		}

		public BowlFrame[] Frames
		{
			get { return _frames; }
			set { _frames = value; }
		}

		public int CurrentTurn
		{
			get { return _currentTurn; }
			set { _currentTurn = value; }
		}
		
		public string TotalScore
		{
			get { return _totalScore; }
			set { _totalScore = value; }
		}

		public void UpdateTotalScore()
		{
			var totalScoreValue = 0;
			for (int i = 0; i < Frames.Length; i++)
			{
				totalScoreValue += Frames[i].ScoreValue;
			}
			TotalScore = totalScoreValue.ToString();
		}
		public void UpdateFrameScores()
		{
			for (int i = 0; i < Frames.Length; i++)
			{
				if (i == 9)
				{
					Frames[i].ScoreValue = Frames[i].Turns[0].ScoreValue + Frames[i].Turns[1].ScoreValue + Frames[i].Turns[2].ScoreValue;
					Frames[i].Score = Frames[i].ScoreValue.ToString();
				}
				else if (i == 8)
				{
					if (Frames[i].Turns[0].IsStrike)
					{
						Frames[i].ScoreValue = Frames[i].Turns[0].ScoreValue + Frames[i + 1].Turns[0].ScoreValue + Frames[i + 1].Turns[1].ScoreValue;
						Frames[i].Score = Frames[i].ScoreValue.ToString();
					}
					else if (Frames[i].Turns[1].IsSpare)
					{
						Frames[i].ScoreValue = Frames[i].Turns[0].ScoreValue + Frames[i].Turns[1].ScoreValue + Frames[i + 1].Turns[0].ScoreValue;
						Frames[i].Score = Frames[i].ScoreValue.ToString();
					}
				}
				else if (Frames[i].Turns[0].IsStrike)
				{
					if (Frames[i + 1].Turns[0].IsStrike)
					{
						Frames[i].ScoreValue = Frames[i].Turns[0].ScoreValue + Frames[i + 1].Turns[0].ScoreValue + Frames[i + 2].Turns[0].ScoreValue;
						Frames[i].Score = Frames[i].ScoreValue.ToString();
					}
					else
					{
						Frames[i].ScoreValue = Frames[i].Turns[0].ScoreValue + Frames[i + 1].Turns[0].ScoreValue + Frames[i + 1].Turns[1].ScoreValue;
						Frames[i].Score = Frames[i].ScoreValue.ToString();
					}
				}
				else if (Frames[i].Turns[1].IsSpare)
				{
					Frames[i].ScoreValue = Frames[i].Turns[0].ScoreValue + Frames[i].Turns[1].ScoreValue + Frames[i + 1].Turns[0].ScoreValue;
					Frames[i].Score = Frames[i].ScoreValue.ToString();
				}
				else
				{
					Frames[i].ScoreValue = Frames[i].Turns[0].ScoreValue + Frames[i].Turns[1].ScoreValue;
					Frames[i].Score = Frames[i].ScoreValue.ToString();
				}
			}
		}
		public void UpdateTurnFocus(int frameIndex, int turnIndex, bool isStrike)
		{
			Frames[frameIndex].Turns[turnIndex].IsTurn = false;
			Frames[frameIndex].Turns[turnIndex].IsReadOnly = true;
			if (frameIndex == 9)
			{
				if (turnIndex == 2)
				{
					// End Game
				}
				else if (turnIndex == 1)
				{
					if(Frames[frameIndex].Turns[turnIndex].IsStrike || Frames[frameIndex].Turns[turnIndex].IsSpare)
					{
						Frames[frameIndex].Turns[turnIndex + 1].IsReadOnly = false;
						Frames[frameIndex].Turns[turnIndex + 1].IsTurn = true;

					}
					else
					{
						//End Game
					}
				}
				else
				{
					Frames[frameIndex].Turns[turnIndex + 1].IsReadOnly = false;
					Frames[frameIndex].Turns[turnIndex + 1].IsTurn = true;
				}
			}
			else 
			{
				if (turnIndex == 0)
				{
					if (Frames[frameIndex].Turns[turnIndex].IsStrike)
					{
						Frames[frameIndex + 1].Turns[0].IsReadOnly = false;
						Frames[frameIndex + 1].Turns[0].IsTurn = true;
					}
					else
					{
						Frames[frameIndex].Turns[turnIndex + 1].IsReadOnly = false;
						Frames[frameIndex].Turns[turnIndex+1].IsTurn = true;
					}
				}
				else
				{
					Frames[frameIndex + 1].Turns[0].IsReadOnly = false;
					Frames[frameIndex+1].Turns[0].IsTurn = true;
				}
			}
		}
		public void UpdateScore(int frameIndex, int turnIndex, string value)
		{
			Frames[frameIndex].Turns[turnIndex].Score = value;
			if (value == "1")
			{
				if (turnIndex == 1 && Frames[frameIndex].Turns[turnIndex-1].ScoreValue+1==10)
				{
					Frames[frameIndex].Turns[turnIndex].IsSpare = true;
				}
				Frames[frameIndex].Turns[turnIndex].ScoreValue = 1;
				UpdateTurnFocus(frameIndex, turnIndex, false);
			}
			else if (value == "2")
			{
				if (turnIndex == 1 && Frames[frameIndex].Turns[turnIndex - 1].ScoreValue + 2 == 10)
				{
					Frames[frameIndex].Turns[turnIndex].IsSpare = true;
				}
				Frames[frameIndex].Turns[turnIndex].ScoreValue = 2;
				UpdateTurnFocus(frameIndex, turnIndex, false);
			}
			else if (value == "3")
			{
				if (turnIndex == 1 && Frames[frameIndex].Turns[turnIndex - 1].ScoreValue + 3 == 10)
				{
					Frames[frameIndex].Turns[turnIndex].IsSpare = true;
				}
				Frames[frameIndex].Turns[turnIndex].ScoreValue = 3;
				UpdateTurnFocus(frameIndex, turnIndex, false);
			}
			else if (value == "4")
			{
				if (turnIndex == 1 && Frames[frameIndex].Turns[turnIndex - 1].ScoreValue + 4 == 10)
				{
					Frames[frameIndex].Turns[turnIndex].IsSpare = true;
				}
				Frames[frameIndex].Turns[turnIndex].ScoreValue = 4;
				UpdateTurnFocus(frameIndex, turnIndex, false);
			}
			else if (value == "5")
			{
				if (turnIndex == 1 && Frames[frameIndex].Turns[turnIndex - 1].ScoreValue + 5 == 10)
				{
					Frames[frameIndex].Turns[turnIndex].IsSpare = true;
				}
				Frames[frameIndex].Turns[turnIndex].ScoreValue = 5;
				UpdateTurnFocus(frameIndex, turnIndex, false);
			}
			else if (value == "6")
			{
				if (turnIndex == 1 && Frames[frameIndex].Turns[turnIndex - 1].ScoreValue + 6 == 10)
				{
					Frames[frameIndex].Turns[turnIndex].IsSpare = true;
				}
				Frames[frameIndex].Turns[turnIndex].ScoreValue = 6;
				UpdateTurnFocus(frameIndex, turnIndex, false);
			}
			else if (value == "7")
			{
				if (turnIndex == 1 && Frames[frameIndex].Turns[turnIndex - 1].ScoreValue + 7 == 10)
				{
					Frames[frameIndex].Turns[turnIndex].IsSpare = true;
				}
				Frames[frameIndex].Turns[turnIndex].ScoreValue = 7;
				UpdateTurnFocus(frameIndex, turnIndex, false);
			}
			else if (value == "8")
			{
				if (turnIndex == 1 && Frames[frameIndex].Turns[turnIndex - 1].ScoreValue + 8 == 10)
				{
					Frames[frameIndex].Turns[turnIndex].IsSpare = true;
				}
				Frames[frameIndex].Turns[turnIndex].ScoreValue = 8;
				UpdateTurnFocus(frameIndex, turnIndex, false);
			}
			else if (value == "9")
			{
				if (turnIndex == 1 && Frames[frameIndex].Turns[turnIndex - 1].ScoreValue + 9 == 10)
				{
					Frames[frameIndex].Turns[turnIndex].IsSpare = true;
				}
				Frames[frameIndex].Turns[turnIndex].ScoreValue = 9;
				UpdateTurnFocus(frameIndex, turnIndex, false);
			}
			else if (value == "/")
			{
				if (turnIndex == 1)
				{
					Frames[frameIndex].Turns[turnIndex].ScoreValue = 10 - Frames[frameIndex].Turns[turnIndex - 1].ScoreValue;
					Frames[frameIndex].Turns[turnIndex].IsSpare = true;
					UpdateTurnFocus(frameIndex, turnIndex, false);
				}
			}
			else if (value == "x" || value == "X")
			{
				if (turnIndex == 0 || turnIndex == 1 && frameIndex == 9)
				{
					Frames[frameIndex].Turns[turnIndex].ScoreValue = 10;
					Frames[frameIndex].Turns[turnIndex].IsStrike = true;
					UpdateTurnFocus(frameIndex, turnIndex, true);
				}
			}
			UpdateFrameScores();
			UpdateTotalScore();
		}
	}
}
