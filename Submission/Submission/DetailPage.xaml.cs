using Submission.Models;
using Submission.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace Submission
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        private DetailPageVM _viewModel;
        private Candidate _candidate;
        public Candidate Candidate
        {
            get => _candidate;
            set
            {
                _candidate = value;
                LoadCandidate();
            }
        }

        public DetailPage()
        {
            InitializeComponent();
        }
        private void LoadCandidate()
        {
            BindingContext = _viewModel = new DetailPageVM { Candidate = _candidate };
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            On<iOS>().SetUseSafeArea(true);

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}