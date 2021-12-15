using ReorderableCollectionViewDemos.ViewModels;
using Xamarin.Forms;

namespace ReorderableCollectionViewDemos.Views
{
    public partial class VerticalListGroupingPage : ContentPage
    {
        public VerticalListGroupingPage()
        {
            InitializeComponent();
            BindingContext = new GroupedAnimalsViewModel();
        }
    }
}
