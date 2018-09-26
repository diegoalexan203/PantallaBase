using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using PS.Demo1.App.Droid.CustomRenderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Entry), typeof(CustomEntryRenderer))]
namespace PS.Demo1.App.Droid.CustomRenderers
{
    public class CustomEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            Control?.SetBackgroundColor(Android.Graphics.Color.Transparent);
            Control?.SetPadding(30, 1, 1, 5);
            Control.Gravity = GravityFlags.CenterVertical;
            
            
            //Control.Background = Android.App.Application.Context.GetDrawable(Resource.Drawable.RoundedCornerEntry);
            //Control.Gravity = GravityFlags.CenterVertical;
            //Control.SetPadding(10, 0, 0, 0);


        }
    }
}