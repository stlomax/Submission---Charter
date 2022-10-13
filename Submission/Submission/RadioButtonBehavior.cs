using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Submission
{
    public class RadioButtonBehavior : Behavior<RadioButton>
    {
        protected override void OnAttachedTo(RadioButton bindable)
        {
            base.OnAttachedTo(bindable);

            bindable.CheckedChanged += Bindable_CheckedChanged;
        }

        private void Bindable_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            try
            {
                var rb = (RadioButton)sender;

                if (rb.IsChecked)
                {
                    rb.TextColor = Color.Red;
                }
                else
                {
                    rb.TextColor = Color.Default;
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
