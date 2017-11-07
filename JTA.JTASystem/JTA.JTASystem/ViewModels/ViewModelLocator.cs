using JTA.JTASystem.Core;

namespace JTA.JTASystem
{
    public class ViewModelLocator
    {
        /// <summary>
        /// Singleton instance of the locator
        /// </summary>
        public static ViewModelLocator Instance { get; private set; } = new ViewModelLocator();

        public static ApplicationViewModel ApplicationViewModel => new ApplicationViewModel();

        public static MainPageViewModel MainPageViewModel => new MainPageViewModel();
    }
}
