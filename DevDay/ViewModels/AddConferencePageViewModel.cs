using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace DevDay
{
	public class AddConferencePageViewModel : INotifyPropertyChanged
	{
		public ICommand SaveConferenceCommand
		{
			get;
			set;
		}

		public ICommand CancelSaveConference
		{
			get;
			set;
		}

		DevDayModel _model;

		public event PropertyChangedEventHandler PropertyChanged;

		public DevDayModel Model
		{
			get
			{
				return _model;
			}
			set
			{
				_model = value;
				OnPropertyChanged();
			}
		}

		public AddConferencePageViewModel(Action<DevDayModel> addAction, INavigation navigation)
		{
			Model = new DevDayModel();

			SaveConferenceCommand = new Command(async () =>
			{
				addAction.Invoke(Model);
				await navigation.PopModalAsync(true);
			});

			CancelSaveConference = new Command(async () =>
			{
				await navigation.PopModalAsync();
			});
		}

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
