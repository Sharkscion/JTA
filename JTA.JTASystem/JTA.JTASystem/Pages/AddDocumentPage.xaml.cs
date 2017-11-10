using System.Windows.Controls;
using JTA.JTASystem.Core;

namespace JTA.JTASystem
{
    /// <summary>
    /// Interaction logic for AddDocumentPage.xaml
    /// </summary>
    public partial class AddDocumentPage : BasePage<AddDocumentPageVM>
    {
        public AddDocumentPage()
        {
            InitializeComponent();
        }

  
        /// <summary>
        /// Constructor with specific view model
        /// </summary>
        public AddDocumentPage(AddDocumentPageVM specificVM) : base(specificVM)
        {
            InitializeComponent();
        }
    }
}
