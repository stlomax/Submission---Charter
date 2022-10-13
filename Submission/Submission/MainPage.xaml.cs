using Submission.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace Submission
{
    public partial class MainPage : ContentPage
    {
        MainPageVM _viewModel;

        public MainPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new MainPageVM();

        }

        private void RB_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (_viewModel != null)
            {
                _viewModel.DoFilterByBackendSkills = rbBackend.IsChecked;
            }
           
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            On<iOS>().SetUseSafeArea(true);

        }
    }
}
