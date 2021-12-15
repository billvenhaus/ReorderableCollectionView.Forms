using Windows.UI.Xaml;
using Xamarin.Forms;

namespace ReorderableCollectionView.Forms
{
	internal class FormsListViewAttachedProperties : DependencyObject
	{
		public static readonly DependencyProperty ItemsViewProperty = DependencyProperty.RegisterAttached("ItemsView", typeof(ItemsView), typeof(FormsListViewAttachedProperties), new PropertyMetadata(null));
	}
}