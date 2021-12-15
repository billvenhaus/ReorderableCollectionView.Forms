using Xamarin.Forms;
using ReorderableCollectionViewDemos.ViewModels;
using ReorderableCollectionView.Forms;
using ReorderableCollectionViewDemos.Models;

namespace ReorderableCollectionViewDemos.Views
{
    public partial class VariableSpanGridPage : ContentPage
    {
        public VariableSpanGridPage()
        {
            InitializeComponent();
            BindingContext = new MonkeysViewModel();
        }
    }
}
