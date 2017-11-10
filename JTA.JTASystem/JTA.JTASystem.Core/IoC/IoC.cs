using Ninject;
using System;
namespace JTA.JTASystem.Core
{
    /// <summary>
    /// The IoC container for our application
    /// </summary>
    public static class IoC
    {
        #region Public Properties

        /// <summary>
        /// The kernel for our IoC container
        /// </summary>
        public static IKernel Kernel { get; private set; } = new StandardKernel();

        /// <summary>
        /// A shortcut to access the <see cref="IUIManager"/>
        /// </summary>
       // public static IUIManager UI => IoC.Get<IUIManager>();

        /// <summary>
        /// A shortcut to access the <see cref="ApplicationVM"/>
        /// </summary>
        public static ApplicationVM Application => IoC.Get<ApplicationVM>();

        /// <summary>
        /// A shortcut to access the <see cref="SettingsVM"/>
        /// </summary>
        public static MainPageVM MainPage => IoC.Get<MainPageVM>();

        #endregion

        #region Construction

        /// <summary>
        /// Sets up the IoC container, binds all information required and is ready for use
        /// NOTE: Must be called as soon as your application starts up to ensure all 
        ///       services can be found
        /// </summary>
        public static void Setup()
        {
            // Bind all required view models
            BindVMs();
        }

        /// <summary>
        /// Binds all singleton view models
        /// </summary>
        private static void BindVMs()
        {
            // Bind to a single instance of Application view model
            Kernel.Bind<ApplicationVM>().ToConstant(new ApplicationVM());

            // Bind to a single instance of MainPage view model
            Kernel.Bind<MainPageVM>().ToConstant(new MainPageVM());

            // Bind to a single instance of Login view model
            Kernel.Bind<LoginVM>().ToConstant(new LoginVM());
        }

        #endregion

        /// <summary>
        /// Get's a service from the IoC, of the specified type
        /// </summary>
        /// <typeparam name="T">The type to get</typeparam>
        /// <returns></returns>
        public static T Get<T>()
        {
            return Kernel.Get<T>();
        }
    }
}
