using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace DevDay
{
	public class MainPageViewModel
	{
		public ObservableCollection<DevDayModel> DevDayList
		{
			get;
			set;
		}

		public ICommand AddConferenceCommand
		{
			get;
			set;
		}

		public MainPageViewModel(INavigation navigation)
		{
			var model = new List<DevDayModel>
			{
				new DevDayModel{
					Title = "Introducción a Xamarin",
					Description = "Introducción a Xamarin",
					Author = "Erich von Hauske",
					ConferenceHour = "9:30-10:10"
				},
				new DevDayModel{
					Title = "Xamarin.Forms",
					Description = "Xamarin.Forms",
					Author = "Fernando Arreguin",
					ConferenceHour="10:20-11:00"
				},
				new DevDayModel{
					Title = "Sorpresa",
					Description = "Sorpresa",
					Author = "Amin Espinoza",
					ConferenceHour="11:10-12:00"
				},
				new DevDayModel{
					Title = "Data Binding",
					Description = "Data Binding",
					Author = "Gustavo Barrientos",
					ConferenceHour="13:00-13:30"
				}
			};

			DevDayList = new ObservableCollection<DevDayModel>(model);

			AddConferenceCommand = new Command(async () =>
			{
				var addPage = new AddConferencePage((obj) =>
				{
					DevDayList.Add(obj);
				});

				await navigation.PushModalAsync(new NavigationPage(addPage));
			});
		}
	}
}
