﻿using System.ComponentModel;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

namespace ReorderableCollectionView.Forms
{
	// We need the Bindable attribute to load the control with XamlReader.
	// Otherwise we'll see the error => "WinRT information: The type 'ReorderableItemContentControl' was not found."
	// https://stackoverflow.com/a/15139410
	[Windows.UI.Xaml.Data.Bindable]
	public class ReorderableItemContentControl : ItemContentControl
	{
		ItemsView _itemsView;

		public ReorderableItemContentControl()
		{
			DataContextChanged += OnDataContextChanged;
			Loading += OnLoading;
		}

		ItemsView FindItemsView()
		{
			var parent = VisualTreeHelper.GetParent(this);
			while (parent != null)
			{
				var listView = parent as ListViewBase;
				if (listView != null)
				{
					return listView.GetValue(FormsListViewAttachedProperties.ItemsViewProperty) as CollectionView;
				}

				parent = VisualTreeHelper.GetParent(parent);
			}
			return null;
		}

		void OnDataContextChanged(FrameworkElement sender, DataContextChangedEventArgs args)
		{
			FormsDataContext = DataContext;
		}

		void OnFormsContainerPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			if (e.PropertyName == ItemsView.ItemTemplateProperty.PropertyName)
			{
				UpdateFormsDataTemplate();
			}
		}

		void OnLoading(FrameworkElement sender, object args)
		{
			_itemsView = FindItemsView();

			UpdateFormsContainer();
		}

		void UpdateFormsContainer()
		{
			if (FormsContainer != null)
			{
				FormsContainer.PropertyChanged -= OnFormsContainerPropertyChanged;
			}
			FormsContainer = _itemsView;
			if (FormsContainer != null)
			{
				FormsContainer.PropertyChanged += OnFormsContainerPropertyChanged;
			}

			UpdateFormsDataTemplate();
		}

		void UpdateFormsDataTemplate()
		{
			if (FormsContainer != null)
			{
				FormsDataTemplate = _itemsView?.ItemTemplate;
			}
		}
	}
}