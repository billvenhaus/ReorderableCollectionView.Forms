using System;
using Foundation;
using Xamarin.Forms.Platform.iOS;

// Cloned from the main Xamarin.Forms repository.
// No changes were made.
// https://github.com/xamarin/Xamarin.Forms/blob/5.0.0/Xamarin.Forms.Platform.iOS/CollectionView/EmptySource.cs
namespace ReorderableCollectionView.Forms
{
	internal class EmptySource : ILoopItemsViewSource
	{
		public int GroupCount => 0;

		public int ItemCount => 0;

		public bool Loop { get; set; }

		public int LoopCount => 0;

		public object this[NSIndexPath indexPath] => throw new IndexOutOfRangeException("IItemsViewSource is empty");

		public int ItemCountInGroup(nint group) => 0;

		public object Group(NSIndexPath indexPath)
		{
			throw new IndexOutOfRangeException("IItemsViewSource is empty");
		}

		public NSIndexPath GetIndexForItem(object item)
		{
			throw new IndexOutOfRangeException("IItemsViewSource is empty");
		}

		public void Dispose()
		{
		}
	}
}