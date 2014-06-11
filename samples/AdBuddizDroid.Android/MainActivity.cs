using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using AdBuddizDroid;

namespace AdBuddizDroid.Android
{
	[Activity (Label = "AdBuddizDroid.Android", MainLauncher = true)]
	public class MainActivity : Activity, IAdBuddizDelegate
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			AdBuddiz.SetTestModeActive();
			AdBuddiz.SetPublisherKey("TEST_PUBLISHER_KEY");
			AdBuddiz.Delegate = this;
			AdBuddiz.CacheAds(this); // this = current Activity

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);
			
			button.Click += delegate {
				AdBuddiz.ShowAd(this);
			};
		}

		public void DidCacheAd ()
		{
			Console.WriteLine ("On ad cached");
		}

		public void DidClick ()
		{
			Console.WriteLine ("On click");
		}

		public void DidFailToShowAd (AdBuddizError error)
		{
			Console.WriteLine ("On fail to show " + error.ToString());
		}

		public void DidHideAd ()
		{
			Console.WriteLine ("On ad hidden");
		}

		public void DidShowAd ()
		{
			Console.WriteLine("On ad shown");
		}
	}
}


