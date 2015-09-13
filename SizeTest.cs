using System;
using Newtonsoft.Json;
using Xamarin.Forms;
using System.Collections.Generic;

namespace SizeTest
{
	public class App : Application
	{
		JsonSerializer serializer;
		Dictionary<string,string> result;

		public App ()
		{
			this.serializer = new JsonSerializer ();
			this.result = JsonConvert.DeserializeObject ("{ \"auth\":\"12345\"}") 
							as Dictionary<string, string>;
			// The root page of your application
			MainPage = new ContentPage {
				Content = new StackLayout {
					VerticalOptions = LayoutOptions.Center,
					Children = {
						new Label {
							XAlign = TextAlignment.Center,
							Text = "Welcome to Xamarin Forms!"
						}
					}
				}
			};
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

