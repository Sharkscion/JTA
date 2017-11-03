using System.Windows;
using System.Windows.Input;
using JTA.JTASystem.Core;

namespace JTA.JTASystem
{
    class WindowViewModel :  BaseViewModel
    {
        /// <summary>
        /// The window the view model controls
        /// </summary>
        private Window mWindow;

        private int mWindowRadius = 3;
        private int mOuterMarginSize = 8;

        /// <summary>
        /// The last known dock position
        /// </summary>
        private WindowDockPosition mDockPosition = WindowDockPosition.Undocked;

        /// <summary>
        /// The size of the resize border around the window
        /// </summary>
        public int ResizeBorder => Borderless ? 0 : 6;
        public int TitleHeight { get; set; } = 40;
        public double WindowMinimumHeight { get; set; } = 400;
        public double WindowMinimumWidth { get; set; } = 400;
        public ApplicationPage CurrentPage { get; set; } = ApplicationPage.Login;

        /// <summary>
        /// True if the window should be borderless because it is docked or maximized
        /// </summary>
        public bool Borderless => mWindow.WindowState == WindowState.Maximized || mDockPosition != WindowDockPosition.Undocked; 

        /// <summary>
        /// The size of the resize border around the window, taking into account the outer margin
        /// </summary>
        public Thickness ResizeBorderThickness => new Thickness(ResizeBorder + OuterMarginSize);
        public Thickness OuterMarginSizeThickness => new Thickness(OuterMarginSize);
        public Thickness InnerContentPadding { get; set; } = new Thickness(0);
        public CornerRadius WindowCornerRadius => new CornerRadius(WindowRadius);
        public GridLength TitleHeightGridLength => new GridLength(TitleHeight + ResizeBorder); 


        #region Commands
            public ICommand MinimizedCommand { get; set; }
            public ICommand MaximizedCommand { get; set; }
            public ICommand CloseCommand { get; set; }
            public ICommand MenuCommand { get; set; }
        #endregion

        public int OuterMarginSize
        {
            get => Borderless ? 0 : mOuterMarginSize;
            set =>  mOuterMarginSize = value;
        }

        public int WindowRadius
        {
            // If it is maximized or docked, no border
            get => Borderless ? 0 : mWindowRadius;
            set => mWindowRadius = value;
        }

  

        public WindowViewModel(Window window)
        {
            mWindow = window;

            //listen for the window resizing
            mWindow.StateChanged += (sender, e) =>
            {
                //fire off events for all properties that are affected by a resize
                OnPropertyChanged(nameof(ResizeBorderThickness));
                OnPropertyChanged(nameof(OuterMarginSize));
                OnPropertyChanged(nameof(OuterMarginSizeThickness));
                OnPropertyChanged(nameof(WindowRadius));
                OnPropertyChanged(nameof(WindowCornerRadius));

            };

            //create commands
            MinimizedCommand = new RelayCommand(() => mWindow.WindowState = WindowState.Minimized);
            MaximizedCommand = new RelayCommand(() => mWindow.WindowState ^= WindowState.Maximized);
            CloseCommand = new RelayCommand(() => mWindow.Close());
            MenuCommand = new RelayCommand(() => SystemCommands.ShowSystemMenu(mWindow, GetMousePosition()));

            // Fix window resize issue
            var resizer = new WindowResizer(mWindow);

            // Listen out for dock changes
            resizer.WindowDockChanged += (dock) =>
            {
                // Store last position
                mDockPosition = dock;

                // Fire off resize events
                WindowResized();
            };


        }

        #region Private Helpers

        public Point GetMousePosition()
        {
            var position = Mouse.GetPosition(mWindow);

            return new Point(position.X + mWindow.Left, position.Y + mWindow.Top);
        }


        /// <summary>
        /// If the window resizes to a special position (docked or maximized)
        /// this will update all required property change events to set the borders and radius values
        /// </summary>
        private void WindowResized()
        {
            // Fire off events for all properties that are affected by a resize
            OnPropertyChanged(nameof(Borderless));
            OnPropertyChanged(nameof(ResizeBorderThickness));
            OnPropertyChanged(nameof(OuterMarginSize));
            OnPropertyChanged(nameof(OuterMarginSizeThickness));
            OnPropertyChanged(nameof(WindowRadius));
            OnPropertyChanged(nameof(WindowCornerRadius));
        }
        #endregion

    }
}
