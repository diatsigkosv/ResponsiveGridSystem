// ***********************************************************************
// Assembly         : ResponsiveGridSystem
// Author           : Vaggelis
// Created          : 11-14-2016
//
// Last Modified By : Vaggelis
// Last Modified On : 11-18-2016
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
    /// <seealso cref="Windows.UI.Xaml.Controls.Grid" />
    /// <seealso cref="Windows.UI.Xaml.Controls.GridViewItem" />
    public class Column : Grid
    {
        #region Properties

        /// <summary>
        /// Gets or sets the columns in mobile.
        /// </summary>
        /// <value>The columns in mobile.</value>
        /// <exception cref="System.ArgumentOutOfRangeException">ColumnsInMobile</exception>
        public int ColumnsInMobile
        {
            get { return (int)GetValue(ColumnsInMobileProperty); }
            set
            {
                if (value < 0 || value > ((Row)Parent)?.MaxColumns)
                {
                    throw new ArgumentOutOfRangeException(nameof(ColumnsInMobile));
                }
                SetValue(ColumnsInMobileProperty, value);
            }
        }

        /// <summary>
        /// Gets or sets the columns in tablet.
        /// </summary>
        /// <value>The columns in tablet.</value>
        /// <exception cref="System.ArgumentOutOfRangeException">ColumnsInTablet</exception>
        public int ColumnsInTablet
        {
            get { return (int)GetValue(ColumnsInTabletProperty); }
            set
            {
                if (value < 0 || value > ((Row)Parent)?.MaxColumns)
                {
                    throw new ArgumentOutOfRangeException(nameof(ColumnsInTablet));
                }
                SetValue(ColumnsInTabletProperty, value);
            }
        }

        /// <summary>
        /// Gets or sets the columns in desktop.
        /// </summary>
        /// <value>The columns in desktop.</value>
        /// <exception cref="System.ArgumentOutOfRangeException">ColumnsInDesktop</exception>
        public int ColumnsInDesktop
        {
            get { return (int)GetValue(ColumnsInDesktopProperty); }
            set
            {
                if (value < 0 || value > ((Row)Parent)?.MaxColumns)
                {
                    throw new ArgumentOutOfRangeException(nameof(ColumnsInDesktop));
                }
                SetValue(ColumnsInDesktopProperty, value);
            }
        }

        /// <summary>
        /// Gets or sets the columns in hub.
        /// </summary>
        /// <value>The columns in hub.</value>
        /// <exception cref="System.ArgumentOutOfRangeException">ColumnsInHub</exception>
        public int ColumnsInHub
        {
            get { return (int)GetValue(ColumnsInHubProperty); }
            set
            {
                if (value < 0 || value > ((Row)Parent)?.MaxColumns)
                {
                    throw new ArgumentOutOfRangeException(nameof(ColumnsInHub));
                }
                SetValue(ColumnsInHubProperty, value);
            }
        }

        /// <summary>
        /// Gets or sets the offset in mobile.
        /// </summary>
        /// <value>The offset in mobile.</value>
        /// <exception cref="System.ArgumentOutOfRangeException">OffsetInMobile</exception>
        public int OffsetInMobile
        {
            get { return (int)GetValue(OffsetInMobileProperty); }
            set
            {
                if (value < 0 || value > ((Row)Parent)?.MaxColumns)
                {
                    throw new ArgumentOutOfRangeException(nameof(OffsetInMobile));
                }
                SetValue(OffsetInMobileProperty, value);
            }
        }

        /// <summary>
        /// Gets or sets the offset in desktop.
        /// </summary>
        /// <value>The offset in desktop.</value>
        /// <exception cref="System.ArgumentOutOfRangeException">OffsetInDesktop</exception>
        public int OffsetInDesktop
        {
            get { return (int)GetValue(OffsetInDesktopProperty); }
            set
            {
                if (value < 0 || value > ((Row)Parent)?.MaxColumns)
                {
                    throw new ArgumentOutOfRangeException(nameof(OffsetInDesktop));
                }
                SetValue(OffsetInDesktopProperty, value);
            }
        }

        /// <summary>
        /// Gets or sets the offset in tablet.
        /// </summary>
        /// <value>The offset in tablet.</value>
        /// <exception cref="System.ArgumentOutOfRangeException">OffsetInTablet</exception>
        public int OffsetInTablet
        {
            get { return (int)GetValue(OffsetInTabletProperty); }
            set
            {
                if (value < 0 || value > ((Row)Parent)?.MaxColumns)
                {
                    throw new ArgumentOutOfRangeException(nameof(OffsetInTablet));
                }
                SetValue(OffsetInTabletProperty, value);
            }
        }

        /// <summary>
        /// Gets or sets the offset in hub.
        /// </summary>
        /// <value>The offset in hub.</value>
        /// <exception cref="System.ArgumentOutOfRangeException">OffsetInHub</exception>
        public int OffsetInHub
        {
            get { return (int)GetValue(OffsetInHubProperty); }
            set
            {
                if (value < 0 || value > ((Row)Parent)?.MaxColumns)
                {
                    throw new ArgumentOutOfRangeException(nameof(OffsetInHub));
                }
                SetValue(OffsetInHubProperty, value);
            }
        }

        /// <summary>
        /// Gets or sets the height in mobile.
        /// </summary>
        /// <value>The height in mobile.</value>
        /// <exception cref="System.ArgumentOutOfRangeException">HeightInMobile</exception>
        public double ForceHeightInMobile
        {
            get { return (double)GetValue(ForceHeightInMobileProperty); }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(ForceHeightInMobile));
                }
                SetValue(ForceHeightInMobileProperty, value);
            }
        }

        /// <summary>
        /// Gets or sets the height in tablet.
        /// </summary>
        /// <value>The height in tablet.</value>
        /// <exception cref="System.ArgumentOutOfRangeException">HeightInTablet</exception>
        public double ForceHeightInTablet
        {
            get { return (double)GetValue(ForceHeightInTabletProperty); }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(ForceHeightInTablet));
                }
                SetValue(ForceHeightInTabletProperty, value);
            }
        }

        /// <summary>
        /// Gets or sets the height in desktop.
        /// </summary>
        /// <value>The height in desktop.</value>
        /// <exception cref="System.ArgumentOutOfRangeException">HeightInDesktop</exception>
        public double ForceHeightInDesktop
        {
            get { return (double)GetValue(ForceHeightInDesktopProperty); }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(ForceHeightInDesktop));
                }
                SetValue(ForceHeightInDesktopProperty, value);
            }
        }

        /// <summary>
        /// Gets or sets the height in hub.
        /// </summary>
        /// <value>The height in hub.</value>
        /// <exception cref="System.ArgumentOutOfRangeException">HeightInHub</exception>
        public double ForceHeightInHub
        {
            get { return (double)GetValue(ForceHeightInHubProperty); }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(ForceHeightInHub));
                }
                SetValue(ForceHeightInHubProperty, value);
            }
        }

        /// <summary>
        /// Gets or sets the hide in device.
        /// </summary>
        /// <value>The hide in device.</value>
        public HideInDevices HideInDevice
        {
            get { return (HideInDevices)GetValue(HideInDeviceProperty); }
            set { SetValue(HideInDeviceProperty, value); }
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

        /// <summary>
        /// The offset in mobile property
        /// </summary>
        public static readonly DependencyProperty OffsetInMobileProperty = DependencyProperty.Register(
            "OffsetInMobile", typeof(int), typeof(Column), new PropertyMetadata(default(int)));

        /// <summary>
        /// The offset in tablet property
        /// </summary>
        public static readonly DependencyProperty OffsetInTabletProperty = DependencyProperty.Register(
            "OffsetInTablet", typeof(int), typeof(Column), new PropertyMetadata(default(int)));

        /// <summary>
        /// The offset in desktop property
        /// </summary>
        public static readonly DependencyProperty OffsetInDesktopProperty = DependencyProperty.Register(
            "OffsetInDesktop", typeof(int), typeof(Column), new PropertyMetadata(default(int)));

        /// <summary>
        /// The offset in hub property
        /// </summary>
        public static readonly DependencyProperty OffsetInHubProperty = DependencyProperty.Register(
            "OffsetInHub", typeof(int), typeof(Column), new PropertyMetadata(default(int)));

        /// <summary>
        /// The height in mobile property
        /// </summary>
        public static readonly DependencyProperty ForceHeightInMobileProperty = DependencyProperty.Register(
            "ForceHeightInMobile", typeof(double), typeof(Column), new PropertyMetadata(double.NaN));

        /// <summary>
        /// The height in tablet property
        /// </summary>
        public static readonly DependencyProperty ForceHeightInTabletProperty = DependencyProperty.Register(
            "ForceHeightInTablet", typeof(double), typeof(Column), new PropertyMetadata(double.NaN));

        /// <summary>
        /// The height in desktop property
        /// </summary>
        public static readonly DependencyProperty ForceHeightInDesktopProperty = DependencyProperty.Register(
            "ForceHeightInDesktop", typeof(double), typeof(Column), new PropertyMetadata(double.NaN));

        /// <summary>
        /// The height in hub property
        /// </summary>
        public static readonly DependencyProperty ForceHeightInHubProperty = DependencyProperty.Register(
            "ForceHeightInHub", typeof(double), typeof(Column), new PropertyMetadata(double.NaN));

        /// <summary>
        /// The hide in device property
        /// </summary>
        public static readonly DependencyProperty HideInDeviceProperty = DependencyProperty.Register(
            "HideInDevice", typeof(HideInDevices), typeof(Column), new PropertyMetadata(default(HideInDevices)));

        #endregion

        #region .ctor

        /// <summary>
        /// Initializes a new instance of the <see cref="Column" /> class.
        /// </summary>
        public Column()
        {
            MinWidth = 0;
            MinHeight = 0;
        }

        #endregion
    }
}
