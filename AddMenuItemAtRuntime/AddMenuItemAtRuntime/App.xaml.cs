using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AddMenuItemAtRuntime
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			var vm = new ListViewPageViewModel();
			var view = new ListViewPage();
			view.BindingContext = vm;

			MainPage = new NavigationPage(view);
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
