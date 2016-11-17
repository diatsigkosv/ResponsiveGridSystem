// ***********************************************************************
// Assembly         : ResponsiveGridSystem
// Author           : Vaggelis
// Created          : 11-14-2016
//
// Last Modified By : Vaggelis
// Last Modified On : 11-15-2016
// ***********************************************************************
// <copyright file="Column.cs" company="">
//     Copyright ©  2016
// </copyright>
// <summary>Column Control</summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using ResponsiveGridSystem.Enums;

namespace ResponsiveGridSystem
{
    /// <summary>
    /// Class Column.
    /// </summary>
    /// <seealso cref="Windows.UI.Xaml.Controls.GridViewItem" />
    public class Column : Grid
    {
        #region Properties

        /// <summary>
        /// Gets or sets the columns in mobile.
        /// </summary>
        /// <value>The columns in mobile.</value>
        public int ColumnsInMobile
        {
            get { return (int)GetValue(ColumnsInMobileProperty); }
            set { SetValue(ColumnsInMobileProperty, value); }
        }

        /// <summary>
        /// Gets or sets the columns in tablet.
        /// </summary>
        /// <value>The columns in tablet.</value>
        public int ColumnsInTablet
        {
            get { return (int)GetValue(ColumnsInTabletProperty); }
            set { SetValue(ColumnsInTabletProperty, value); }
        }

        /// <summary>
        /// Gets or sets the columns in desktop.
        /// </summary>
        /// <value>The columns in desktop.</value>
        public int ColumnsInDesktop
        {
            get { return (int)GetValue(ColumnsInDesktopProperty); }
            set { SetValue(ColumnsInDesktopProperty, value); }
        }

        /// <summary>
        /// Gets or sets the columns in hub.
        /// </summary>
        /// <value>The columns in hub.</value>
        public int ColumnsInHub
        {
            get { return (int)GetValue(ColumnsInHubProperty); }
            set { SetValue(ColumnsInHubProperty, value); }
        }

        #endregion

        #region Dependency Properties

        /// <summary>
        /// The columns in mobile property
        /// </summary>
        public static readonly DependencyProperty ColumnsInMobileProperty = DependencyProperty.Register(
            "ColumnsInMobile", typeof(int), typeof(Column), new PropertyMetadata(default(int)));

        /// <summary>
        /// The columns in tablet property
        /// </summary>
        public static readonly DependencyProperty ColumnsInTabletProperty = DependencyProperty.Register(
            "ColumnsInTablet", typeof(int), typeof(Column), new PropertyMetadata(default(int)));

        /// <summary>
        /// The columns in desktop property
        /// </summary>
        public static readonly DependencyProperty ColumnsInDesktopProperty = DependencyProperty.Register(
            "ColumnsInDesktop", typeof(int), typeof(Column), new PropertyMetadata(default(int)));

        /// <summary>
        /// The columns in hub property
        /// </summary>
        public static readonly DependencyProperty ColumnsInHubProperty = DependencyProperty.Register(
            "ColumnsInHub", typeof(int), typeof(Column), new PropertyMetadata(default(int)));

        #endregion

        #region .ctor

        /// <summary>
        /// Initializes a new instance of the <see cref="Column"/> class.
        /// </summary>
        public Column()
        {
            MinWidth = 0;
            MinHeight = 0;
        }

        #endregion
    }
}
