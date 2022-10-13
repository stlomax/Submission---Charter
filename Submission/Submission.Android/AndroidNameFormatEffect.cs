using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Submission.Droid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName("MySubmission")]
[assembly: ExportEffect(typeof(AndroidNameFormatEffect), "NameFormatEffect")]
namespace Submission.Droid
{
    public class AndroidNameFormatEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            //throw new NotImplementedException();
        }

        protected override void OnDetached()
        {
            //throw new NotImplementedException();
        }
        protected override void OnElementPropertyChanged(PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(args);
            this.Control.SetBackgroundColor(Android.Graphics.Color.Orange);
        }
    }
}