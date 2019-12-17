using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace ContentDialogRepro
{
    public sealed partial class SmallDialog : ContentDialog
    {
        public SmallDialog()
        {
            this.InitializeComponent();
        }

        private void Hide(object sender, RoutedEventArgs e)
        {
             this.Hide();
        }
    }
}
