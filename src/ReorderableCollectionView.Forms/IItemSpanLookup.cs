namespace ReorderableCollectionView.Forms
{
	public interface IItemSpanLookup
	{
		int GetColumnSpan(object item);
	}
}