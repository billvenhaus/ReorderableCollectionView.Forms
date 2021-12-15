using System.Globalization;
using Windows.UI.Xaml.Markup;
using WDataTemplate = Windows.UI.Xaml.DataTemplate;
using WItemsPanelTemplate = Windows.UI.Xaml.Controls.ItemsPanelTemplate;

namespace ReorderableCollectionView.Forms
{
	internal static class ReorderableCollectionViewTemplates
	{
		public static WItemsPanelTemplate GetItemsWrapGrid(double itemWidth, double itemHeight)
		{
			var xaml =
				"<ItemsPanelTemplate xmlns=\"http://schemas.microsoft.com/winfx/2006/xaml/presentation\">" +
				$"<ItemsWrapGrid Orientation=\"Horizontal\" MaximumRowsOrColumns=\"-1\" Margin=\"0\" VerticalAlignment=\"Top\" ItemWidth=\"{Format(itemWidth)}\" ItemHeight=\"{Format(itemHeight)}\"/>" +
				"</ItemsPanelTemplate>";
			return (WItemsPanelTemplate)XamlReader.Load(xaml);
		}

		public static WDataTemplate GetItemTemplate()
		{
			var xaml =
				"<DataTemplate xmlns=\"http://schemas.microsoft.com/winfx/2006/xaml/presentation\" xmlns:local=\"using:ReorderableCollectionView.Forms\">" +
				"<local:ReorderableItemContentControl HorizontalContentAlignment=\"Stretch\" VerticalContentAlignment=\"Stretch\"/>" +
				"</DataTemplate>";
			return (WDataTemplate)XamlReader.Load(xaml);
		}

		public static WItemsPanelTemplate GetVariableSizedWrapGrid(double itemWidth, double itemHeight)
		{
			var xaml =
				"<ItemsPanelTemplate xmlns=\"http://schemas.microsoft.com/winfx/2006/xaml/presentation\">" +
				$"<VariableSizedWrapGrid Orientation=\"Horizontal\" MaximumRowsOrColumns=\"-1\" Margin=\"0\" VerticalAlignment=\"Top\" ItemWidth=\"{Format(itemWidth)}\" ItemHeight=\"{Format(itemHeight)}\"/>" +
				"</ItemsPanelTemplate>";
			return (WItemsPanelTemplate)XamlReader.Load(xaml);
		}

		static string Format(double number)
		{
			return number.ToString(new NumberFormatInfo() { NumberDecimalSeparator = "." });
		}
	}
}