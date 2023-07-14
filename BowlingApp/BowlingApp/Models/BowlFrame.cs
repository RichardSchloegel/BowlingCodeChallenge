using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingApp.Models
{
	public class BowlFrame
	{
		private Turn[] _turns;
		private string _score;
		private int _scoreValue;

		public BowlFrame() 
		{
			_turns = new Turn[3];
			for (int i = 0; i < _turns.Length; i++)
			{
				_turns[i] = new Turn();
			}
		}

		public Turn[] Turns
		{
			get { return _turns; }
			set { _turns = value; }
		}

		public string Score
		{
			get { return _score; }
			set { _score = value; }
		}

		public int ScoreValue
		{
			get { return _scoreValue; }
			set { _scoreValue = value; }
		}

	}
}
