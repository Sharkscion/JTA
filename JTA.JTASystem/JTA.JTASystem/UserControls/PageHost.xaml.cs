using JTA.JTASystem.Core;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace JTA.JTASystem
{
    /// <summary>
    /// Interaction logic for PageHost.xaml
    /// </summary>
    public partial class PageHost : UserControl
    {

        #region Dependency Properties

        /// <summary>
        /// The current page to show in the page host
        /// </summary>
        public ApplicationPage CurrentPage
        {
            get => (ApplicationPage)GetValue(CurrentPageProperty);
            set => SetValue(CurrentPageProperty, value);
        }

        /// <summary>
        /// The current page view model associated with the current page
        /// </summary>
        public BaseVM CurrentPageVM
        {
            get => (BaseVM)GetValue(CurrentPageVMProperty);
            set => SetValue(CurrentPageVMProperty, value);
        }


        /// <summary>
        /// Registers <see cref="CurrentPage"/> as a dependency property
        /// </summary>
        public static readonly DependencyProperty CurrentPageProperty =
            DependencyProperty.Register(nameof(CurrentPage), 
                typeof(ApplicationPage), typeof(PageHost), 
                new UIPropertyMetadata(default(ApplicationPage), null, CurrentPagePropertyChanged));


        /// <summary>
        /// Registers <see cref="CurrentPageVM"/> as a dependency property
        /// </summary>
        public static readonly DependencyProperty CurrentPageVMProperty =
            DependencyProperty.Register(nameof(CurrentPageVM),
                typeof(BaseVM), typeof(PageHost),
                new UIPropertyMetadata());


        /// <summary>
        /// Called when the <see cref="CurrentPage"/> value has changed
        /// </summary>
        /// <param name="d"></param>
        /// <param name="e"></param>
        private static object CurrentPagePropertyChanged(DependencyObject d, object value)
        {
            // Get current values
            var currentPage = (ApplicationPage)d.GetValue(CurrentPageProperty);
            var currentPageVM = d.GetValue(CurrentPageVMProperty);

            // Get the frames
            var newPageFrame = (d as PageHost).NewPage;
            var oldPageFrame = (d as PageHost).OldPage;

            // If the current page hasn't changed
            // just update the view model
            if (newPageFrame.Content is BasePage page && page.ToApplicationPage() == currentPage)
            {
                // Just update the view model
                page.VMObject = currentPageVM;

                return value;
            }

            // Store the current page content as the old page
            var oldPageContent = newPageFrame.Content;

            // Remove current page from new page frame
            newPageFrame.Content = null;

            // Move the previous page into the old page frame
            oldPageFrame.Content = oldPageContent;

            // Animate out previous page when the Loaded event fires
            // right after this call due to moving frames
            //if (oldPageContent is BasePage oldPage)
            //{
            //    // Tell old page to animate out
            //    oldPage.ShouldAnimateOut = true;

            //    // Once it is done, remove it
            //    Task.Delay((int)(oldPage.SlideSeconds * 1000)).ContinueWith((t) =>
            //    {
            //        // Remove old page
            //        Application.Current.Dispatcher.Invoke(() => oldPageFrame.Content = null);
            //    });
            //}

            // Set the new page content
            newPageFrame.Content = currentPage.ToBasePage(currentPageVM);

            return value;
        }

        #endregion


        public PageHost()
        {
            InitializeComponent();

            // Show the set current page when in design mode
            if (DesignerProperties.GetIsInDesignMode(this))
                NewPage.Content = new MainPage();


        }
    }
}
