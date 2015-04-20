using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace DeviceOpenUriExample
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            MainPage = new ContentPage
            {
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
						new Label {
							XAlign = TextAlignment.Center,
							Text = "Welcome to Xamarin Forms!"
						},
                        new Button
                        {
                            Text = "Without Params (Works)",
                            Command = new Command(() => Device.OpenUri(new Uri("http://www.bing.com")))
                        },
                        new Button
                        {
                            Text = "With encoded Params (Breaks)",
                            Command = new Command(() => Device.OpenUri(new Uri("http://www.bing.com/search?q=xamarin%20bombs%20on%20this")))
                        },
                        new Button
                        {
                            Text = "With decoded Params (Breaks)",
                            Command = new Command(() => Device.OpenUri(new Uri("http://www.bing.com/search?q=xamarin bombs on this")))
                        }
					}
                }
            };
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
