using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingApp.Models
{
	public class Turn
	{
		private string _score;
		private int _scoreValue;
		private bool _isTurn;
		private bool _isReadOnly;
		private bool _isStrike;
		private bool _isSpare;

		public Turn()
		{
			Score = "";
			ScoreValue = 0;
			IsTurn = false;
			IsReadOnly = true;
		}

		public string Score
		{
			get
			{
				return _score;
			}
			set 
			{ 
				_score = value;
			}
		}

		public int ScoreValue
		{
			get { return _scoreValue; }
			set { _scoreValue = value; }
		}

		public bool IsTurn
		{
			get
			{
				return _isTurn;
			}
			set
			{
				_isTurn = value;
			}
		}
		public bool IsReadOnly
		{
			get
			{
				return _isReadOnly;
			}
			set
			{
				_isReadOnly = value;
			}
		}
		public bool IsStrike
		{
			get { return _isStrike; }
			set { _isStrike = value; }
		}

		public bool IsSpare
		{
			get { return _isSpare; }
			set { _isSpare = value; }
		}
	}
}
