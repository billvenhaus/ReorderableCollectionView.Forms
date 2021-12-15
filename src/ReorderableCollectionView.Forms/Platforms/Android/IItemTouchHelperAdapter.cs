namespace ReorderableCollectionView.Forms
{
	public interface IItemTouchHelperAdapter
	{
		bool OnItemMove(int fromPosition, int toPosition);
	}
}