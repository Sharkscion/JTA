using System.Collections.Generic;
using System.Windows.Controls;

namespace JTA.JTASystem.Core
{
    public class TextEntryVM : BaseVM
    {
        public string Label { get; set; }

        public object Value { get; set; }

        public string Mask { get; set; }

        public List<ValidationRule> ValidationRules { get; set; }

        public TextEntryVM()
        {
            ValidationRules = new List<ValidationRule>();
        }

        public void AddRule(ValidationRule rule)
        {
            ValidationRules.Add(rule);
        }
    }
}
