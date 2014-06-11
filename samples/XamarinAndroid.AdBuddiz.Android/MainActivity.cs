using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using XamarinAndroid.AdBuddiz;

namespace XamarinAndroid.AdBuddiz.Android
{
	[Activity (Label = "XamarinAndroid.AdBuddiz.Android", MainLauncher = true)]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			AdBuddiz.SetTestModeActive();
			AdBuddiz.SetPublisherKey("TEST_PUBLISHER_KEY");
			AdBuddiz.CacheAds(this); // this = current Activity

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);
			
			button.Click += delegate {
				AdBuddiz.ShowAd(this);
			};
		}
	}
}


