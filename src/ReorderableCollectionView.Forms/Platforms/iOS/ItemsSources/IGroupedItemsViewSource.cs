using Foundation;
using Xamarin.Forms.Platform.iOS;

namespace ReorderableCollectionView.Forms
{
	public interface IGroupedItemsViewSource : IItemsViewSource
	{
		IItemsViewSource GroupItemsViewSource(NSIndexPath indexPath);
	}
}