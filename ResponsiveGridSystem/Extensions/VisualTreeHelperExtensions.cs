using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel;
using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Media;

namespace ResponsiveGridSystem.Extensions
{
    /// <summary>
    /// Extension methods for DependencyObjects
    /// used for walking the visual tree with
    /// LINQ expressions.
    /// These simplify using VisualTreeHelper to one line calls.
    /// </summary>
    public static class VisualTreeHelperExtensions
    {
        /// <summary>
        /// Gets the first level descendants that is of the given type.
        /// </summary>
        /// <remarks>
        /// Returns null if not found.
        /// </remarks>
        /// <typeparam name="T">Type of descendant to look for.</typeparam>
        /// <param name="start">The start object.</param>
        public static IEnumerable<T> GetChildrenOfType<T>(this DependencyObject depObj) where T : DependencyObject
        {
            if (depObj == null)
            {
                yield break;
            }

            for (var i = 0; i < VisualTreeHelper.GetChildrenCount(depObj); i++)
            {
                var child = VisualTreeHelper.GetChild(depObj, i);
                if (child != null && child is T)
                {
                    yield return (T) child;
                }
                else
                {
                    foreach (T childOfChild in child.GetChildrenOfType<T>())
                    {
                        yield return childOfChild;
                    }
                }       
            }
        }

        /// <summary>
        /// Gets the first descendant that is of the given type.
        /// </summary>
        /// <remarks>
        /// Returns null if not found.
        /// </remarks>
        /// <typeparam name="T">Type of descendant to look for.</typeparam>
        /// <param name="start">The start object.</param>
        /// <returns></returns>
        public static T GetFirstDescendantOfType<T>(this DependencyObject start) where T : DependencyObject
        {
            return start.GetDescendantsOfType<T>().FirstOrDefault();
        }

        /// <summary>
        /// Gets the descendants of the given type.
        /// </summary>
        /// <typeparam name="T">Type of descendants to return.</typeparam>
        /// <param name="start">The start.</param>
        /// <returns></returns>
        public static IEnumerable<T> GetDescendantsOfType<T>(this DependencyObject start) where T : DependencyObject
        {
            return start.GetDescendants().OfType<T>();
        }

        /// <summary>
        /// Gets the descendants.
        /// </summary>
        /// <param name="start">The start.</param>
        /// <returns></returns>
        /// <param name="includeStart">Specifies whether the start object should be included in enumeration.</param>
        /// <returns>The ancestor elements, starting with parent and going towards the visual tree root.</returns>
        public static IEnumerable<DependencyObject> GetDescendants(this DependencyObject start, bool includeStart = false)
        {
            if (start == null)
            {
                yield break;
            }

            if (includeStart)
            {
                yield return start;
            }

            var queue = new Queue<DependencyObject>();

            var popup = start as Popup;

            if (popup != null)
            {
                if (popup.Child != null)
                {
                    queue.Enqueue(popup.Child);
                    yield return popup.Child;
                }
            }
            else
            {
                int childrenCount;

                try
                {
                    if (start is UIElement)
                    {
                        childrenCount = VisualTreeHelper.GetChildrenCount(start);
                    }
                    else
                    {
                        childrenCount = 0;
                    }
                }
                catch (Exception)
                {
                    childrenCount = 0;
                }

                for (int i = 0; i < childrenCount; i++)
                {
                    var child = VisualTreeHelper.GetChild(start, i);
                    queue.Enqueue(child);
                    yield return child;
                }
            }

            while (queue.Count > 0)
            {
                var parent = queue.Dequeue();

                popup = parent as Popup;

                if (popup != null)
                {
                    if (popup.Child != null)
                    {
                        queue.Enqueue(popup.Child);
                        yield return popup.Child;
                    }
                }
                else
                {
                    int childrenCount;

                    try
                    {
                        if (start is DataTemplate)
                        {
                            childrenCount = 0;
                        }
                        else
                        {
                            childrenCount = VisualTreeHelper.GetChildrenCount(start);
                        }
                    }
                    catch (Exception)
                    {
                        childrenCount = 0;
                    }

                    for (int i = 0; i < childrenCount; i++)
                    {
                        var child = VisualTreeHelper.GetChild(parent, i);
                        yield return child;
                        queue.Enqueue(child);
                    }
                }
            }
        }
    }
}
