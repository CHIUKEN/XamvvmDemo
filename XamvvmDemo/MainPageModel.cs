using System;
using System.Windows.Input;
using Xamvvm;

namespace XamvvmDemo
{
	public class MainPageModel : BasePageModel
	{
		public MainPageModel()
		{
			WelcomeText = "歡迎Xamvvm";
			//binding button click event
			DataButtonCommand = BaseCommand.FromTask<string>((param) => this.PushPageFromCacheAsync<DataListPageModel>());
		}

		public string WelcomeText
		{
			get { return GetField<string>(); }
			set { SetField(value); }
		}

		public ICommand DataButtonCommand
		{
			get { return GetField<ICommand>(); }
			set { SetField(value); }
		}
	}
}
