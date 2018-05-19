﻿namespace tomenglertde.ResXManager.View
{
    using System.Windows;

    using JetBrains.Annotations;

    public static class Appearance
    {
        [CanBeNull]
        public static readonly DependencyProperty TextFontSizeProperty =
            DependencyProperty.RegisterAttached("TextFontSize", typeof(double), typeof(Appearance), new FrameworkPropertyMetadata(12.0, FrameworkPropertyMetadataOptions.Inherits));
    }
}
