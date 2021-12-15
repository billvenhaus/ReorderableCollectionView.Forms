using System.Collections;
using Xamarin.Forms.Platform.Android;

namespace ReorderableCollectionView.Forms
{
	public interface IGroupedItemsViewSource : IGroupableItemsViewSource
	{
		(int, int) GetGroupAndIndex(int position);
		object GetGroup(int groupIndex);
		IItemsViewSource GetGroupItemsViewSource(int groupIndex);
	}
}