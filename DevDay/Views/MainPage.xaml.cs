using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DevDay
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
			BindingContext = new MainPageViewModel(Navigation);
		}

		void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{
			var model = e.SelectedItem as DevDayModel;

			Navigation.PushAsync(new MainDetailPage(model));
		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			var context = BindingContext as MainPageViewModel;
			var model = ((MenuItem)sender);
			context?.OnDeleteConferenceCommand.Execute(model.CommandParameter);
		}
	}
}
