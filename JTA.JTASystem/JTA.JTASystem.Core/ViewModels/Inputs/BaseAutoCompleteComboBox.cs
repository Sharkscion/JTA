using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Input;

namespace JTA.JTASystem.Core
{
 

    public abstract class BaseAutoCompleteComboBox : BaseVM
    {
        public string Label { get; set; }

        public List<object> Items { get; set; }

        public int SelectedItemId { get; set; } = -1;

        public bool IsOptional { get; set; } = false;

        public bool IsFocus { get; set; } = false;

        public ICommand FocusCommand { get; set; }

        public List<ValidationRule> ValidationRules { get; set; }

        public void Focus()
        {
            if (SelectedItemId == -1)
                IsFocus = true;
        }

        public void AddRule(ValidationRule rule)
        {
            ValidationRules.Add(rule);
        }


    }
}
