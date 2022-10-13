using Submission.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Submission.Mocks
{
    public class MockHelper
    {
        public static List<Candidate> GetCandidatesMock()
        {
            return new List<Candidate>
            {
                new Candidate
                {
                    Email = "test1@test.com",
                    Name = "Michael Test",
                    University = "Penn State",
                    Skills = new List<Skill>
                    {
                        new Skill { SkillSet = Skill.E_SKILL.CSharp, Years = 1, Profiency = Skill.E_PROFIENCY.Expert },
                    }
                },
                new Candidate
                {
                    Email = "test2@test.com",
                    Name = "Robert Test",
                    University = "UNLV",
                    Skills = new List<Skill>
                    {
                        new Skill { SkillSet = Skill.E_SKILL.Xamarin, Years = 10, Profiency = Skill.E_PROFIENCY.Expert },
                        new Skill { SkillSet = Skill.E_SKILL.Unity, Years = 14, Profiency = Skill.E_PROFIENCY.Expert },
                        new Skill { SkillSet = Skill.E_SKILL.MSSQL, Years = 12, Profiency = Skill.E_PROFIENCY.Expert }
                    }
                },
                new Candidate
                {
                    Email = "test3@test.com",
                    Name = "Xavier Test",
                    University = "Stanford",
                    Skills = new List<Skill>
                    {
                        new Skill { SkillSet = Skill.E_SKILL.Python, Years = 1, Profiency = Skill.E_PROFIENCY.Newb },
                        new Skill { SkillSet = Skill.E_SKILL.Sencha, Years = 1, Profiency = Skill.E_PROFIENCY.Newb },
                        new Skill { SkillSet = Skill.E_SKILL.Tensorflow, Years = 1, Profiency = Skill.E_PROFIENCY.Newb },
                        new Skill { SkillSet = Skill.E_SKILL.WebRTC, Years = 1, Profiency = Skill.E_PROFIENCY.Newb },
                        new Skill { SkillSet = Skill.E_SKILL.VisualBasic, Years = 1, Profiency = Skill.E_PROFIENCY.Newb }
                    }
                }
            };
        }
    }
}
