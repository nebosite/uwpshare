using System;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Content Dialog item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ContentDialogRepro
{
    public sealed partial class OriginalDialog : ContentDialog
    {
        public OriginalDialog()
        {
            this.InitializeComponent();
        }

        private void switchContent(object sender, RoutedEventArgs e)
        {
        }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            var rtfUri = new Uri("ms-appx:///cities.rtf");
            var file = await StorageFile.GetFileFromApplicationUriAsync(rtfUri);
            var stream = file.OpenAsync(FileAccessMode.Read);
            myRichEditBox.Document.LoadFromStream(Windows.UI.Text.TextSetOptions.FormatRtf, stream.GetResults());
        }

        private void Hide(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
    }
}
