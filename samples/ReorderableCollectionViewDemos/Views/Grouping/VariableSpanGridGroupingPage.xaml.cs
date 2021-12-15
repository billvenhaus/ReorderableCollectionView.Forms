using ReorderableCollectionViewDemos.ViewModels;
using Xamarin.Forms;

namespace ReorderableCollectionViewDemos.Views
{
    public partial class VariableSpanGridGroupingPage : ContentPage
    {
        public VariableSpanGridGroupingPage()
        {
            InitializeComponent();
            BindingContext = new GroupedAnimalsViewModel();
        }
    }
}
