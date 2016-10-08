using System;
namespace DevDay
{
	public class MainDetailPageViewModel
	{
		public DevDayModel Model
		{
			get;
			set;
		}

		public MainDetailPageViewModel(DevDayModel model)
		{
			Model = model;
		}
	}
}
