using JTA.JTASystem.Core;

namespace JTA.JTASystem
{
    public class VMLocator
    {
        /// <summary>
        /// Singleton instance of the locator
        /// </summary>
        public static VMLocator Instance { get; private set; } = new VMLocator();

        public static ApplicationVM ApplicationVM => new ApplicationVM();

        public static MainPageVM MainPageVM => new MainPageVM();
    }
}
