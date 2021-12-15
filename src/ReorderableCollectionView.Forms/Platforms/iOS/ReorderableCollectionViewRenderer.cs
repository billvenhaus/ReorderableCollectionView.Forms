using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ReorderableCollectionView.Forms.ReorderableCollectionView), typeof(ReorderableCollectionView.Forms.ReorderableCollectionViewRenderer))]

namespace ReorderableCollectionView.Forms
{
	internal class ReorderableCollectionViewRenderer : GroupableItemsViewRenderer<ReorderableCollectionView, ReorderableCollectionViewController<ReorderableCollectionView>>
	{
		protected override ReorderableCollectionViewController<ReorderableCollectionView> CreateController(ReorderableCollectionView itemsView, ItemsViewLayout layout)
		{
			return new ReorderableCollectionViewController<ReorderableCollectionView>(itemsView, layout);
		}

		public override SizeRequest GetDesiredSize(double widthConstraint, double heightConstraint)
		{
			if (Controller.Layout is VariableSpanGridViewLayout variableSpanLayout)
			{
				var maxWidth = Math.Min(Device.Info.ScaledScreenSize.Width, widthConstraint);
				var maxHeight = Math.Min(Device.Info.ScaledScreenSize.Height, heightConstraint);
				var fitSize = variableSpanLayout.GetSizeThatFits(maxWidth, maxHeight, Controller.ItemsSource);
				return new SizeRequest(fitSize, Size.Zero);
			}
			return base.GetDesiredSize(widthConstraint, heightConstraint);
		}

		protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs changedProperty)
		{
			base.OnElementPropertyChanged(sender, changedProperty);

			if (changedProperty.PropertyName == ReorderableCollectionView.CanReorderItemsProperty.PropertyName)
			{
				UpdateCanReorderItems();
			}
		}

		protected override ItemsViewLayout SelectLayout()
		{
			var itemsLayout = ItemsView.ItemsLayout;

			if (itemsLayout is VariableSpanGridItemsLayout variableSpanItemsLayout)
			{
				return new VariableSpanGridViewLayout(variableSpanItemsLayout);
			}
			else
			{
				return base.SelectLayout();
			}
		}

		protected override void SetUpNewElement(ReorderableCollectionView newElement)
		{
			base.SetUpNewElement(newElement);

			if (newElement == null)
			{
				return;
			}

			UpdateCanReorderItems();
		}

		void UpdateCanReorderItems()
		{
			Controller?.UpdateCanReorderItems();
		}
	}
}