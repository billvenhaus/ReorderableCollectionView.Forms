using System.Collections;
using Xamarin.Forms.Platform.Android;

namespace ReorderableCollectionView.Forms
{
	public interface IObservableItemsViewSource : IItemsViewSource
	{
		bool ObserveChanges { get; set; }
	}
}