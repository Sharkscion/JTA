using System;
using System.Collections.Generic;
using System.Windows.Input;

namespace JTA.JTASystem.Core
{
    public class DiscountEventArgs : EventArgs
    {
        public decimal OldDiscountValue { get; set; }

        public decimal NewDiscountValue { get; set; }

        public RateOperation Operation {get; set;}
    }

    public class DiscountItemVM : BaseVM
    {
        #region Event handler properties

        public EventHandler<DiscountEventArgs> mDiscountEntered;

        #endregion


        #region Public properties

        public List<RateOperation> RateOperationOptions { get; set; }

        public bool IsLastItem { get; set; } = false;

        public decimal NewDiscountValue { get; set; }

        public decimal OldDiscountValue { get; set; }

        public RateOperation SelectedOperation { get; set; } = RateOperation.Net;

        #endregion

        #region Command properties

        public ICommand ValueChangedCommand { get; set; }

        public ICommand SelectedCommand { get; set; }

        #endregion

        public DiscountItemVM()
        {
            SelectedCommand = new RelayParameterizedCommand(i => SetSelectedOperation(i));
            ValueChangedCommand = new RelayCommand(ValueChanged);
        }

        public void ValueChanged()
        {
            OldDiscountValue = NewDiscountValue;
            OnDiscountEntered();
        }

        public void SetSelectedOperation(object operation)
        {
            if (operation != null)
                SelectedOperation = (RateOperation)operation;
            else
                SelectedOperation = RateOperation.Net;

            OnDiscountEntered();
        }

        protected void OnDiscountEntered()
        {
            mDiscountEntered?.Invoke(this, new DiscountEventArgs()
            {
                NewDiscountValue = NewDiscountValue,
                OldDiscountValue = OldDiscountValue,
                Operation = SelectedOperation
            });
        }
     
    }
}
