using System;
using System.Collections.Generic;
using System.Text;

namespace Submission.Models
{
    public class Skill
    {
        public enum E_SKILL { CSharp, MSSQL, Python, Tensorflow, VisualBasic, Xamarin, Unity, Sencha, WebRTC }
        public enum E_PROFIENCY { Expert, Average, Newb }

        public E_SKILL SkillSet { get; set; }
        public E_PROFIENCY Profiency { get; set; }
        public int Years { get; set; }
        public bool IsBackEnd =>
            SkillSet == E_SKILL.MSSQL ||
            SkillSet == E_SKILL.WebRTC;
        
    }
}
