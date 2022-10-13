using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Submission.Models
{
    public class Candidate
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public string University { get; set; } = string.Empty;
        private List<Skill> _skills { get; set; }
        public List<Skill> Skills 
        { 
            get 
            { 
                if (_skills == null)
                {
                    _skills = new List<Skill>();
                }
                return _skills; 
            } 
            set
            {
                _skills = value;
            }
        }
        public int SkillCount => Skills.Count;
    }
}
