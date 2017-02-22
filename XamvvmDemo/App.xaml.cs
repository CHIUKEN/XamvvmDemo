using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamvvm;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XamvvmDemo
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			var factory = new XamvvmFormsFactory(this);
			factory.RegisterNavigationPage<MainNavigationPageModel>(() => this.GetPageFromCache<MainPageModel>());
			XamvvmCore.SetCurrentFactory(factory);
			MainPage = this.GetPageFromCache<MainNavigationPageModel>() as Page;

			//MainPage = new MainPage();
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
