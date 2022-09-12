using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Medicine.Packages.Controls
{
    public class CapsKeyboardKey : KeyboardKey
    {
        static CapsKeyboardKey()
        { DefaultStyleKeyProperty.OverrideMetadata(typeof(CapsKeyboardKey), new FrameworkPropertyMetadata(typeof(CapsKeyboardKey))); }

        protected override void OnClick()
        {
            var eventArgs = new ModifierChangedRoutedEventArgs(KeyboardKey.CapsModifierChangedProperty, this, !this.IsCapsLocked, true);
            RaiseEvent(eventArgs);
        }
    }
}
