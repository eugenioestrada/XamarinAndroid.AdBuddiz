AdBuddiz official SDK binding for Xamarin Android. AdBuddiz is an advertising solution for mobile apps that show clean and elegant ads with high CPM rates.

```csharp
using XamarinAndroid.AdBuddiz;
...

protected override void OnCreate(Bundle savedInstanceState)
{
  ...
  AdBuddiz.SetPublisherKey("TEST_PUBLISHER_KEY");
  AdBuddiz.CacheAds(this); // this = current Activity
}
```

And wherever you want:

```csharp

...
AdBuddiz.ShowAd(this); // this = current Activity
...

```

