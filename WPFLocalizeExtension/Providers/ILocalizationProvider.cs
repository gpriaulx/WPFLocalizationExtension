﻿#if SILVERLIGHT
namespace SLLocalizeExtension.Providers
#else
namespace WPFLocalizeExtension.Providers
#endif
{
    using System.Windows;
    using System.Globalization;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System;

    /// <summary>
    /// An interface describing classes that provide localized values based on a source/dictionary/key combination.
    /// </summary>
    public interface ILocalizationProvider
    {
        /// <summary>
        /// Get the localized object.
        /// </summary>
        /// <param name="key">The key to the value.</param>
        /// <param name="target">The target <see cref="DependencyObject"/>.</param>
        /// <param name="culture">The culture to use.</param>
        /// <returns>The value corresponding to the source/dictionary/key path for the given culture (otherwise NULL).</returns>
        object GetLocalizedObject(string key, DependencyObject target, CultureInfo culture);

        /// <summary>
        /// An observable list of available cultures.
        /// </summary>
        ObservableCollection<CultureInfo> AvailableCultures { get; }

        /// <summary>
        /// An event when the provider changed.
        /// </summary>
        event ProviderChangedEventHandler ProviderChanged;
    }
}
