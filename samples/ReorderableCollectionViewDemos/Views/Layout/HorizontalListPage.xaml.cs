using Xamarin.Forms;
using ReorderableCollectionViewDemos.ViewModels;

namespace ReorderableCollectionViewDemos.Views
{
    public partial class HorizontalListPage : ContentPage
    {
        public HorizontalListPage()
        {
            InitializeComponent();
            BindingContext = new MonkeysViewModel();
        }
    }
}
