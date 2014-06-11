#XamarinAndroid.AdBuddiz

##Instalation

### Add the library

1. Clone this repository
2. Attach the XamarinAndroid.AdBuddiz.csproj to your solution
3. Clean the solution and rebuild

###Permissions

**The library already adds the permission INTERNET** if it's not already added. The following permissions are optional, but without them, you might get less ads and tracking could be less accurate:

    <uses-permission android:name="android.permission.ACCESS_NETWORK_STATE" />
    <uses-permission android:name="android.permission.ACCESS_WIFI_STATE" />
    
###Add the AdBuddizActivity to the AndroidManifest.xml of your App


    <application ...>
     ...
     <activity android:name="com.purplebrain.adbuddiz.sdk.AdBuddizActivity" 
               android:theme="@android:style/Theme.Translucent" />
    </application>
    
##Usage

###Configure & initialize SDK

Import the following namespace:

    using XamarinAndroid.AdBuddiz;

You should request to cache ads as soon as your app starts. In the first created Activity of your app, add the following lines:

    protected override void OnCreate(Bundle savedInstanceState)
    {
      ...
      AdBuddiz.SetPublisherKey("TEST_PUBLISHER_KEY");
      AdBuddiz.CacheAds(this); // this = current Activity
    }
    
###Test mode (Optional)

You can activate test mode by calling the following code before CacheAds() call:

    AdBuddiz.SetTestModeActive();
    
**Remove it before publishing to Google Play.**

###Logs (Optional)

You can control the AdBuddiz SDK log level by calling the following code before CacheAds() call:

    AdBuddiz.SetLogLevel(AdBuddizLogLevel.Info);    // or Error, Silent
    
###Show Ads

Whenever you want to display an ad, call ShowAd(). We recommend this call be made where there is a natural break in play like between levels for example.

    AdBuddiz.ShowAd(this); // this = current Activity
    
###Request SDK Status (Optional)

To know if the SDK will be able to display an ad, you can call IsReadyToShowAd().

    if (AdBuddiz.IsReadyToShowAd(this)) { // this = current Activity
      ...
    }
    
###Delegate (Optional)

In order to get more information about the SDK behavior, you can register a delegate.

**Example is pending...**
