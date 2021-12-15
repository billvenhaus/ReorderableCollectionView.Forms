using Xamarin.Forms.Platform.Android;

// Cloned from the main Xamarin.Forms repository.
// No changes were made.
// https://github.com/xamarin/Xamarin.Forms/tree/5.0.0/Xamarin.Forms.Platform.Android/CollectionView/ICollectionChangedNotifier.cs
namespace ReorderableCollectionView.Forms
{
	// Lets observable items sources notify observers about dataset changes
	internal interface ICollectionChangedNotifier
	{
		void NotifyDataSetChanged();
		void NotifyItemChanged(IItemsViewSource source, int startIndex);
		void NotifyItemInserted(IItemsViewSource source, int startIndex);
		void NotifyItemMoved(IItemsViewSource source, int fromPosition, int toPosition);
		void NotifyItemRangeChanged(IItemsViewSource source, int start, int end);
		void NotifyItemRangeInserted(IItemsViewSource source, int startIndex, int count);
		void NotifyItemRangeRemoved(IItemsViewSource source, int startIndex, int count);
		void NotifyItemRemoved(IItemsViewSource source, int startIndex);
	}
}