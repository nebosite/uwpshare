using System;
using Windows.UI.Xaml.Controls;

namespace ContentDialogRepro
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.Loaded += async (s, e) => { await new SmallDialog().ShowAsync(); };
        }
    }
}
