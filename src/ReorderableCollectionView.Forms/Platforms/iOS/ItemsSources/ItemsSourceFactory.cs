using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UIKit;
using Xamarin.Forms.Platform.iOS;

// Cloned from the main Xamarin.Forms repository.
// Added case for when the itemsSource is already an IList. Use it, don't create a new one. Reorder only works with original list.
// Removed CreateForCarouselView. We don't need that for this library.
// https://github.com/xamarin/Xamarin.Forms/blob/5.0.0/Xamarin.Forms.Platform.iOS/CollectionView/ItemsSourceFactory.cs
namespace ReorderableCollectionView.Forms
{
	internal static class ItemsSourceFactory
	{
		public static IItemsViewSource Create(IEnumerable itemsSource, UICollectionViewController collectionViewController)
		{
			if (itemsSource == null)
			{
				return new EmptySource();
			}

			switch (itemsSource)
			{
				case IList _ when itemsSource is INotifyCollectionChanged:
					return new ObservableItemsSource(itemsSource as IList, collectionViewController);
				case IEnumerable _ when itemsSource is INotifyCollectionChanged:
					return new ObservableItemsSource(itemsSource as IEnumerable, collectionViewController);
				case IList list:
					return new ListSource(list);
				case IEnumerable<object> generic:
					return new ListSource(generic);
			}

			return new ListSource(itemsSource);
		}

		public static IItemsViewSource CreateGrouped(IEnumerable itemsSource, UICollectionViewController collectionViewController)
		{
			if (itemsSource == null)
			{
				return new EmptySource();
			}

			return new ObservableGroupedSource(itemsSource, collectionViewController);
		}
	}
}