using JTA.JTASystem.Core;
using System.Windows.Controls;
using System;

namespace JTA.JTASystem
{
    /// <summary>
    /// The base page of the system pages to contain base functionalities and properties
    /// </summary>
    public class BasePage : UserControl
    {

        /// <summary>
        /// The view model associated with this page
        /// </summary>
        private object mViewModel;


        public object ViewModelObject
        {
            get => mViewModel;
            set
            {
                // If nothing has changed, return
                if (mViewModel == value)
                    return;

                // Update the value 
                mViewModel = value;

                // Fire the view model 
                OnViewModelChanged();

                // Set the data context of this page to the updated view model
                DataContext = mViewModel;

            }
        }

        /// <summary>
        /// Fired when the view model changes
        /// </summary>
        private void OnViewModelChanged()
        {
        }
    }

    /// <summary>
    /// A base page for the pages that have associated view models
    /// </summary>
    /// <typeparam name="VM"></typeparam>
    public class BasePage <VM> : BasePage
        where VM : BaseViewModel, new()
    {
        /// <summary>
        ///  The view model associated with this page
        /// </summary>
        public VM ViewModel
        {
            get => (VM)ViewModelObject;
            set => ViewModelObject = value;
        }

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public BasePage() : base()
        {
            // TODO: Create/set a default view model
            // ViewModel = 
        }


        /// <summary>
        /// A constructor with specific view model
        /// </summary>
        /// <param name="specificViewModel">The specific view model to use if there are any</param>
        public BasePage(VM specificViewModel = null) : base()
        {
            if (specificViewModel != null)
                ViewModel = specificViewModel;
            else
                // TODO: Create a default view model
                ViewModel = IoC.Get<VM>();

        }

        #endregion


    }
}
