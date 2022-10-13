using Foundation;
using Submission;
using Submission.iOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(DifferentLabel), typeof(DifferentLabelRenderer))]
namespace Submission.iOS
{
    public class DifferentLabelRenderer : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            if (Element == null) return;

            Control.BackgroundColor = UIColor.Green;
        }
    }
}