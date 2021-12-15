using Xamarin.Forms;
using ReorderableCollectionViewDemos.ViewModels;

namespace ReorderableCollectionViewDemos.Views
{
    public partial class VerticalListPage : ContentPage
    {
        public VerticalListPage()
        {
            InitializeComponent();
            BindingContext = new MonkeysViewModel();
        }
    }
}
