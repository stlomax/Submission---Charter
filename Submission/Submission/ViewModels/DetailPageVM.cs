using Submission.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Submission.ViewModels
{
    public class DetailPageVM : BaseVM
    {
        private Candidate _candidate;
        public Candidate Candidate
        {
            get => _candidate;
            set
            {
                _candidate = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public string Name => _candidate.Name;
        public string Email => _candidate.Email;
        public string University => _candidate.University;
        public List<Skill> Skills => _candidate.Skills; 
    }
}
