using Foundation;
using Submission.iOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ResolutionGroupName("MySubmission")]
[assembly: ExportEffect(typeof(iOSNameFormatEffect), "NameFormatEffect")]
namespace Submission.iOS
{
    public class iOSNameFormatEffect : PlatformEffect
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
            this.Control.BackgroundColor = UIColor.Magenta;
        }
    }
}