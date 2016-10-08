using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DevDay
{
	public class DevDayModel : INotifyPropertyChanged
	{
		string _title;
		public string Title
		{
			get
			{
				return _title;
			}
			set
			{
				_title = value;
				OnPropertyChanged();
			}
		}

		string _description;
		public string Description
		{
			get
			{
				return _description;
			}
			set
			{
				_description = value;
				OnPropertyChanged();
			}
		}

		string _conferenceHour;
		public string ConferenceHour
		{
			get
			{
				return _conferenceHour;
			}
			set
			{
				_conferenceHour = value;
				OnPropertyChanged();
			}
		}

		string _author;
		public string Author
		{
			get
			{
				return _author;
			}
			set
			{
				_author = value;
				OnPropertyChanged();
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
