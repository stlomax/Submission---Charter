using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Submission;
using Submission.Droid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(DifferentLabel), typeof(DifferentLabelRenderer))]
namespace Submission.Droid
{
    public class DifferentLabelRenderer : LabelRenderer
    {
        private Context context;
        public DifferentLabelRenderer(Context context) : base(context)
        {
            this.context = context;
        }
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            if (Control == null || e.NewElement == null) return;

            Control.SetBackgroundColor(Android.Graphics.Color.LightGreen);
        }
    }
}