using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

namespace ReorderableCollectionView.Forms
{
	public interface IItemsViewAdapter
	{
		IItemsViewSource ItemsSource { get; }

		ItemsView ItemsView { get; }
	}
}