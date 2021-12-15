using Xamarin.Forms;
using ReorderableCollectionViewDemos.ViewModels;

namespace ReorderableCollectionViewDemos.Views
{
    public partial class VerticalGridPage : ContentPage
    {
        public VerticalGridPage()
        {
            InitializeComponent();
            BindingContext = new MonkeysViewModel();
        }
    }
}
