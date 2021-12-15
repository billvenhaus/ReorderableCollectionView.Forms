using ReorderableCollectionViewDemos.ViewModels;
using Xamarin.Forms;

namespace ReorderableCollectionViewDemos.Views
{
    public partial class VerticalGridGroupingCanMixGroupsPage : ContentPage
    {
        public VerticalGridGroupingCanMixGroupsPage()
        {
            InitializeComponent();
            BindingContext = new GroupedAnimalsViewModel();
        }
	}
}
