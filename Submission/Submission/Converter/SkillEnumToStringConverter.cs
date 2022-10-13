using Submission.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace Submission.Converter
{
    public class SkillEnumToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return "?";
            try
            {
                Skill.E_SKILL skill = (Skill.E_SKILL)value;

                switch(skill)
                {
                    case Skill.E_SKILL.Python: return "Python";
                    case Skill.E_SKILL.MSSQL: return "MSSQL";
                    case Skill.E_SKILL.Sencha: return "Sencha";
                    case Skill.E_SKILL.CSharp: return "C#";
                    case Skill.E_SKILL.Xamarin: return "Xamarin";
                    case Skill.E_SKILL.Tensorflow: return "Tensorflow";
                    case Skill.E_SKILL.WebRTC: return "WebRTC";
                    case Skill.E_SKILL.VisualBasic: return "VB";
                    case Skill.E_SKILL.Unity: return "Unity";
                    default: return "Undefined skill";
                }
            }
            catch (Exception)
            {

                return "?";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    public class ProficientToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return "?";
            try
            {
                Skill.E_PROFIENCY skill = (Skill.E_PROFIENCY)value;

                switch (skill)
                {
                    case Skill.E_PROFIENCY.Expert: return "Expert";
                    case Skill.E_PROFIENCY.Average: return "Average";
                    case Skill.E_PROFIENCY.Newb: return "Newbie";
                    default: return "Undefined level";
                }
            }
            catch (Exception)
            {

                return "?";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
