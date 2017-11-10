using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace JTA.JTASystem.Core
{
    public class DatePickerVM : BaseVM
    {
        public string Label { get; set; }

        public DateTime Date { get; set; }

        public List<ValidationRule> ValidationRules { get; set; }

        public DatePickerVM()
        {
            Date = DateTime.Now;
            ValidationRules = new List<ValidationRule>();
        }

        public void AddRule(ValidationRule rule)
        {
            ValidationRules.Add(rule);
        }
    }
}
