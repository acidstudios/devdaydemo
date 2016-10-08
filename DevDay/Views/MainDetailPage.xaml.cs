using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DevDay
{
	public partial class MainDetailPage : ContentPage
	{
		public MainDetailPage(DevDayModel model)
		{
			InitializeComponent();

			BindingContext = new MainDetailPageViewModel(model);
		}
	}
}
