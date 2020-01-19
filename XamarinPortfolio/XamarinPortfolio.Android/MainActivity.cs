using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace XamarinPortfolio.Droid
{
    [Activity(Label = "XamarinPortfolio", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(UXDivers.Gorilla.Droid.Player.CreateApplication(
              this,
              new UXDivers.Gorilla.Config("Good Gorilla")
                // Register Grial Shared assembly
                .RegisterAssemblyFromType<UXDivers.Artina.Shared.CircleImage>()
                // Register UXDivers Effects assembly
                .RegisterAssembly(typeof(UXDivers.Effects.Effects).Assembly)
                // FFImageLoading.Transformations
                .RegisterAssemblyFromType<FFImageLoading.Transformations.BlurredTransformation>()
                // FFImageLoading.Forms
                .RegisterAssemblyFromType<FFImageLoading.Forms.CachedImage>()
              ));
        }
    }
}