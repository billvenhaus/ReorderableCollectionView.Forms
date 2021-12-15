using ReorderableCollectionViewDemos.ViewModels;
using Xamarin.Forms;

namespace ReorderableCollectionViewDemos.Views
{
    public partial class VerticalGridGroupingPage : ContentPage
    {
        public VerticalGridGroupingPage()
        {
            InitializeComponent();
            BindingContext = new GroupedAnimalsViewModel();
        }
    }
}
