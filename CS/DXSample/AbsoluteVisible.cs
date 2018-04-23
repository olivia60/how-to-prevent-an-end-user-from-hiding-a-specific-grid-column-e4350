using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace DXSample
{
    public class AbsoluteVisible
    {
        public static readonly DependencyProperty IsEnableProperty = DependencyProperty.RegisterAttached("IsEnable", typeof(bool), typeof(AbsoluteVisible), new UIPropertyMetadata(null));

        public static bool GetIsEnable(DependencyObject target)
        {
            return (bool)target.GetValue(IsEnableProperty);
        }

        public static void SetIsEnable(DependencyObject target, bool value)
        {
            target.SetValue(IsEnableProperty, value);
        }     
    }
}
