using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DevDay
{
	public partial class AddConferencePage : ContentPage
	{
		public AddConferencePage(Action<DevDayModel> addAction)
		{
			InitializeComponent();
			BindingContext = new AddConferencePageViewModel(addAction, Navigation);
		}
	}
}
