using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace JTA.JTASystem
{
    /// <summary>
    /// Taken from: http://avaloncontrolslib.codeplex.com/SourceControl/latest#branches/ido_ran/v2.0.0.1/AvalonControlsLibrary/Controls/MaskedTextBox.cs
    /// Masked textbox control is a text box that can have a mask for the text
    /// </summary>
    public class MaskedTextBox : TextBox
    {
        #region Properties

        /// <summary>
        /// Gets the MaskTextProvider for the specified Mask
        /// </summary>
        public MaskedTextProvider MaskProvider
        {
            get
            {
                MaskedTextProvider maskProvider = null;
                if (Mask != null)
                {
                    maskProvider = new MaskedTextProvider(Mask);
                    maskProvider.Set(Text);
                }
                return maskProvider;
            }
        }

        /// <summary>
        /// Gets or sets the mask to apply to the textbox
        /// </summary>
        public string Mask
        {
            get => (string)GetValue(MaskProperty);
            set => SetValue(MaskProperty, value);
        }
    

        /// <summary>
        /// Dependency property to store the mask to apply to the textbox
        /// </summary>
        public static readonly DependencyProperty MaskProperty =
            DependencyProperty.Register("Mask", typeof(string), typeof(MaskedTextBox), new UIPropertyMetadata(null, MaskChanged));

        //callback for when the Mask property is changed
        static void MaskChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            //make sure to update the text if the mask changes
            var textBox = (MaskedTextBox)sender;
            textBox.RefreshText(textBox.MaskProvider, 0);
        }
        #endregion

        /// <summary>
        /// Static Constructor
        /// </summary>
        static MaskedTextBox()
        {
            //override the meta data for the Text Proeprty of the textbox 
            var metaData = new FrameworkPropertyMetadata
            {
                CoerceValueCallback = ForceText
            };

            TextProperty.OverrideMetadata(typeof(MaskedTextBox), metaData);
        }

        //force the text of the control to use the mask
        private static object ForceText(DependencyObject sender, object value)
        {
            var textBox = (MaskedTextBox)sender;
            if (textBox.Mask != null)
            {
                var provider = new MaskedTextProvider(textBox.Mask);
                provider.Set((string)value);
                return provider.ToDisplayString();
            }
            else
            {
                return value;
            }
        }


        public MaskedTextBox()
        {

        }

        //cancel the command
        private static void CancelCommand(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = false;
            e.Handled = true;
        }

        #region Overrides

        /// <summary>
        /// override this method to replace the characters enetered with the mask
        /// </summary>
        /// <param name="e">Arguments for event</param>
        protected override void OnPreviewTextInput(TextCompositionEventArgs e)
        {
            //if the text is readonly do not add the text
            if (IsReadOnly)
            {
                e.Handled = true;
                return;
            }

            var position = SelectionStart;
            var provider = MaskProvider;

            if (position < Text.Length)
            {
                position = GetNextCharacterPosition(position);

                if (Keyboard.IsKeyToggled(Key.Insert))
                {
                    if (provider.Replace(e.Text, position))
                        position++;
                }
                else
                {
                    if (provider.InsertAt(e.Text, position))
                        position++;
                }

                position = GetNextCharacterPosition(position);
            }

            RefreshText(provider, position);
            e.Handled = true;

            base.OnPreviewTextInput(e);
        }

        /// <summary>
        /// override the key down to handle delete of a character
        /// </summary>
        /// <param name="e">Arguments for the event</param>
        protected override void OnPreviewKeyDown(KeyEventArgs e)
        {
            base.OnPreviewKeyDown(e);
            var provider = MaskProvider;
            var position = SelectionStart;
            var selectionlength = SelectionLength;

            // If no selection use the start position else use end position
            var endposition = (selectionlength == 0) ? position : position + selectionlength - 1;

            if (e.Key == Key.Delete && position < Text.Length)//handle the delete key
            {
                if (provider.RemoveAt(position, endposition))
                    RefreshText(provider, position);

                e.Handled = true;
            }

            else if (e.Key == Key.Space)
            {
                if (provider.InsertAt(" ", position))
                    RefreshText(provider, position);
                e.Handled = true;
            }

            else if (e.Key == Key.Back)//handle the back space
            {
                if ((position > 0) && (selectionlength == 0))
                {
                    position--;
                    if (provider.RemoveAt(position))
                        RefreshText(provider, position);
                }

                if (selectionlength != 0)
                {
                    if (provider.RemoveAt(position, endposition))
                    {
                        if (position > 0)
                            position--;

                        RefreshText(provider, position);
                    }
                }

                e.Handled = true;
            }
        }
        #endregion

        #region Helper Methods

        //refreshes the text of the textbox
        private void RefreshText(MaskedTextProvider provider, int position)
        {
            Text = provider.ToDisplayString();
            SelectionStart = position;
        }
        //gets the next position in the textbox to move
        private int GetNextCharacterPosition(int startPosition)
        {
            var position = MaskProvider.FindEditPositionFrom(startPosition, true);
            if (position == -1)
                return startPosition;
            else
                return position;
        }
        #endregion
    }

}
