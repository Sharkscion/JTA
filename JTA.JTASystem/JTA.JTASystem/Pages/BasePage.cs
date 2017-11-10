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
        private object mVM;


        public object VMObject
        {
            get => mVM;
            set
            {
                // If nothing has changed, return
                if (mVM == value)
                    return;

                // Update the value 
                mVM = value;

                // Fire the view model 
                OnVMChanged();

                // Set the data context of this page to the updated view model
                DataContext = mVM;

            }
        }

        /// <summary>
        /// Fired when the view model changes
        /// </summary>
        private void OnVMChanged()
        {
        }
    }

    /// <summary>
    /// A base page for the pages that have associated view models
    /// </summary>
    /// <typeparam name="VM"></typeparam>
    public class BasePage <VM> : BasePage
        where VM : BaseVM, new()
    {
        /// <summary>
        ///  The view model associated with this page
        /// </summary>
        public VM VM
        {
            get => (VM)VMObject;
            set => VMObject = value;
        }

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public BasePage() : base()
        {
            // TODO: Create/set a default view model
            // VM = 
        }


        /// <summary>
        /// A constructor with specific view model
        /// </summary>
        /// <param name="specificVM">The specific view model to use if there are any</param>
        public BasePage(VM specificVM = null) : base()
        {
            if (specificVM != null)
                VM = specificVM;
            else
                // TODO: Create a default view model
                VM = IoC.Get<VM>();

        }

        #endregion


    }
}
