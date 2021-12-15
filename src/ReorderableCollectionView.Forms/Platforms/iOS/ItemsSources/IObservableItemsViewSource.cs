using Xamarin.Forms.Platform.iOS;

namespace ReorderableCollectionView.Forms
{
	public interface IObservableItemsViewSource : IItemsViewSource
	{
		bool ObserveChanges { get; set; }
	}
}