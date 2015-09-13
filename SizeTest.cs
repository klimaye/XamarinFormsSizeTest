using System;
using Newtonsoft.Json;
using Xamarin.Forms;
using System.Collections.Generic;
using RestSharp.Portable;
using System.Net.Http;

namespace SizeTest
{
	public class App : Application
	{
		JsonSerializer serializer;
		Dictionary<string,string> result;
		RestClient restClient;
		public App ()
		{
			this.serializer = new JsonSerializer ();
			this.result = JsonConvert.DeserializeObject ("{ \"auth\":\"12345\"}") 
							as Dictionary<string, string>;
			this.restClient = new RestClient ();
			var request = new RestRequest (new Uri ("http://google.com"), HttpMethod.Get);
			var result = restClient.GetContent (request);
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

