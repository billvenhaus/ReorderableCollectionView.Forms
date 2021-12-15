using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using AndroidX.RecyclerView.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

// Cloned from the main Xamarin.Forms repository.
// Added case for when the itemsSource is already an IList. Use it, don't create a new one. Reorder only works with original list.
// https://github.com/xamarin/Xamarin.Forms/tree/5.0.0/Xamarin.Forms.Platform.Android/CollectionView/ItemsSourceFactory.cs
namespace ReorderableCollectionView.Forms
{
	internal static class ItemsSourceFactory
	{
		public static IItemsViewSource Create(IEnumerable itemsSource, ICollectionChangedNotifier notifier)
		{
			if (itemsSource == null)
			{
				return new EmptySource();
			}

			switch (itemsSource)
			{
				case IList list when itemsSource is INotifyCollectionChanged:
					return new ObservableItemsSource(new MarshalingObservableCollection(list), notifier);
				case IEnumerable _ when itemsSource is INotifyCollectionChanged:
					return new ObservableItemsSource(itemsSource as IEnumerable, notifier);
				case IList list:
					return new ListSource(list);
				case IEnumerable<object> generic:
					return new ListSource(generic);
			}

			return new ListSource(itemsSource);
		}

		public static IItemsViewSource Create(IEnumerable itemsSource, RecyclerView.Adapter adapter)
		{
			return Create(itemsSource, new AdapterNotifier(adapter));
		}

		public static IItemsViewSource Create(ItemsView itemsView, RecyclerView.Adapter adapter)
		{
			return Create(itemsView.ItemsSource, adapter);
		}

		public static IGroupableItemsViewSource Create(GroupableItemsView itemsView, RecyclerView.Adapter adapter)
		{
			var source = itemsView.ItemsSource;

			if (itemsView.IsGrouped && source != null)
			{
				return new ObservableGroupedSource(itemsView, new AdapterNotifier(adapter));
			}

			return new UngroupedItemsSource(Create(itemsView.ItemsSource, adapter));
		}
	}
}