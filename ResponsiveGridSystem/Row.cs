// ***********************************************************************
// Assembly         : ResponsiveGridSystem
// Author           : Vaggelis
// Created          : 11-13-2016
//
// Last Modified By : Vaggelis
// Last Modified On : 11-15-2016
// ***********************************************************************
// <copyright file="Row.cs" company="">
//     Copyright ©  2016
// </copyright>
// <summary>Row Control</summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Media;
using ResponsiveGridSystem.Enums;
using ResponsiveGridSystem.Extensions;

namespace ResponsiveGridSystem
{
    /// <summary>
    /// Class Row.
    /// </summary>
    /// <seealso cref="Windows.UI.Xaml.Controls.GridView" />
    public class Row : WrapPanel
    {
        #region Properties

        /// <summary>
        /// Gets or sets the column space.
        /// </summary>
        /// <value>The column space.</value>
        public Thickness ColumnSpace
        {
            get { return (Thickness)GetValue(ColumnSpaceProperty); }
            set { SetValue(ColumnSpaceProperty, value); }
        }

        /// <summary>
        /// Gets or sets the maximum columns.
        /// </summary>
        /// <value>The maximum columns.</value>
        public int MaxColumns
        {
            get { return (int)GetValue(MaxColumnsProperty); }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(MaxColumns));
                }
                SetValue(MaxColumnsProperty, value);
            }
        }

        /// <summary>
        /// Gets or sets the maximum width of the mobile.
        /// </summary>
        /// <value>The maximum width of the mobile.</value>
        public double MaxMobileWidth
        {
            get { return (double)GetValue(MaxMobileWidthProperty); }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(MaxColumns));
                }
                SetValue(MaxMobileWidthProperty, value);
            }
        }

        /// <summary>
        /// Gets or sets the maximum width of the tablet.
        /// </summary>
        /// <value>The maximum width of the tablet.</value>
        public double MaxTabletWidth
        {
            get { return (double)GetValue(MaxTabletWidthProperty); }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(MaxColumns));
                }
                SetValue(MaxTabletWidthProperty, value);
            }
        }

        /// <summary>
        /// Gets or sets the maximum width of the desktop.
        /// </summary>
        /// <value>The maximum width of the desktop.</value>
        public double MaxDesktopWidth
        {
            get { return (double)GetValue(MaxDesktopWidthProperty); }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(MaxColumns));
                }
                SetValue(MaxDesktopWidthProperty, value);
            }
        }

        /// <summary>
        /// Gets or sets the column height in mobile.
        /// </summary>
        /// <value>The column height in mobile.</value>
        public double ColumnHeightInMobile
        {
            get { return (double)GetValue(ColumnHeightInMobileProperty); }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(MaxColumns));
                }
                SetValue(ColumnHeightInMobileProperty, value);
            }
        }

        /// <summary>
        /// Gets or sets the column height in tablet.
        /// </summary>
        /// <value>The column height in tablet.</value>
        public double ColumnHeightInTablet
        {
            get { return (double)GetValue(ColumnHeightInTabletProperty); }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(MaxColumns));
                }
                SetValue(ColumnHeightInTabletProperty, value);
            }
        }

        /// <summary>
        /// Gets or sets the column height in desktop.
        /// </summary>
        /// <value>The column height in desktop.</value>
        public double ColumnHeightInDesktop
        {
            get { return (double)GetValue(ColumnHeightInDesktopProperty); }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(MaxColumns));
                }
                SetValue(ColumnHeightInDesktopProperty, value);
            }
        }

        /// <summary>
        /// Gets or sets the column height in hub.
        /// </summary>
        /// <value>The column height in hub.</value>
        public double ColumnHeightInHub
        {
            get { return (double)GetValue(ColumnHeightInHubProperty); }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(MaxColumns));
                }
                SetValue(ColumnHeightInHubProperty, value);
            }
        }

        #endregion

        #region Dependency Properties

        /// <summary>
        /// The column space property
        /// </summary>
        public static readonly DependencyProperty ColumnSpaceProperty = DependencyProperty.Register(
            "ColumnSpace", typeof(Thickness), typeof(Row), new PropertyMetadata(default(Thickness)));

        /// <summary>
        /// The maximum columns property
        /// </summary>
        public static readonly DependencyProperty MaxColumnsProperty = DependencyProperty.Register(
            "MaxColumns", typeof(int), typeof(Row), new PropertyMetadata(12));

        /// <summary>
        /// The maximum mobile width property
        /// </summary>
        public static readonly DependencyProperty MaxMobileWidthProperty = DependencyProperty.Register(
            "MaxMobileWidth", typeof(double), typeof(Row), new PropertyMetadata(640.0));

        /// <summary>
        /// The maximum tablet width property
        /// </summary>
        public static readonly DependencyProperty MaxTabletWidthProperty = DependencyProperty.Register(
            "MaxTabletWidth", typeof(double), typeof(Row), new PropertyMetadata(1007.0));

        /// <summary>
        /// The maximum desktop width property
        /// </summary>
        public static readonly DependencyProperty MaxDesktopWidthProperty = DependencyProperty.Register(
            "MaxDesktopWidth", typeof(double), typeof(Row), new PropertyMetadata(1920.0));

        /// <summary>
        /// The column height in mobile property
        /// </summary>
        public static readonly DependencyProperty ColumnHeightInMobileProperty = DependencyProperty.Register(
            "ColumnHeightInMobile", typeof(double), typeof(Row), new PropertyMetadata(default(double)));

        /// <summary>
        /// The column height in tablet property
        /// </summary>
        public static readonly DependencyProperty ColumnHeightInTabletProperty = DependencyProperty.Register(
            "ColumnHeightInTablet", typeof(double), typeof(Row), new PropertyMetadata(default(double)));

        /// <summary>
        /// The column height in desktop property
        /// </summary>
        public static readonly DependencyProperty ColumnHeightInDesktopProperty = DependencyProperty.Register(
            "ColumnHeightInDesktop", typeof(double), typeof(Row), new PropertyMetadata(default(double)));

        /// <summary>
        /// The column height in hub property
        /// </summary>
        public static readonly DependencyProperty ColumnHeightInHubProperty = DependencyProperty.Register(
            "ColumnHeightInHub", typeof(double), typeof(Row), new PropertyMetadata(default(double)));

        #endregion

        #region .ctor

        /// <summary>
        /// Initializes a new instance of the <see cref="Row"/> class.
        /// </summary>
        public Row()
        {
            SizeChanged += OnSizeChanged;
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Handles the <see cref="E:SizeChanged" /> event.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="SizeChangedEventArgs"/> instance containing the event data.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">deviceType - null</exception>
        private void OnSizeChanged(object sender, SizeChangedEventArgs e)
        {
            var width = e.NewSize.Width;
            var deviceType = GetDeviceTypeByWindowWidth();
            var columns = this.GetChildrenOfType<Column>().ToList();
            foreach (var column in columns)
            {

                int currentColumns;
                int currentOffset;
                double columnHeight;
                bool isHidden;

                var columnsInMobile = column.ColumnsInMobile > 0 ? column.ColumnsInMobile : 12;
                var columnsInTablet = column.ColumnsInTablet > 0 ? column.ColumnsInTablet : columnsInMobile;
                var columnsInDesktop = column.ColumnsInDesktop > 0 ? column.ColumnsInDesktop : columnsInTablet;
                var columnsInHub = column.ColumnsInHub > 0 ? column.ColumnsInHub : columnsInDesktop;

                var offsetInMobile = column.OffsetInMobile > 0 ? column.OffsetInMobile : 0;
                var offsetInTablet = column.OffsetInTablet > 0 ? column.OffsetInTablet : offsetInMobile;
                var offsetInDesktop = column.OffsetInDesktop > 0 ? column.OffsetInDesktop : offsetInTablet;
                var offsetInHub = column.OffsetInHub > 0 ? column.OffsetInHub : offsetInDesktop;

                var columnHeightInMobile = ColumnHeightInMobile > 0 ? ColumnHeightInMobile : 0;
                var columnHeightInTablet = ColumnHeightInTablet > 0 ? ColumnHeightInTablet : columnHeightInMobile;
                var columnHeightInDesktop = ColumnHeightInDesktop > 0 ? ColumnHeightInDesktop : columnHeightInTablet;
                var columnHeightInHub = ColumnHeightInHub > 0 ? ColumnHeightInHub : columnHeightInDesktop;

                switch (deviceType)
                {
                    case DeviceTypes.Mobile:
                        {
                            currentColumns = columnsInMobile;
                            currentOffset = offsetInMobile;
                            columnHeight = columnHeightInMobile;
                            isHidden = column.HideInDevice.HasFlags(HideInDevices.MobileDown | HideInDevices.TabletDown | HideInDevices.DesktopDown | HideInDevices.HubDown | HideInDevices.MobileUp);
                            break;
                        }
                    case DeviceTypes.Tablet:
                        {
                            currentColumns = columnsInTablet;
                            currentOffset = offsetInTablet;
                            columnHeight = columnHeightInTablet;
                            isHidden = column.HideInDevice.HasFlags(HideInDevices.TabletDown | HideInDevices.DesktopDown | HideInDevices.HubDown | HideInDevices.MobileUp | HideInDevices.TabletUp);
                            break;
                        }
                    case DeviceTypes.Desktop:
                        {
                            currentColumns = columnsInDesktop;
                            currentOffset = offsetInDesktop;
                            columnHeight = columnHeightInDesktop;
                            isHidden = column.HideInDevice.HasFlags(HideInDevices.DesktopDown | HideInDevices.HubDown | HideInDevices.MobileUp | HideInDevices.TabletUp | HideInDevices.DesktopUp);
                            break;
                        }
                    case DeviceTypes.Hub:
                        {
                            currentColumns = columnsInHub;
                            currentOffset = offsetInHub;
                            columnHeight = columnHeightInHub;
                            isHidden = column.HideInDevice.HasFlags(HideInDevices.HubDown | HideInDevices.MobileUp | HideInDevices.TabletUp | HideInDevices.DesktopUp | HideInDevices.HubUp);
                            break;
                        }
                    default:
                        {
                            throw new ArgumentOutOfRangeException(nameof(deviceType), deviceType, null);
                        }
                }

                var offsetWidth = 0.0;
                if (currentOffset > 0)
                {
                    offsetWidth = CalculateCurrentWidth(width, currentOffset);
                }

                column.Width = CalculateCurrentWidth(width, currentColumns);
                column.Height = columnHeight;
                column.Margin = new Thickness(ColumnSpace.Left + offsetWidth, ColumnSpace.Top, ColumnSpace.Right, ColumnSpace.Bottom);
                column.Visibility = isHidden ? Visibility.Collapsed : Visibility.Visible;
            }
        }

        /// <summary>
        /// Gets the width of the device type by window.
        /// </summary>
        /// <returns>DeviceTypeEnum.</returns>
        private DeviceTypes GetDeviceTypeByWindowWidth()
        {
            var width = Window.Current.Bounds.Width;
            if (width > MaxDesktopWidth)
            {
                return DeviceTypes.Hub;
            }

            if (width > MaxTabletWidth)
            {
                return DeviceTypes.Desktop;
            }

            if (width > MaxMobileWidth)
            {
                return DeviceTypes.Tablet;
            }

            return DeviceTypes.Mobile;
        }


        /// <summary>
        /// Calculates the current width.
        /// </summary>
        /// <param name="width">The width.</param>
        /// <param name="columns">The columns.</param>
        /// <returns></returns>
        private double CalculateCurrentWidth(double width, double columns)
        {
            return width * columns / Convert.ToDouble(MaxColumns) - (ColumnSpace.Left + ColumnSpace.Right + 0.5);
        }

        #endregion
    }
}
