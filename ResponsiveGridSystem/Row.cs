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
    public class Row : GridView
    {
        #region Properties

        /// <summary>
        /// Gets or sets the selection behavior for a ListViewBase instance.
        /// </summary>
        /// <value>The selection mode.</value>
        public new ListViewSelectionMode SelectionMode { get; private set; }

        /// <summary>
        /// Gets or sets the style that is used when rendering the item containers.
        /// </summary>
        /// <value>The item container style.</value>
        public new Style ItemContainerStyle { get; private set; }

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
            set { SetValue(MaxColumnsProperty, value); }
        }

        /// <summary>
        /// Gets or sets the maximum width of the mobile.
        /// </summary>
        /// <value>The maximum width of the mobile.</value>
        public double MaxMobileWidth
        {
            get { return (double)GetValue(Row.MaxMobileWidthProperty); }
            set { SetValue(Row.MaxMobileWidthProperty, value); }
        }

        /// <summary>
        /// Gets or sets the maximum width of the tablet.
        /// </summary>
        /// <value>The maximum width of the tablet.</value>
        public double MaxTabletWidth
        {
            get { return (double)GetValue(Row.MaxTabletWidthProperty); }
            set { SetValue(Row.MaxTabletWidthProperty, value); }
        }

        /// <summary>
        /// Gets or sets the maximum width of the desktop.
        /// </summary>
        /// <value>The maximum width of the desktop.</value>
        public double MaxDesktopWidth
        {
            get { return (double)GetValue(Row.MaxDesktopWidthProperty); }
            set { SetValue(Row.MaxDesktopWidthProperty, value); }
        }

        /// <summary>
        /// Gets or sets the column height in mobile.
        /// </summary>
        /// <value>The column height in mobile.</value>
        public double ColumnHeightInMobile
        {
            get { return (double)GetValue(ColumnHeightInMobileProperty); }
            set { SetValue(ColumnHeightInMobileProperty, value); }
        }

        /// <summary>
        /// Gets or sets the column height in tablet.
        /// </summary>
        /// <value>The column height in tablet.</value>
        public double ColumnHeightInTablet
        {
            get { return (double)GetValue(ColumnHeightInTabletProperty); }
            set { SetValue(ColumnHeightInTabletProperty, value); }
        }

        /// <summary>
        /// Gets or sets the column height in desktop.
        /// </summary>
        /// <value>The column height in desktop.</value>
        public double ColumnHeightInDesktop
        {
            get { return (double)GetValue(ColumnHeightInDesktopProperty); }
            set { SetValue(ColumnHeightInDesktopProperty, value); }
        }

        /// <summary>
        /// Gets or sets the column height in hub.
        /// </summary>
        /// <value>The column height in hub.</value>
        public double ColumnHeightInHub
        {
            get { return (double)GetValue(ColumnHeightInHubProperty); }
            set { SetValue(ColumnHeightInHubProperty, value); }
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
            Loaded += OnLoaded;
            SizeChanged += OnSizeChanged;
            ItemsPanel = GetItemsPanelTemplate();
            SelectionMode = ListViewSelectionMode.None;
            Padding = new Thickness(0);
        }

        #endregion

        #region Override Methods

        /// <summary>
        /// Prepares the container for item override.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <param name="item">The item.</param>
        protected override void PrepareContainerForItemOverride(DependencyObject obj, object item)
        {
            base.PrepareContainerForItemOverride(obj, item);
            var element = obj as FrameworkElement;
            if (element == null)
            {
                return;
            }
            element.Margin = ColumnSpace;
            element.Style = GetItemStyle();
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Handles the <see cref="E:Loaded" /> event.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="routedEventArgs">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void OnLoaded(object sender, RoutedEventArgs routedEventArgs)
        {
            var scrollViewer = this.GetFirstDescendantOfType<ScrollViewer>();
            if (scrollViewer != null)
            {
                scrollViewer.VerticalScrollBarVisibility = ScrollBarVisibility.Disabled;
                scrollViewer.VerticalScrollMode = ScrollMode.Disabled;
                scrollViewer.HorizontalScrollBarVisibility = ScrollBarVisibility.Disabled;
                scrollViewer.HorizontalScrollMode = ScrollMode.Disabled;
            }
        }

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
                double columnHeight;

                var columnsInMobile = column.ColumnsInMobile > 0 ? column.ColumnsInMobile : 12;
                var columnsInTablet = column.ColumnsInTablet > 0 ? column.ColumnsInTablet : columnsInMobile;
                var columnsInDesktop = column.ColumnsInDesktop > 0 ? column.ColumnsInDesktop : columnsInTablet;
                var columnsInHub = column.ColumnsInHub > 0 ? column.ColumnsInHub : columnsInDesktop;

                var columnHeightInMobile = ColumnHeightInMobile > 0 ? ColumnHeightInMobile : 0;
                var columnHeightInTablet = ColumnHeightInTablet > 0 ? ColumnHeightInTablet : columnHeightInMobile;
                var columnHeightInDesktop = ColumnHeightInDesktop > 0 ? ColumnHeightInDesktop : columnHeightInTablet;
                var columnHeightInHub = ColumnHeightInHub > 0 ? ColumnHeightInHub : columnHeightInDesktop;

                switch (deviceType)
                {
                    case DeviceTypeEnum.Mobile:
                        {
                            currentColumns = columnsInMobile;
                            columnHeight = columnHeightInMobile;
                            break;
                        }
                    case DeviceTypeEnum.Tablet:
                        {
                            currentColumns = columnsInTablet;
                            columnHeight = columnHeightInTablet;
                            break;
                        }
                    case DeviceTypeEnum.Desktop:
                        {
                            currentColumns = columnsInDesktop;
                            columnHeight = columnHeightInDesktop;
                            break;
                        }
                    case DeviceTypeEnum.Hub:
                        {
                            currentColumns = columnsInHub;
                            columnHeight = columnHeightInHub;
                            break;
                        }
                    default:
                        {
                            throw new ArgumentOutOfRangeException(nameof(deviceType), deviceType, null);
                        }
                }

                column.Width = (width * currentColumns / MaxColumns) - (ColumnSpace.Left + ColumnSpace.Right + 1);
                column.Height = columnHeight;
            }
        }

        /// <summary>
        /// Gets the width of the device type by window.
        /// </summary>
        /// <returns>DeviceTypeEnum.</returns>
        public DeviceTypeEnum GetDeviceTypeByWindowWidth()
        {
            var width = Window.Current.Bounds.Width;
            if (width > MaxDesktopWidth)
            {
                return DeviceTypeEnum.Hub;
            }

            if (width > MaxTabletWidth)
            {
                return DeviceTypeEnum.Desktop;
            }

            if (width > MaxMobileWidth)
            {
                return DeviceTypeEnum.Tablet;
            }

            return DeviceTypeEnum.Mobile;
        }

        /// <summary>
        /// Gets the items panel template.
        /// </summary>
        /// <returns>ItemsPanelTemplate.</returns>
        private ItemsPanelTemplate GetItemsPanelTemplate()
        {
            var xamlTemplate =
                @"<ItemsPanelTemplate 
                    xmlns='http://schemas.microsoft.com/winfx/2006/xaml/presentation' 
                    xmlns:x='http://schemas.microsoft.com/winfx/2006/xaml' 
                    xmlns:ext='using:ResponsiveGridSystem'>
                    <ext:WrapPanel Orientation='Horizontal'/>
                  </ItemsPanelTemplate>";
            return XamlReader.Load(xamlTemplate) as ItemsPanelTemplate;
        }

        /// <summary>
        /// Gets the item style.
        /// </summary>
        /// <returns>Style.</returns>
        private Style GetItemStyle()
        {
            var xamlTemplate =
                @"<Style 
                    xmlns='http://schemas.microsoft.com/winfx/2006/xaml/presentation' 
                    xmlns:x='http://schemas.microsoft.com/winfx/2006/xaml'  
                    TargetType='GridViewItem'>
                     <Setter Property='Template'>
                        <Setter.Value>
                            <ControlTemplate TargetType ='GridViewItem'>
                                <ContentPresenter/>
                            </ControlTemplate >  
                        </Setter.Value>
                    </Setter>
                </Style>";
            return XamlReader.Load(xamlTemplate) as Style;
        }

        #endregion
    }
}
