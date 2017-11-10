using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Controls;

namespace JTA.JTASystem.Core
{
    public class RequiredRule : ValidationRule, ISubject
    {
        private string mErrorMessage;

        private bool mHasError = false;

        private List<IObserver> mObservers;

        public RequiredRule(string errorMessage)
        {
            mErrorMessage = errorMessage;
            mObservers = new List<IObserver>();
        }
    
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string message = null;

            if (value is null || "".Equals(value))
            {
                mHasError = true;
                message = mErrorMessage;
            }
            else mHasError = false;
           
            Notify();
            return new ValidationResult(mHasError, message);
        }

        public void Notify()
        {
            foreach (var observer in mObservers)
                observer.Update(mHasError);
        }

        public void Register(IObserver observer)
        {
            mObservers.Add(observer);
        }

        public void Unregister(IObserver observer)
        {
            mObservers.Remove(observer);
        }



    }
}
