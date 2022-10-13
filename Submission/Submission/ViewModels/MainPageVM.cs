using Submission.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace Submission.ViewModels
{
    public class MainPageVM : BaseVM
    {
        private bool _sortBySkillCount = false;
        public bool DoSortBySkillCount
        {
            get { return _sortBySkillCount; }
            set 
            { 
                _sortBySkillCount = value;
                OnPropertyChanged(nameof(Candidates));
            }
        }

        private bool _filterByBackendSkills = false;
        public bool DoFilterByBackendSkills
        {
            get { return _filterByBackendSkills; }
            set
            {
                _filterByBackendSkills = value;
                OnPropertyChanged(nameof(Candidates));
            }
        }

        public Command<Candidate> CandidateCommand { get; }

        public MainPageVM()
        {
            CandidateCommand = new Command<Candidate>(OnCandidateTapped);
        }

        private async void OnCandidateTapped(Candidate candidate)
        {
            try
            {
                if (candidate != null)
                {
                    DetailPage detailPage = new DetailPage
                    {
                        Candidate = candidate,
                    };
                    await App.Current.MainPage. Navigation.PushModalAsync(detailPage);
                }
            }
            catch (Exception)
            {
                await App.Current.MainPage.DisplayAlert("Error", "Nope.", "OK");
            }
        }

        public ObservableCollection<Candidate> Candidates => 
            new ObservableCollection<Candidate>(
                _sortBySkillCount ?

                    Mocks.MockHelper.GetCandidatesMock()
                        .Where(x => !DoFilterByBackendSkills || x.Skills.Any(y => y.IsBackEnd))
                        .OrderByDescending(x => x.SkillCount) :

                    Mocks.MockHelper.GetCandidatesMock()
                        .Where(x => !DoFilterByBackendSkills || x.Skills.Any(y => y.IsBackEnd))
                        .OrderBy(x => x.Name)
                );

    }
}
