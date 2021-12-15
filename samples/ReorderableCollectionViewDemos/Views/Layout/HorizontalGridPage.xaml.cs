using Xamarin.Forms;
using ReorderableCollectionViewDemos.ViewModels;

namespace ReorderableCollectionViewDemos.Views
{
    public partial class HorizontalGridPage : ContentPage
    {
        public HorizontalGridPage()
        {
            InitializeComponent();
            BindingContext = new MonkeysViewModel();
        }
    }
}
