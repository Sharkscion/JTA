using JTA.JTASystem.Core;

namespace JTA.JTASystem
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : BasePage<LoginVM>
    {
        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public LoginPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor with specific view model
        /// </summary>
        public LoginPage(LoginVM specificVM) : base(specificVM)
        {
            InitializeComponent();
        }

        #endregion
        
    }
}
