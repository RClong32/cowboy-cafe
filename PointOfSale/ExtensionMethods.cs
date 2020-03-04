using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Media;
namespace PointOfSale
{
    public static class ExtensionMethods
    {

        public static FrameworkElement FindAncestor<T>(this DependencyObject element) where T : DependencyObject
        {
            var parent = VisualTreeHelper

            if (parent == null) return null;

            if (parent is T) return parent as T;

            return parent.FindAncestor<T>;
        }







    }
}
