using System;
using System.Windows;

namespace JTA.JTASystem
{
    /// <summary>
    /// A base attached property to replace the vanilla WPF attached property
    /// </summary>
    /// <typeparam name="Parent"></typeparam>
    /// <typeparam name="Property"></typeparam>
    public abstract class BaseAttachedProperty<Parent, Property>
        where Parent : new()
    {

        #region Public properties
        /// <summary>
        /// Singleton instance of this attached property
        /// </summary>
        public static Parent Instance { get; private set; } = new Parent();

        #endregion

        #region Public methods

        /// <summary>
        /// Fired when the value changes, even when the value is the same
        /// </summary>
        public event Action<DependencyObject, object> ValueUpdated = (sender, value) => { };

        /// <summary>
        /// Fired when the value changes
        /// </summary>
        public event Action<DependencyObject, DependencyPropertyChangedEventArgs> ValueChanged = (sender, value) => { };    

        public static Property GetValue(DependencyObject d) => (Property)d.GetValue(ValueProperty);
        public static void SetValue(DependencyObject d, Property value) => d.SetValue(ValueProperty, value);

        public virtual void OnValueUpdated(DependencyObject d, object value) { }
        public virtual void OnValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e) { }

        #endregion

        #region Attached property definitions

        public static readonly DependencyProperty ValueProperty = 
            DependencyProperty.RegisterAttached("Value",
                                                typeof(Property),
                                                typeof(BaseAttachedProperty<Parent, Property>),
                                                new UIPropertyMetadata(
                                                        default(Property),
                                                        new PropertyChangedCallback(OnValuePropertyChanged),
                                                        new CoerceValueCallback(OnValuePropertyUpdated)));

        private static object OnValuePropertyUpdated(DependencyObject d, object value)
        {
            // Call the parent function
            (Instance as BaseAttachedProperty<Parent, Property>)?.OnValueUpdated(d, value);

            // Call event listeners
            (Instance as BaseAttachedProperty<Parent, Property>)?.ValueUpdated(d, value);

            return value;
        }

        /// <summary>
        /// The callback event when the <see cref="ValueProperty"/> is changed
        /// </summary>
        /// <param name="d">The UI element that had it's property changed</param>
        /// <param name="e">The arguments for the event</param>
        private static void OnValuePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            // Call the parent function
            (Instance as BaseAttachedProperty<Parent, Property>)?.OnValueChanged(d, e);

            // Call event listeners
            (Instance as BaseAttachedProperty<Parent, Property>)?.ValueChanged(d, e);
        }

        #endregion
    }
}
