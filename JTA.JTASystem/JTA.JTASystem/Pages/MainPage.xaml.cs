using JTA.JTASystem.Core;
using System;

namespace JTA.JTASystem
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : BasePage<MainPageViewModel>
    {
     
        public MainPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor with specific view model
        /// </summary>
        public MainPage(MainPageViewModel specificViewModel) : base(specificViewModel)
        {
            InitializeComponent();
        }

    }
}
