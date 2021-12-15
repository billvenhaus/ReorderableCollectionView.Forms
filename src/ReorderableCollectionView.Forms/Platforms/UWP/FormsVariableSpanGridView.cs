using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace ReorderableCollectionView.Forms
{
	internal class FormsVariableSpanGridView : GridView
	{
		public IItemSpanLookup ItemSpanLookup { get; set; }

		public FormsVariableSpanGridView()
		{
		}

		protected override void PrepareContainerForItemOverride(DependencyObject element, object item)
		{
			if (ItemSpanLookup != null)
			{
				var columnSpan = ItemSpanLookup.GetColumnSpan(item);
				if (columnSpan > 1)
				{
					element.SetValue(VariableSizedWrapGrid.ColumnSpanProperty, columnSpan);
				}
			}

			base.PrepareContainerForItemOverride(element, item);
		}
	}
}