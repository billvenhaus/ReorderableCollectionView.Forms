using ReorderableCollectionViewDemos.ViewModels;
using Xamarin.Forms;

namespace ReorderableCollectionViewDemos.Views
{
    public partial class VariableSpanGridSpacingPage : ContentPage
    {
        public VariableSpanGridSpacingPage()
        {
            InitializeComponent();
            BindingContext = new MonkeysViewModel();
        }
    }
}
