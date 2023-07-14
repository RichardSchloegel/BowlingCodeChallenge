using BowlingApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace BowlingApp.ViewModels
{
	public class ScoreboardViewModel : ViewModelBase
	{
		private Scoreboard _scoreboard;
		private ICommand _resetCommand;

		private string _turn1;
		private string _turn2;
		private string _turn3;
		private string _turn4;
		private string _turn5;
		private string _turn6;
		private string _turn7;
		private string _turn8;
		private string _turn9;
		private string _turn10;
		private string _turn11;
		private string _turn12;
		private string _turn13;
		private string _turn14;
		private string _turn15;
		private string _turn16;
		private string _turn17;
		private string _turn18;
		private string _turn19;
		private string _turn20;
		private string _turn21;

		public ScoreboardViewModel()
		{
			Scoreboard = new Scoreboard();
		}

		public ICommand ResetCommand
		{
			get
			{
				return _resetCommand ?? (_resetCommand = new RelayCommand(() => Reset(), () => CanExecute));
			}
		}

		public bool CanExecute
		{
			get
			{
				return true;
			}
		}
		public void Reset()
		{
			Scoreboard = new Scoreboard();
			Turn1 = "";
			Turn2 = "";
			Turn3 = "";
			Turn4 = "";
			Turn5 = "";
			Turn6 = "";
			Turn7 = "";
			Turn8 = "";
			Turn9 = "";
			Turn10 = "";
			Turn11 = "";
			Turn12 = "";
			Turn13 = "";
			Turn14 = "";
			Turn15 = "";
			Turn16 = "";
			Turn17 = "";
			Turn18 = "";
			Turn19 = "";
			Turn20 = "";
			Turn21 = "";
			OnPropertyChanged(nameof(Turn1));
			OnPropertyChanged(nameof(Turn2));
			OnPropertyChanged(nameof(Turn3));
			OnPropertyChanged(nameof(Turn4));
			OnPropertyChanged(nameof(Turn5));
			OnPropertyChanged(nameof(Turn6));
			OnPropertyChanged(nameof(Turn7));
			OnPropertyChanged(nameof(Turn8));
			OnPropertyChanged(nameof(Turn9));
			OnPropertyChanged(nameof(Turn10));
			OnPropertyChanged(nameof(Turn11));
			OnPropertyChanged(nameof(Turn12));
			OnPropertyChanged(nameof(Turn13));
			OnPropertyChanged(nameof(Turn14));
			OnPropertyChanged(nameof(Turn15));
			OnPropertyChanged(nameof(Turn16));
			OnPropertyChanged(nameof(Turn17));
			OnPropertyChanged(nameof(Turn18));
			OnPropertyChanged(nameof(Turn19));
			OnPropertyChanged(nameof(Turn20));
			OnPropertyChanged(nameof(Turn21));
			OnPropertyChanged(nameof(Scoreboard));
		}
		public Scoreboard Scoreboard
		{
			get { return _scoreboard; }
			set { _scoreboard = value; OnPropertyChanged(nameof(Scoreboard)); }
		}


		public string Turn1
		{ 
			get 
			{ 
				return _turn1;
			} 
			set 
			{
				_turn1 = value;
				Scoreboard.UpdateScore(0, 0, value);
				OnPropertyChanged(nameof(Scoreboard));
			} 
		}
		public string Turn2 
		{ 
			get 
			{ 
				return _turn2; 
			} 
			set 
			{ 
				_turn2 = value;
				Scoreboard.UpdateScore(0, 1, value);
				OnPropertyChanged(nameof(Scoreboard));
			} 
		}
		public string Turn3 
		{ 
			get 
			{ 
				return _turn3; 
			} 
			set 
			{ 
				_turn3 = value;
				Scoreboard.UpdateScore(1, 0, value);
				OnPropertyChanged(nameof(Scoreboard));
			} 
		}
		public string Turn4 
		{ 
			get 
			{ 
				return _turn4; 
			} 
			set
			{ 
				_turn4 = value;
				Scoreboard.UpdateScore(1, 1, value);
				OnPropertyChanged(nameof(Scoreboard));
			} 
		}
		public string Turn5 
		{ 
			get 
			{ 
				return _turn5; 
			} 
			set 
			{ 
				_turn5 = value;
				Scoreboard.UpdateScore(2, 0, value);
				OnPropertyChanged(nameof(Scoreboard));
			} 
		}
		public string Turn6 
		{ 
			get 
			{ 
				return _turn6; 
			} 
			set
			{
				_turn6 = value;
				Scoreboard.UpdateScore(2, 1, value);
				OnPropertyChanged(nameof(Scoreboard));
			} 
		}
		public string Turn7 
		{ 
			get 
			{ 
				return _turn7; 
			} 
			set 
			{ 
				_turn7 = value;
				Scoreboard.UpdateScore(3, 0, value);
				OnPropertyChanged(nameof(Scoreboard));
			} 
		}
		public string Turn8 
		{ 
			get 
			{
				return _turn8; 
			} 
			set 
			{ 
				_turn8 = value;
				Scoreboard.UpdateScore(3, 1, value);
				OnPropertyChanged(nameof(Scoreboard));
			} 
		}
		public string Turn9 
		{ 
			get 
			{
				return _turn9; 
			}
			set 
			{ 
				_turn9 = value;
				Scoreboard.UpdateScore(4, 0, value);
				OnPropertyChanged(nameof(Scoreboard));
			} 
		}
		public string Turn10 
		{ 
			get 
			{ 
				return _turn10; 
			} 
			set 
			{ 
				_turn10 = value;
				Scoreboard.UpdateScore(4, 1, value);
				OnPropertyChanged(nameof(Scoreboard));
			} 
		}
		public string Turn11 
		{ 
			get 
			{ 
				return _turn11; 
			} 
			set 
			{ 
				_turn11 = value;
				Scoreboard.UpdateScore(5, 0, value);
				OnPropertyChanged(nameof(Scoreboard));
			} 
		}
		public string Turn12 
		{ 
			get 
			{ 
				return _turn12; 
			}
			set
			{ 
				_turn12 = value;
				Scoreboard.UpdateScore(5, 1, value);
				OnPropertyChanged(nameof(Scoreboard));
			} 
		}
		public string Turn13 
		{ 
			get 
			{ 
				return _turn13; 
			} 
			set 
			{ 
				_turn13 = value;
				Scoreboard.UpdateScore(6, 0, value);
				OnPropertyChanged(nameof(Scoreboard));
			}
		}
		public string Turn14 
		{ 
			get 
			{ 
				return _turn14; 
			} 
			set 
			{ 
				_turn14 = value;
				Scoreboard.UpdateScore(6, 1, value);
				OnPropertyChanged(nameof(Scoreboard));
			}
		}
		public string Turn15 
		{ 
			get 
			{ 
				return _turn15; 
			}
			set 
			{ 
				_turn15 = value;
				Scoreboard.UpdateScore(7, 0, value);
				OnPropertyChanged(nameof(Scoreboard));
			} 
		}
		public string Turn16
		{ 
			get 
			{ 
				return _turn16; 
			}
			set 
			{ 
				_turn16 = value;
				Scoreboard.UpdateScore(7, 1, value);
				OnPropertyChanged(nameof(Scoreboard));
			} 
		}
		public string Turn17 
		{ 
			get 
			{ 
				return _turn17; 
			}
			set 
			{ 
				_turn17 = value;
				Scoreboard.UpdateScore(8, 0, value);
				OnPropertyChanged(nameof(Scoreboard));
			} 
		}
		public string Turn18 
		{ 
			get 
			{
				return _turn18; 
			} 
			set 
			{
				_turn18 = value;
				Scoreboard.UpdateScore(8, 1, value);
				OnPropertyChanged(nameof(Scoreboard));
			}
		}
		public string Turn19 
		{ 
			get 
			{ 
				return _turn19; 
			} 
			set 
			{ 
				_turn19 = value;
				Scoreboard.UpdateScore(9, 0, value);
				OnPropertyChanged(nameof(Scoreboard));
			} 
		}
		public string Turn20 
		{ 
			get 
			{ 
				return _turn20; 
			} 
			set 
			{ 
				_turn20 = value;
				Scoreboard.UpdateScore(9, 1, value);
				OnPropertyChanged(nameof(Scoreboard));
			} 
		}
		public string Turn21 
		{ 
			get 
			{ 
				return _turn21; 
			} 
			set 
			{ 
				_turn21 = value;
				Scoreboard.UpdateScore(9, 2, value);
				OnPropertyChanged(nameof(Scoreboard));
			} 
		}


	}
}
