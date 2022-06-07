using System.Windows;
using System.Windows.Controls;

namespace DialogMessage.Dialogs.Colapsible
{
    public class CollapsibleColumn : ColumnDefinition
    {
        #region Fields
        private GridLength cachedHeight;
        private double cachedMinHeight;
        #endregion

        #region Dependency Properties
        public static readonly DependencyProperty CollapsedProperty =
            DependencyProperty.Register("Collapsed", typeof(bool), typeof(CollapsibleColumn), new PropertyMetadata(false, OnCollapsedChanged));

        private static void OnCollapsedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is CollapsibleColumn column && e.NewValue is bool collapsed)
            {
                if (collapsed)
                {
                    if (column.MinWidth != 0)
                    {
                        column.cachedMinHeight = column.MinWidth;
                        column.MinWidth = 0;
                    }
                    column.cachedHeight = column.Width;
                }
                else if (column.cachedMinHeight != 0)
                {
                    column.MinWidth = column.cachedMinHeight;
                }
                column.Width = collapsed ? new GridLength(0) : column.cachedHeight;
            }
        }
        #endregion

        #region Properties
        public bool Collapsed
        {
            get => (bool)GetValue(CollapsedProperty);
            set => SetValue(CollapsedProperty, value);
        }
        #endregion
    }
}
