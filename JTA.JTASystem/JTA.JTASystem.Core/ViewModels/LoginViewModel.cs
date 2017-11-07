
using System.Windows.Input;

namespace JTA.JTASystem.Core
{
    /// <summary>
    ///  View model for the login screen
    /// </summary>
    public class LoginViewModel : BaseViewModel
    {

        //NOTE: No public property for password for security reasons. 
        //      Never store a password. 
        //      Just pass the value to be verified or saved in the db.

        #region Public Properties

        /// <summary>
        /// The username of the user
        /// </summary>
        public string Username { get; set; }
        
        /// <summary>
        /// A flag indicating if the login command is running
        /// </summary>
        public bool LoginIsRunning { get; set; }

        #endregion

        /// <summary>
        /// A command to login
        /// </summary>
        public ICommand LoginCommand { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public LoginViewModel()
        {
            //TODO: register loginCommand and create the login method
        }


    }
}
